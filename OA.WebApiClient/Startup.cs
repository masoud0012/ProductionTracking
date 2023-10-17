using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using OA.Data.Toural.UserEntity;
using OA.Data.UserEntity;
using OA.Mapping.AutoMapper;
using OA.Repo.Troual;
using OA.Repo.Troual.BaseRepository;
using OA.Repo.Troual.Contracts;
using OA.Repo.Troual.Contracts.DashboardRepository;
using OA.Repo.Troual.Contracts.IController;
using OA.Repo.Troual.Contracts.ICost;
using OA.Repo.Troual.Contracts.IFlowProcess;
using OA.Repo.Troual.Contracts.ILogEntity;
using OA.Repo.Troual.Contracts.InitialBalance;
using OA.Repo.Troual.Contracts.IProcess;
using OA.Repo.Troual.Contracts.ITableInfo;
using OA.Repo.Troual.Contracts.IUser;
using OA.Repo.Troual.Contracts.Job;
using OA.Repo.Troual.Contracts.StockRoom;
using OA.Repo.Troual.ControllerRepository;
using OA.Repo.Troual.Cost;
using OA.Repo.Troual.DashboardRepository;
using OA.Repo.Troual.FlowProcessRepsitory;
using OA.Repo.Troual.InitialBalanceRepository;
using OA.Repo.Troual.JobRepository;
using OA.Repo.Troual.LogEntityRepository;
using OA.Repo.Troual.ProcessRepository;
using OA.Repo.Troual.StockRoomRepository;
using OA.Repo.Troual.TableInfo;
using OA.Repo.Troual.UserRepository;
using OA.Service_.Toural;
using OA.Service_.Toural.Contracts;
using OA.Service_.Toural.Contracts.ControllerService;
using OA.Service_.Toural.Contracts.Cost;
using OA.Service_.Toural.Contracts.FlowProcess;
using OA.Service_.Toural.Contracts.JobService;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.Contracts.PDFService;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.Contracts.StockRoom;
using OA.Service_.Toural.Contracts.UserContracts;
using OA.Service_.Toural.ControllerService;
using OA.Service_.Toural.Cost;
using OA.Service_.Toural.DashboardService;
using OA.Service_.Toural.FlowProcess;
using OA.Service_.Toural.InitialBalance;
using OA.Service_.Toural.JobService;
using OA.Service_.Toural.JWTService;
using OA.Service_.Toural.PdfService;
using OA.Service_.Toural.Process;
using OA.Service_.Toural.StockRoom;
using OA.Service_.Toural.UserService;
using OA.Service_.Toural.ViewModels;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Diagnostics;
using System.Text;
using static OA.WebApiClient.RequestResponseLoggingMiddleware;

