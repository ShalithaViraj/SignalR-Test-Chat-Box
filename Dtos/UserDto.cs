using System.ComponentModel.DataAnnotations;

namespace chatBox.Dtos
{
    public class UserDto
    {
        [Required]
        [StringLength(15, MinimumLength =3, ErrorMessage ="Name must have 3 characters")]
        public string Name { get; set; }
    }
}
