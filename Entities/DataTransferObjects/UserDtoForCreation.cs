using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public record UserDtoForCreation : UserDto
    {
        [Required(ErrorMessage = "Passsword is required.")]
        [DataType(DataType.Password, ErrorMessage = "Enter a valid value.")]
        public string? Password { get; init; }
    }
}
