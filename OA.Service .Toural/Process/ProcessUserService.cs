using AutoMapper;
using OA.Common.Constants;
using OA.Common.Exceptions;
using OA.Data.Toural.Process;
using OA.Repo.Troual.Contracts.IProcess;
using OA.Service_.Toural.Contracts.JWTService;
using OA.Service_.Toural.Contracts.Process;
using OA.Service_.Toural.ViewModels.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service_.Toural.Process
{
    public  class ProcessUserService: IProcessUserService
    {
        private readonly IMapper _mapper;
        private readonly IProcessUserRepository _repository;
        private readonly IJWService _jwtService;
        public ProcessUserService(IProcessUserRepository repository,
             IJWService jwtService,
                                IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._jwtService = jwtService;
        }


        public ProcessVM Edit(ProcessUserDto generalParamterPoco)
        {

            var result = new ProcessVM();
            try
            {

                var entity = _repository.Get(generalParamterPoco.ID);
                entity.ModifiedById = _jwtService.GetUserID();
                _repository.Update(entity);
                _repository.SaveChanges();

            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public ProcessVM GetByID(long ID)
        {
            var result = new ProcessVM();
            try
            {
                result.processUserDto = _mapper.Map<ProcessUserEntity, ProcessUserDto>(_repository.Get(ID));
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public ProcessVM Remove(long[] id)
        {
            var result = new ProcessVM();
            try
            {
                foreach (var item in id)
                {
                    var entity = _repository.Get(item);
                    entity.IsEnabled = false;
                }
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public ProcessVM Search(ProcessUserDto body)
        {
            var result = new ProcessVM();
            try
            {
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        private Expression<Func<ProcessUserEntity, bool>> query(Expression<Func<ProcessUserEntity, bool>> expression)
        {
            return expression;
        }

        public ProcessVM Insert(ProcessUserDto body)
        {
            var result = new ProcessVM();
            try
            {
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public ProcessVM GetAll()
        {
            var result = new ProcessVM();
            try
            {
                result.processUserDtos =
                    _mapper.Map<List<ProcessUserEntity>, List<ProcessUserDto>>(_repository.GetALL());
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public ProcessVM Remove(long id)
        {
            var result = new ProcessVM();
            try
            {
                var entity = _repository.Get(id);
                entity.IsEnabled = false;
                 entity.ModifiedById = _jwtService.GetUserID(); ;
                _repository.SaveChanges();
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public ProcessVM Active(long id)
        {
            var result = new ProcessVM();
            try
            {
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public ProcessVM GetByIDs(long[] Id)
        {
            var result = new ProcessVM();
            try
            {
                var entities = _repository.GetByIds(Id);
                result.processUserDtos = _mapper.Map<List<ProcessUserEntity>,List<ProcessUserDto>>(entities);
            }
            catch (CustomErrorException ex)
            {
                result.Code = ex.Code;
                result.ErrorMessage = ex.errorMessage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
