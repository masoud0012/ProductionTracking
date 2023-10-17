using Microsoft.AspNetCore.Mvc;
using OA.Service_.Toural.Contracts.JobService;
using OA.Service_.Toural.ViewModels.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController:Controller
    {
        private readonly IJobServices _service;
        public JobController(IJobServices processService)
        {
            this._service = processService;
        }


        [Route("GetAll")]
        [HttpGet]
        public async Task<JobVM> GetById()
        {
            await Task.FromResult(0);
            return _service.GetJobs();
        }

        [Route("Get/{Id}")]
        [HttpGet]
        public  FileContentResult GetById(string Id)
        {
            var excelFile = _service.GetJob(Id);
            return File(excelFile.Content, excelFile.contentType, excelFile.fileName);
        }
    }
}
