using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class ApplicationRole : IdentityRole
    {

        public string? Descriptions;
    }
}
