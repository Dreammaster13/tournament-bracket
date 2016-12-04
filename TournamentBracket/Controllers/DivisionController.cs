using TournamentBracket.Dtos;
using TournamentBracket.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace TournamentBracket.Controllers
{
    [Authorize]
    [RoutePrefix("api/division")]
    public class DivisionController : ApiController
    {
        public DivisionController(IDivisionService divisionService)
        {
            _divisionService = divisionService;
        }

        [Route("add")]
        [HttpPost]
        [ResponseType(typeof(DivisionAddOrUpdateResponseDto))]
        public IHttpActionResult Add(DivisionAddOrUpdateRequestDto dto) { return Ok(_divisionService.AddOrUpdate(dto)); }

        [Route("update")]
        [HttpPut]
        [ResponseType(typeof(DivisionAddOrUpdateResponseDto))]
        public IHttpActionResult Update(DivisionAddOrUpdateRequestDto dto) { return Ok(_divisionService.AddOrUpdate(dto)); }

        [Route("get")]
        [AllowAnonymous]
        [HttpGet]
        [ResponseType(typeof(ICollection<DivisionDto>))]
        public IHttpActionResult Get() { return Ok(_divisionService.Get()); }

        [Route("getById")]
        [HttpGet]
        [ResponseType(typeof(DivisionDto))]
        public IHttpActionResult GetById(int id) { return Ok(_divisionService.GetById(id)); }

        [Route("remove")]
        [HttpDelete]
        [ResponseType(typeof(int))]
        public IHttpActionResult Remove(int id) { return Ok(_divisionService.Remove(id)); }

        protected readonly IDivisionService _divisionService;


    }
}
