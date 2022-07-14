using System.ComponentModel.DataAnnotations;

namespace StudentPortfolio.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage ="Please enter student Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public int Rank { get; set; }
    }
}
