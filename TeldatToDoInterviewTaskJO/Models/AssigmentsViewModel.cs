namespace TeldatToDoInterviewTaskJO.Models
{
    public class AssigmentsViewModel
    {
        public IEnumerable<Assigment> AssigmentsToday { get; set; }

        public IEnumerable<Assigment> AssigmentsTomorrow { get; set; }

        public DateTime chosenDate { get; set; }
    }
}
