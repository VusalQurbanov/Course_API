using Course_API.BLL.Abstract.ILessonTimeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonTimesController : ControllerBase
    {
        private readonly ILessonDaysService _lessonDaysService;
        private readonly ILessonHoursService _lessonHoursService;
        public LessonTimesController(ILessonHoursService lessonHoursService,ILessonDaysService lessonDaysService )
        {
            _lessonHoursService = lessonHoursService;
            _lessonDaysService= lessonDaysService;
        }
        [HttpGet("Days")]
        public IActionResult GetDays()
        {
            var data = _lessonDaysService.GetLessonDays();
            return Ok(data);
        }
        [HttpGet("Hours")] 
        public IActionResult GetHours()
        {
            var data = _lessonHoursService.GetLessonHours() ;
            return Ok(data);
        }
    }
}
