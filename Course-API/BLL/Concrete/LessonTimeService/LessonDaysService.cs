using AutoMapper;
using Course_API.BLL.Abstract.ILessonTimeService;
using Course_API.DAL.Abstract.ILessonTimes;
using Course_API.DTOs.LessonTimeDTO;
using Course_API.Entities;

namespace Course_API.BLL.Concrete.LessonTimeService
{
    public class LessonDaysService : ILessonDaysService
    {
        private readonly IMapper _mapper;
        private readonly ILessonDaysRepository _lessonDaysRepository;
        public LessonDaysService(IMapper mapper, ILessonDaysRepository lessonDaysRepository)
        {
            _mapper = mapper;
            _lessonDaysRepository = lessonDaysRepository;
        }

        public List<LessonDaysToListDTO> GetLessonDays()
        {
            var data = _mapper.Map<List<LessonDaysToListDTO>>(_lessonDaysRepository.LessonDays());
            return data;
        }
    }
}
