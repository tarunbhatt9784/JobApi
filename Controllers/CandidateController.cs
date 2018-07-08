using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using JobApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly JobContext _context;

        public CandidateController(JobContext context)
        {
            _context = context;

            
        }

        [HttpGet]
        public ActionResult<List<Candidate>> GetAll()
        {
            return _context.Candidates.ToList();
        }

        [HttpGet("{id}", Name = "GetCandidate")]
        public ActionResult<Candidate> GetCandidateId(int candidateId)
        {
            var item = _context.Candidates.Find(candidateId);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

       

             
    }
}