using AutoMapper;
using Course_API.BLL.Abstract;
using Course_API.DAL.Abstract;
using Course_API.DTOs.StudentDTO;
using Course_API.Entities;
using System.Net.WebSockets;

namespace Course_API.BLL.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public StudentService(IStudentRepository studentRepository,IMapper mapper)
        {
            _studentRepository= studentRepository;
            _mapper= mapper;
        }
        public void Add(StudentToAddDTO studentToAddDTO)
        {
            var student = _mapper.Map<Student>(studentToAddDTO);
            _studentRepository.Add(student);
        }

        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

        public List<StudentToListDTO> Get()
        {
            var student = _mapper.Map<List<StudentToListDTO>>(_studentRepository.Get());
            return student;
        }

        public void Update(int id, StudentToUpdateDTO studentToUpdateDTO)
        {
            Student entity = _mapper.Map<Student>(studentToUpdateDTO);
            entity.StudentId = id;
            _studentRepository.Update(entity);
        }

        public void UpdateGroup(int id, int groupid)
        {
            Student student = _studentRepository.GetById(id);
            student.GroupId= groupid;
            _studentRepository.Update(student);
        }

    }
}
