using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Course : ContextBase
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
        public Course()
        {
            Modules = new List<Module>();
        }
    }
}


