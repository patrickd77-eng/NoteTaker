using System.ComponentModel.DataAnnotations;

namespace NoteTaker.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Details { get; set; }
        
    } 
}