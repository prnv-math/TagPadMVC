using Microsoft.EntityFrameworkCore;
using Tagpad.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace Tagpad.Data
{
    public class NoteContext : IdentityDbContext
    {
        public NoteContext (DbContextOptions<NoteContext> options) : base ( options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            //set composite primary key for junction table
            modelBuilder.Entity<NoteTagRecord>().HasKey(ntr => new
            {
                ntr.TagID,
                ntr.NoteID
            }
            );
            //define one-to-many relationship where 'User' does not have any list of Notes/Tags.
            //Also disable Multiple cascading paths by disabling cascading on Tags.
            modelBuilder.Entity<Note>().HasOne(n => n.User).WithMany().HasForeignKey(n=>n.UserID);
            modelBuilder.Entity<Note>().HasOne(t => t.User).WithMany().OnDelete(DeleteBehavior.Restrict).HasForeignKey(t => t.UserID);

            //define many-to-many relationship
            modelBuilder.Entity<NoteTagRecord>().HasOne(ntr => ntr.Note).WithMany(n => n.NoteTags).HasForeignKey(ntr => ntr.NoteID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<NoteTagRecord>().HasOne(ntr => ntr.Tag).WithMany(t => t.NoteTags).HasForeignKey(ntr => ntr.TagID).OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<NoteTagRecord> NoteTagRecords { get; set; }
    }
}
