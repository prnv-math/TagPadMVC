namespace Tagpad.Models
{
#pragma warning disable CS8618

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        //Below property supports EF. Not included in DB Schema
        public List<NoteTagRecord>? NoteTags {get; set;}
    }
#pragma warning restore CS8618
}
