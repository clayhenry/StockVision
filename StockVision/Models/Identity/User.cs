using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StockVision.Models.Identity
{
    public class User : IdentityUser
    {
        [ForeignKey("Profile")]
        public int profileId { get; set; }
        public Profile Profile { get; set; }
   
    }
}