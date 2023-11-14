using AutoMapper;
using Course_API.DTOs.CourseDTO;
using Course_API.DTOs.GroupDTO;
using Course_API.DTOs.LessonDTO;
using Course_API.DTOs.LessonTimeDTO;
using Course_API.DTOs.RoomDTO;
using Course_API.DTOs.StudentDTO;
using Course_API.DTOs.TeacherDTO;
using Course_API.Entities;

namespace Course_API.BLL.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            //Lesson
            CreateMap<LessonToAddDTO, Lesson>();
            CreateMap<Lesson, LessonToListDTO>();
            CreateMap<LessonToUpdateDTO, Lesson>();
            //Student
            CreateMap<StudentToAddDTO, Student>();
            CreateMap<Student, StudentToListDTO>();
            CreateMap<StudentToUpdateDTO, Student>();
            //Teacher
            CreateMap<TeacherToAddDTO, Teacher>();
            CreateMap<Teacher, TeacherToListDTO>();
            CreateMap<TeacherToUpdateDTO, Teacher>();
            //Room
            CreateMap<RoomToAddDTO, Room>();
            CreateMap<Room, RoomToListDTO>();
            //Group
            CreateMap<GroupToAddDTO, Group>();
            CreateMap<Group, GroupToListDTO>();
            //Course
            CreateMap<Course, CourseToListDTO>();
            CreateMap<CourseToAddDTO, Course>();
            //LessonDays
            CreateMap<LessonDays, LessonDaysToListDTO>();
            //LessonHours
            CreateMap<LessonHours, LessonHoursToListDTO>();
        }
    }
}
