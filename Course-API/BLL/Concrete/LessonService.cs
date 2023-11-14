using AutoMapper;
using Course_API.BLL.Abstract;
using Course_API.DAL.Abstract;
using Course_API.DTOs.LessonDTO;
using Course_API.Entities;

namespace Course_API.BLL.Concrete
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly IMapper _mapper;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IGroupRepository _groupRepository;
        public LessonService(ILessonRepository lessonRepository,IMapper mapper, ITeacherRepository teacherRepository,
            IGroupRepository groupRepository)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
            _teacherRepository = teacherRepository;
            _groupRepository = groupRepository;
        }

        public void AddLesson(LessonToAddDTO lessonAddDto)
        {
            Lesson lesson = _mapper.Map<Lesson>(lessonAddDto);
            _lessonRepository.AddLesson(lesson);
        }

        public void DeleteLesson(int id)
        {
            _lessonRepository.DeleteLesson(id);
        }

        public List<LessonToListDTO> GetAll()
        {
            var data = _mapper.Map<List<LessonToListDTO>>(_lessonRepository.Get());
            return data;
        }

        public void UpdateGroup(int id, List<int> ids)
        {
            var lesson = _lessonRepository.GetById(id);
            List<Group> groups = _groupRepository.GetGroups(ids);
            lesson.Groups= groups;
            _lessonRepository.UpdateLesson(lesson);
        }

        public void UpdateLesson(int id,LessonToUpdateDTO lessonToUpdateDTO)
        {
            Lesson entity = _mapper.Map<Lesson>(lessonToUpdateDTO);
            entity.LessonId = id;
            _lessonRepository.UpdateLesson(entity);
        }

        public void UpdateTeacher(int id, List<int> ids)
        {
            var lesson = _lessonRepository.GetById(id);
            List<Teacher> teachers = _teacherRepository.GetTeachers(ids);
            lesson.Teacher = teachers;
            _lessonRepository.UpdateLesson(lesson);
        }
    }
}
