using System.ComponentModel.DataAnnotations;

namespace Nøsted.Models
{
    public record CreateRoleViewModel([property: Required] string RoleName);
}