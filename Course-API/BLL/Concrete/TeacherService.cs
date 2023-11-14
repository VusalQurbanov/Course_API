using AutoMapper;
using Course_API.BLL.Abstract;
using Course_API.DAL.Abstract;
using Course_API.DTOs.TeacherDTO;
using Course_API.Entities;

namespace Course_API.BLL.Concrete
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;
        private readonly IGroupRepository _groupRepository;
        public TeacherService(IMapper mapper, ITeacherRepository teacherRepository, IGroupRepository groupRepository)
        {
            _mapper= mapper;
            _teacherRepository= teacherRepository;
            _groupRepository= groupRepository;

        }
        public void Add(TeacherToAddDTO teacherToAddDTO)
        {
            var teacher = _mapper.Map<Teacher>(teacherToAddDTO);
            _teacherRepository.Add(teacher);
        }

        public void Delete(int id)
        { 
            _teacherRepository.Delete(id);
        }

        public List<TeacherToListDTO> Get()
        {
            var teachers = _mapper.Map<List<TeacherToListDTO>>(_teacherRepository.Get());
            return teachers;
        }

        public void Update(int id, TeacherToUpdateDTO teacherToUpdateDTO)
        {
            Teacher entity = _mapper.Map<Teacher>(teacherToUpdateDTO);
            entity.TeacherId = id;
            _teacherRepository.Update(entity);
        }

        public void UpdateGroup(int id, List<int> ids)
        {
            Teacher entity = _teacherRepository.GetById(id);
            entity.Group=_groupRepository.GetGroups(ids);
            _teacherRepository.Update(entity);
        }
    }
}
