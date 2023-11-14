using Course_API.BLL.Abstract;
using Course_API.BLL.Abstract.ILessonTimeService;
using Course_API.BLL.Concrete;
using Course_API.BLL.Concrete.LessonTimeService;
using Course_API.BLL.Mapper;
using Course_API.DAL;
using Course_API.DAL.Abstract;
using Course_API.DAL.Abstract.ILessonTimes;
using Course_API.DAL.Concrete;
using Course_API.DAL.Concrete.LessonTimes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddDbContext<MyContext> (options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
});


builder.Services.AddScoped<ILessonDaysRepository, LessonDaysRepository>();
builder.Services.AddScoped<ILessonDaysService, LessonDaysService>();

builder.Services.AddScoped<ILessonHoursRepository, LessonHoursRepository>();
builder.Services.AddScoped<ILessonHoursService, LessonHoursService>();

builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<ILessonService, LessonService>();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<ITeacherService, TeacherService>();

builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IRoomService, RoomService>();

builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<IGroupService, GroupService>();

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICourseService, CourseService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
