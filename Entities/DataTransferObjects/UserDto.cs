using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public record UserDto
    {
        [Required(ErrorMessage = "User Name is required.")]
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid value.")]
        public string? Email { get; init; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Enter a valid value.")]
        public string? PhoneNumber { get; init; }

        public HashSet<string> Roles { get; set; } = new HashSet<string>();
    }
}
