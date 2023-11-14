using AutoMapper;
using Course_API.BLL.Abstract;
using Course_API.DAL.Abstract;
using Course_API.DTOs.CourseDTO;
using Course_API.Entities;

namespace Course_API.BLL.Concrete
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly ILessonRepository _lessonRepository;
        private readonly IGroupRepository _groupRepository;
        public CourseService(IMapper mapper, ICourseRepository courseRepository, ITeacherRepository teacherRepository
        , IStudentRepository studentRepository, IRoomRepository roomRepository,ILessonRepository lessonRepository, IGroupRepository groupRepository)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
            _roomRepository = roomRepository;
            _lessonRepository = lessonRepository;
            _groupRepository = groupRepository;
        }
        public void Add(CourseToAddDTO courseToAddDTO)
        {
            var course = _mapper.Map<Course>(courseToAddDTO);
            _courseRepository.Add(course);
        }

        public void Delete(int id)
        {
            _courseRepository.Delete(id);
        }

        public List<CourseToListDTO> GetAll()
        {
            var courses = _mapper.Map<List<CourseToListDTO>>(_courseRepository.GetAll());
            return courses;
        }

        public void UpdateGroup(int id, List<int> ids)
        {
            var course = _courseRepository.GetById(id);
            List<Group> groups = _groupRepository.GetGroups(ids);
            course.Group = groups;
            _courseRepository.Update(course);
        }

        public void UpdateLesson(int id, List<int> ids)
        {
            var course = _courseRepository.GetById(id);
            List<Lesson> lessons = _lessonRepository.GetLessons(ids);
            course.Lesson = lessons;
            _courseRepository.Update(course);
        }

        public void UpdateRoom(int id, List<int> ids)
        {
            var course = _courseRepository.GetById(id);
            List<Room> rooms = _roomRepository.GetRooms(ids);
            course.Room= rooms;
            _courseRepository.Update(course);
        }

        public void UpdateStudent(int id, List<int> ids)
        {
            var course = _courseRepository.GetById(id);
            List<Student> students = _studentRepository.GetStudents(ids);
            course.Student = students;
            _courseRepository.Update(course);
        }

        public void UpdateTeacher(int id, List<int> ids)
        {
            var course = _courseRepository.GetById(id);
            List<Teacher> teachers = _teacherRepository.GetTeachers(ids);
            course.Teacher = teachers;
            _courseRepository.Update(course);
        }
    }
}
