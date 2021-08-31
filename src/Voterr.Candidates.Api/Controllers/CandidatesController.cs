using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;
using Voterr.Candidates.Api.Models;
using Voterr.Candidates.Api.Services;

namespace Voterr.Candidates.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/candidates")]
    public class CandidatesController : ControllerBase
    {
        private readonly ILogger<CandidatesController> _logger;
        private readonly CandidatesService _candidatesService;

        public CandidatesController(ILogger<CandidatesController> logger, CandidatesService candidatesService)
        {
            _logger = logger;
            _candidatesService = candidatesService;
        }

        [HttpGet]
        public IEnumerable<Candidate> Get()
        {
            return _candidatesService.GetCandidates();
        }
    }
}