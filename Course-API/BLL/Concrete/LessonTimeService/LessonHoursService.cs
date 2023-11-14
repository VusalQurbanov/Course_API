using AutoMapper;
using Course_API.BLL.Abstract.ILessonTimeService;
using Course_API.DAL.Abstract.ILessonTimes;
using Course_API.DTOs.LessonTimeDTO;

namespace Course_API.BLL.Concrete.LessonTimeService
{
    public class LessonHoursService : ILessonHoursService
    {
        private readonly IMapper _mapper;
        private readonly ILessonHoursRepository _lessonHoursRepository;
        public LessonHoursService(IMapper mapper, ILessonHoursRepository lessonHoursRepository)
        {
            _lessonHoursRepository= lessonHoursRepository;
            _mapper = mapper;
        }
        public List<LessonHoursToListDTO> GetLessonHours()
        {
            var data = _mapper.Map<List<LessonHoursToListDTO>>(_lessonHoursRepository.LessonHours());
            return data;
        }
    }
}
