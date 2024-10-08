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
        public DateTime CreateDate { get; set;} = DateTime.Now; 
    }
}