using WebAppCoreDb.Interface;
using WebAppCoreDb.Models.Identity;

namespace WebAppCoreDb.Models.Work
{
    public class Works : IEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public AppUser User { get; set; }

        public TaskType TaskType { get; set; }

        public DateTime Start { get; set; }= DateTime.Now;

        public DateTime End { get; set; }

        public bool IsFinished { get; set; }

        private DateTime DateStamp { get; set; }
    }
}
