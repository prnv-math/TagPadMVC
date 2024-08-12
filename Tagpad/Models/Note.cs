using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Tagpad.Models
{
#pragma warning disable CS8618
    public class Note
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        //Below property supports EF.Not included in DB Schema
        public virtual List<NoteTagRecord>? NoteTags { get; set; }

        []
        public string? UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual IdentityUser? User { get; set; }

        //compiler by-default creates the constructor below internally when none is there.
        //public Note() { }
    }
#pragma warning restore CS8618
}