namespace OA.WebApiClient
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .SetIsOriginAllowed((host) => true)
                        .AllowCredentials());
            });
            services.AddTransient<IPasswordValidator<User>, CustomPasswordValidator>();
            services.AddControllers();
            services.AddDbContext<TouralContext>(options => 
                                                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                                                setSqlOption=> setSqlOption.EnableRetryOnFailure())
                                            .EnableSensitiveDataLogging(true));
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(jwt =>
                {
                    var key = Encoding.ASCII.GetBytes(Configuration["JwtConfig:Secret"]);
                    jwt.SaveToken = true;
                    jwt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        RequireExpirationTime = false
                    };
                });

            services.AddIdentity<User, RoleEntity>(c =>
            {
                c.Password.RequireDigit = false;
                c.Password.RequiredLength = 5;
                c.Password.RequireLowercase = false;
                c.Password.RequireNonAlphanumeric = false;
                c.Password.RequireUppercase = false;
                c.User.RequireUniqueEmail = false;
                c.SignIn.RequireConfirmedAccount = false;
            })
                .AddEntityFrameworkStores<TouralContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            #region Services
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IStockRoom_BalanceService, StockRoom_BalanceService>();
            services.AddTransient<UserManager<User>, UserManager<User>>();
            services.AddTransient<RoleManager<RoleEntity>, RoleManager<RoleEntity>>();
            services.AddTransient<SignInManager<User>, SignInManager<User>>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRoleServices, RoleServices>();
            services.AddTransient<IGeneralParameterService, GeneralParameterService>();
            services.AddTransient<IStockRoomService, StockRoomService>();
            services.AddTransient<IInitialBalanceService, InitialBalanceService>();
            services.AddTransient<IProcessBalanceService, ProcessBalanceService>();
            services.AddTransient<IProcessService, ProcessService>();
            services.AddTransient<IFlowProcessService, FlowProcessService>();
            services.AddTransient<IProcessDefinitionService, ProcessDefinitionService>();
            services.AddTransient<IJobServices ,JobServices > ();
            services.AddTransient<IPdfService, PdfService>();
            services.AddTransient<IActionService, ActionService>();
            services.AddTransient<IControllService, ControllService>();
            services.AddTransient<IControllerUserRepository, ControllerUserRepository>();
            services.AddTransient<IActionsUserRepository, ActionsUserRepository>();
            services.AddTransient<IActionsRoleRepository, ActionsRoleRepository>();
            services.AddTransient<IJWService, JWTService>();
            services.AddTransient<IDashboardService, DashboardService>();
            services.AddOptions();
            services.AddSingleton(Configuration.GetSection("PermissionActions").Get<PersmissionActionsVM>());
            #endregion

            #region repositories
            services.AddTransient<IProcessUserRepository, ProcessUserRepository>();
            services.AddTransient<IProcessDefinitionRepository, ProcessDefinitionRepository>();
            services.AddTransient<IGeneralParameterRepository, GeneralParameterRepository>();
            services.AddTransient<IInitialBalanceRepository, InitialBalanceRepository>();
            services.AddTransient<IStockRoomRepository, StockRoomRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IStockRoom_InitialBalanceRepository, StockRoom_InitialBalanceRepository>();
            services.AddTransient<IProcessRepository, ProcessRepository>();
            services.AddTransient<IProcessBalanceRepository, ProcessBalanceRepository>();
            services.AddTransient<IFlowProcessRepository, FlowProcessRepository>();
            services.AddTransient<ITableInfoRepository, TableInfoRepository>();
            services.AddTransient<IProcessBalanceStockRepository, ProcessBalanceStockRepository>();
            services.AddTransient<IFlowProcessUserSalaryRepository, FlowProcessUserSalaryRepository>();
            services.AddTransient<IFlowUsersSalaryService, FlowUsersSalaryService>();
            services.AddTransient<IProcessUserService, ProcessUserService>();
            services.AddTransient<IWastageRepository, WastageRepository>();
            services.AddTransient<ICostRepository, CostRepository>();
            services.AddTransient<ICostCategoryRepository, CostCategoryRepository>();
            services.AddTransient<ICostService, CostService>();
            services.AddTransient<ICostCategoryService, CostCategoryService>();
            services.AddTransient<IFlowProcessStockInitialRepository, FlowProcessStockInitialRepository>();
            services.AddTransient<IJobRepository, JobRepository>();
            services.AddTransient<ICostJobRepository, CostJobRepository>();
            services.AddTransient<IInitialBalanceJobRepository, InitialBalanceJobRepository>();
            services.AddTransient<IControllerRoleRepository, ControllerRoleRepository>();
            services.AddTransient<IControllerRepository, ControllerRepository>();
            services.AddTransient<IActionRepository, ActionRepository>();
            services.AddTransient<IDashboardRepository, DashboardRepository>();
            services.AddTransient<ILogEntityRepository, LogEntityRepository>();

            
            #endregion



            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            

            // Add Quartz services
            services.AddSingleton<IJobFactory, SingletonJobFactory>();
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();

            // Add our job
            services.AddSingleton<CostJobService>();
            //services.AddSingleton(new JobSchedule(
            //    jobType: typeof(CostJobService),
            //    cronExpression: "1 * 11 ? * * *"));
            services.AddSingleton(new JobSchedule(
                    jobType: typeof(CostJobService),
                    cronExpression: "1 2 * ? * * *"));
            services.AddHostedService<QuartzHostedService>();


            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);


            var provider = services.BuildServiceProvider();
            var usrManager = provider.GetRequiredService<UserManager<User>>();
            var roleManager = provider.GetRequiredService<RoleManager<RoleEntity>>();
            ModelBuilderExtensions.SeedData(usrManager, roleManager);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();


            }
            void RequestResponseHandler(RequestProfilerModel requestProfilerModel)
            {
                Debug.Print(requestProfilerModel.Request);
                Debug.Print(Environment.NewLine);
                Debug.Print(requestProfilerModel.Response);
            }
            app.UseCors("CorsPolicy");
            app.UseMiddleware<RequestResponseLoggingMiddleware>((Action<RequestProfilerModel>)RequestResponseHandler);
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }
}
