using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge.Controllers
{
    public class CodeChallengeController : Controller
    {
        public CodeChallengeDBContext _context;

        public CodeChallengeController(CodeChallengeDBContext context)
        {
            _context = context;
            if (!_context.CodeChallengeDS.Any())
            {
                _context.CodeChallengeDS.Add(new CodeChallengeDataset
                {   });
                _context.SaveChanges();
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IEnumerable<CodeChallengeDataset> GetCodeChallengeDS()
        {
            return _context.CodeChallengeDS;
        }
        [HttpPost]
        public IActionResult AddCodeChallengeDataset(CodeChallengeDataset CodeChallengeDS)
        {
            if (CodeChallengeDS == null)
                return BadRequest();

            _context.CodeChallengeDS.Add(CodeChallengeDS);
            _context.SaveChanges();

            return CreatedAtRoute("GetCodeChallenge", new { id = CodeChallengeDS.Id }, CodeChallengeDS);
        }
    }
}