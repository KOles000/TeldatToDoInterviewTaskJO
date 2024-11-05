using System.ComponentModel.DataAnnotations;

namespace TeldatToDoInterviewTaskJO.Models
{
    public class Assigment
    {
        public int AssigmentId { get; set; }

        public string AssigmentName { get; set; }

        public string AssigmentDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime AssigmentDate { get; set; }
    }
}
