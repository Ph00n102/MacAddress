using MacAddress.Models;

namespace MacAddress.Services
{
    public interface IMacService
    {
        bool AddUpdate(MacAddresses macAddresses);
        bool Delete(int id);
        MacAddresses FindById(int id);
        List<MacAddresses> GetAll(); 
    }
}