using Course_API.BLL.Abstract;
using Course_API.BLL.Concrete;
using Course_API.DTOs.CourseDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpPost]
        public IActionResult Add([FromBody] CourseToAddDTO courseToAddDTO)
        {
            _courseService.Add(courseToAddDTO);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var courses = _courseService.GetAll();
            return Ok(courses);
        }
        [HttpPut("Teachers/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] List<int> Teacherids)
        {
            _courseService.UpdateTeacher(id, Teacherids);
            return Ok();
        }
        [HttpPut("Groups/{id}")]
        public IActionResult UpdateGr([FromRoute] int id, [FromBody] List<int> groupids)
        {
            _courseService.UpdateGroup(id, groupids);
            return Ok();
        }
        [HttpPut("Lessons/{id}")]
        public IActionResult UpdateLes([FromRoute] int id, [FromBody] List<int> lessonids)
        {
            _courseService.UpdateLesson(id, lessonids);
            return Ok();
        }
        [HttpPut("Rooms/{id}")]
        public IActionResult UpdateRm([FromRoute] int id, [FromBody] List<int> roomids)
        {
            _courseService.UpdateRoom(id, roomids);
            return Ok();
        }
        [HttpPut("Students/{id}")]
        public IActionResult UpdateSt([FromRoute] int id, [FromBody] List<int> studentids)
        {
            _courseService.UpdateStudent(id, studentids);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _courseService.Delete(id);
            return Ok();
        }
    }
}
