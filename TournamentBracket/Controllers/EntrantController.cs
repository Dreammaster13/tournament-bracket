using TournamentBracket.Dtos;
using TournamentBracket.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace TournamentBracket.Controllers
{
    [Authorize]
    [RoutePrefix("api/entrant")]
    public class EntrantController : ApiController
    {
        public EntrantController(IEntrantService entrantService)
        {
            _entrantService = entrantService;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(EntrantAddOrUpdateResponseDto))]
        public IHttpActionResult Add(EntrantAddOrUpdateRequestDto dto) { return Ok(_entrantService.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(EntrantAddOrUpdateResponseDto))]
        public IHttpActionResult Update(EntrantAddOrUpdateRequestDto dto) { return Ok(_entrantService.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<EntrantDto>))]
        public IHttpActionResult Get() { return Ok(_entrantService.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(EntrantDto))]
        public IHttpActionResult GetById(int id) { return Ok(_entrantService.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_entrantService.Remove(id)); }

        protected readonly IEntrantService _entrantService;


    }
}
