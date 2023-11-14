using Course_API.BLL.Abstract;
using Course_API.DTOs.StudentDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost]
        public IActionResult Add([FromBody] StudentToAddDTO studentToAddDTO)
        {
            _studentService.Add(studentToAddDTO);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _studentService.Get();
            return Ok(data);
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] StudentToUpdateDTO studentToUpdateDTO)
        {
            _studentService.Update(id, studentToUpdateDTO);
            return Ok();
        }
        [HttpPut("Group/{id}")]
        public IActionResult UpdateGroup([FromRoute] int id, [FromQuery] int groupid)
        {
            _studentService.UpdateGroup(id, groupid);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _studentService.Delete(id);
            return Ok();
        }
    }
}
