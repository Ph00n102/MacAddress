using System.ComponentModel.DataAnnotations;

namespace MacAddress.Models
{
    public class MacAddresses
    {
        [Key]
        public int MacAddId { get; set; }
        public string? MacAdd { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? WorkingGroup { get; set; }
        public string? Agency { get; set; }
        public string? DeviceProgram { get; set; }
        public string? ProgramInAgency { get; set; }
        public bool HosXp { get; set; }
        public bool KPHIS { get; set; }
        public bool Lab { get; set; }
        public bool Parcel { get; set; }
        public bool InternalProgram { get; set; }
        public bool PACS { get; set; }
        public bool Authen { get; set; }
        public bool Finance { get; set; }
        public bool SoftwareDev { get; set; }
        public bool Google { get; set; }
        public bool MicrosoftOffice { get; set; }
        public bool Facebook { get; set; }
        public bool Youtube { get; set; }
        public DateTime CreateDate { get; set;} = DateTime.Now; 
    }
}