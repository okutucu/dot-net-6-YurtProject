namespace Project.Core.Models
{
    public class Record : BaseEntity
    {
        public string RoomName { get; set; }
        public string FullName { get; set; }
        public string IdentityNo { get; set; }
        public string Phone { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime Depart { get; set; }
    }
}
