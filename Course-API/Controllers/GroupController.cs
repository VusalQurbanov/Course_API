using Course_API.BLL.Abstract;
using Course_API.BLL.Concrete;
using Course_API.DTOs.GroupDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }
        [HttpPost]
        public IActionResult Add([FromBody] GroupToAddDTO groupToAddDTO)
        {
            _groupService.Add(groupToAddDTO);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var groups = _groupService.GetAll();
            return Ok(groups);
        }
        [HttpPut("Students/{id}")]
        public IActionResult UpdateStudents([FromRoute] int id, [FromBody] List<int> studentids)
        {
            _groupService.UpdateStudent(id, studentids);
            return Ok();
        }
        [HttpPut("Days/{id}")]
        public IActionResult UpdateDays([FromRoute] int id, [FromBody] List<int> ids)
        {
            _groupService.UpdateDays(id, ids);
            return Ok();
        }
        [HttpPut("Hours/{id}")]
        public IActionResult UpdateHours([FromRoute] int id, [FromBody] List<int> ids)
        {
            _groupService.UpdateHours(id, ids);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _groupService.Delete(id);
            return Ok();
        }
    }
}
