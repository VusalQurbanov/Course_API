using AutoMapper;
using Course_API.BLL.Abstract;
using Course_API.DAL.Abstract;
using Course_API.DAL.Abstract.ILessonTimes;
using Course_API.DTOs.GroupDTO;
using Course_API.Entities;

namespace Course_API.BLL.Concrete
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        private readonly ILessonDaysRepository _lessonDaysRepository;
        private readonly ILessonHoursRepository _lessonHoursRepository;
        public GroupService(IMapper mapper,IGroupRepository  groupRepository,IStudentRepository studentRepository,
            ILessonDaysRepository lessonDaysRepository,ILessonHoursRepository lessonHoursRepository)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
            _studentRepository = studentRepository;
            _lessonDaysRepository = lessonDaysRepository;
            _lessonHoursRepository = lessonHoursRepository;
        }

        public void Add(GroupToAddDTO groupToAddDTO)
        {
            var group = _mapper.Map<Group>(groupToAddDTO);
            _groupRepository.Add(group);
        }

        public void Delete(int id)
        {
            _groupRepository.Delete(id);
        }

        public List<GroupToListDTO> GetAll()
        {
            var groups = _mapper.Map<List<GroupToListDTO>>(_groupRepository.GetAll());
            return groups;
        }

        public void UpdateDays(int id,List<int> ids)
        {
            var group = _groupRepository.GetById(id);
            List<LessonDays> days = _lessonDaysRepository.GetLessonDays(ids);
            group.LessonDay = days;
            _groupRepository.Update(group);
        }

        public void UpdateHours(int id, List<int> ids)
        {
            var group = _groupRepository.GetById(id);
            List<LessonHours> hours = _lessonHoursRepository.GetLessonHours(ids);
            group.LessonHour = hours;
            _groupRepository.Update(group);
        }

        public void UpdateStudent(int id, List<int> ids)
        {
            var group = _groupRepository.GetById(id);
            List<Student> students = _studentRepository.GetStudents(ids);
            group.Student = students;
            _groupRepository.Update(group);
        }
    }
}
