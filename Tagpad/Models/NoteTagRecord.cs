namespace Tagpad.Models
{
#pragma warning disable CS8618
    //junction table model
    public class NoteTagRecord
    {
        //Key fields for actual table schema
        public int NoteID { get; set; }
        public int TagID { get; set; }
        //Navigation properties to support Entity Framework
        public Note Note { get; set; } 
        public Tag Tag { get; set; }
    }
#pragma warning restore CS8618
}
