using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public record AddRoleDto
    {
        [Required(ErrorMessage = "Role name is required.")]
        public string? Name { get; init; }

        public string? NormalizedName { get; init; } = nameof(Name).ToUpperInvariant();
    }
}
