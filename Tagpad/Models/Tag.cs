using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tagpad.Models
{
#pragma warning disable CS8618

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        //Below property supports EF. Not included in DB Schema
        public virtual List<NoteTagRecord>? NoteTags {get; set;}

        public string? UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual IdentityUser? User { get; set; }
    }
#pragma warning restore CS8618
}
