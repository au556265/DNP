namespace BlazorAssignment.Models
{
    public class Adult : Person {
        public Adult()
        {
            JobPosition= new Job(); 
        }
        
        public Job JobPosition { get; set; }
    }
}