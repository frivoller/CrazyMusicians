using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models
{
    public class MusicianDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Profession is required")]
        [StringLength(100, ErrorMessage = "Profession cannot be longer than 100 characters")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "Funny trait is required")]
        [StringLength(200, ErrorMessage = "Funny trait cannot be longer than 200 characters")]
        public string FunnyTrait { get; set; }
    }
} 