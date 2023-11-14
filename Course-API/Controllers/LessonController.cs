using AutoMapper;
using Course_API.BLL.Abstract;
using Course_API.BLL.Concrete;
using Course_API.DTOs.LessonDTO;
using Course_API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService= lessonService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var data =  _lessonService.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Add([FromBody]LessonToAddDTO lessonToAddDTO)
        {
            _lessonService.AddLesson(lessonToAddDTO);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLesson([FromRoute]int id, [FromBody] LessonToUpdateDTO toUpdateDTO)
        {
            _lessonService.UpdateLesson(id, toUpdateDTO);
            return Ok();
        }

        [HttpPut("Teacher/{id}")]
        public IActionResult UpdateTeacher([FromRoute]int id, [FromBody] List<int> teacherids)
        {
            _lessonService.UpdateTeacher(id, teacherids);
            return Ok();
        }

        [HttpPut("Group/{id}")]
        public IActionResult UpdateGroup([FromRoute] int id, [FromBody] List<int> groupids)
        {
            _lessonService.UpdateGroup(id, groupids);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _lessonService.DeleteLesson(id);
            return Ok();
        }
    }
}
