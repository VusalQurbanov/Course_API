using Course_API.BLL.Abstract;
using Course_API.DTOs.TeacherDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.CodeAnalysis;

namespace Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] TeacherToAddDTO teacherToAddDTO)
        {
            _teacherService.Add(teacherToAddDTO);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var teachers = _teacherService.Get();
            return Ok(teachers);
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute]int id, [FromBody] TeacherToUpdateDTO teacherToUpdateDTO)
        {
           _teacherService.Update(id, teacherToUpdateDTO);
            return Ok();
        }
        [HttpPut("Group/{id}")]
        public IActionResult UpdateGroup([FromRoute] int id, [FromBody] List<int> groupids)
        {

            _teacherService.UpdateGroup(id, groupids);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _teacherService.Delete(id);
            return Ok();
        }

    }
}
