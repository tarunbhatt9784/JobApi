using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using JobApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly JobContext _context;

        public JobController(JobContext context)
        {
            _context = context;


        }

        [HttpGet]
        public ActionResult<List<Job>> GetAll()
        {System.Diagnostics.Debug.WriteLine("Get ALL");
            return _context.Jobs.ToList();
        }

        [HttpGet("{id}", Name = "GetJob")]
        public ActionResult<Job> GetJobById(int jobId)
        {
            var item = _context.Jobs.Find(jobId);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost("create")]
         public ActionResult<Job> Create(Job job)
        {
            System.Diagnostics.Debug.WriteLine("SomeText*************************************");
            _context.Jobs.Add(job);
            _context.SaveChanges();
            return job;
        }


    }
}