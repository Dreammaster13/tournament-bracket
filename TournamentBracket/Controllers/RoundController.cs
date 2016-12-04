using TournamentBracket.Dtos;
using TournamentBracket.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace TournamentBracket.Controllers
{
    [Authorize]
    [RoutePrefix("api/round")]
    public class RoundController : ApiController
    {
        public RoundController(IRoundService roundService)
        {
            _roundService = roundService;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(RoundAddOrUpdateResponseDto))]
        public IHttpActionResult Add(RoundAddOrUpdateRequestDto dto) { return Ok(_roundService.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(RoundAddOrUpdateResponseDto))]
        public IHttpActionResult Update(RoundAddOrUpdateRequestDto dto) { return Ok(_roundService.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<RoundDto>))]
        public IHttpActionResult Get() { return Ok(_roundService.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(RoundDto))]
        public IHttpActionResult GetById(int id) { return Ok(_roundService.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_roundService.Remove(id)); }

        protected readonly IRoundService _roundService;


    }
}
