using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;
using Voterr.Candidates.Api.Authorization;
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
        [RequiredScope(Scopes.CandidatesRead)]
        public IEnumerable<Candidate> Get()
        {
            var displayName = User.GetDisplayName();
            var objectId = User.GetObjectId();
            var tenantId = User.GetTenantId();
            
            _logger.LogInformation("Retrieving candidates for {DisplayName} with object id {ObjectId} and tenant id {TenantId}", displayName, objectId, tenantId);
            return _candidatesService.GetCandidates();
        }
    }
}