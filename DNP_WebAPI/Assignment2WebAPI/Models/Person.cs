using System.ComponentModel.DataAnnotations;

namespace Assignment2WebAPI.Models
{
    public class Person
    {
        
        [Range(1,int.MaxValue,ErrorMessage = "please enter a value bigger than {1}")]
        public int Id { get; set; }
        [Required,MaxLength(128)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public int Height { get; set; }
        public string Sex { get; set; }
    }
}