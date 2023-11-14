using Course_API.DAL.Abstract.ILessonTimes;
using Course_API.Entities;

namespace Course_API.DAL.Concrete.LessonTimes
{
    public class LessonDaysRepository : ILessonDaysRepository
    {
        private readonly MyContext _myContext;
        public LessonDaysRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public List<LessonDays> GetLessonDays(List<int> ids)
        {
           var data = _myContext.LessonDays.Where(v=> ids.Contains(v.LessonDaysId)).ToList();
            return data;
        }

        public List<LessonDays> LessonDays()
        {
            var data = _myContext.LessonDays.ToList();
            return data;
        }
    }
}
