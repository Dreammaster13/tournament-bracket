using TournamentBracket.Dtos;
using TournamentBracket.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace TournamentBracket.Controllers
{
    [Authorize]
    [RoutePrefix("api/match")]
    public class MatchController : ApiController
    {
        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(MatchAddOrUpdateResponseDto))]
        public IHttpActionResult Add(MatchAddOrUpdateRequestDto dto) { return Ok(_matchService.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(MatchAddOrUpdateResponseDto))]
        public IHttpActionResult Update(MatchAddOrUpdateRequestDto dto) { return Ok(_matchService.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<MatchDto>))]
        public IHttpActionResult Get() { return Ok(_matchService.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(MatchDto))]
        public IHttpActionResult GetById(int id) { return Ok(_matchService.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_matchService.Remove(id)); }

        protected readonly IMatchService _matchService;


    }
}
