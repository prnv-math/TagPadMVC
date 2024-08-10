using Microsoft.EntityFrameworkCore;
using Tagpad.Models;

namespace Tagpad.Data
{
    public class NoteContext : DbContext
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
            //define many-to-many relationship
            modelBuilder.Entity<NoteTagRecord>().HasOne(ntr => ntr.Note).WithMany(n => n.NoteTags).HasForeignKey(ntr => ntr.NoteID);
            modelBuilder.Entity<NoteTagRecord>().HasOne(ntr => ntr.Tag).WithMany(t => t.NoteTags).HasForeignKey(ntr => ntr.TagID);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<NoteTagRecord> NoteTagRecords { get; set; }
    }
}
