using Course_API.DAL.Abstract.ILessonTimes;
using Course_API.Entities;

namespace Course_API.DAL.Concrete.LessonTimes
{
    public class LessonHoursRepository : ILessonHoursRepository
    {
        private readonly MyContext _myContext;
        public LessonHoursRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public List<LessonHours> GetLessonHours(List<int> ids)
        {
            var data = _myContext.LessonHours.Where(v=> ids.Contains(v.LessonHoursId)).ToList();
            return data;
        }

        public List<LessonHours> LessonHours()
        {
            var data = _myContext.LessonHours.ToList();
            return data;
        }
    }
}
