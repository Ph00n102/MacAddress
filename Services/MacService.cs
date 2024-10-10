using MacAddress.Data;
using MacAddress.Models;
using MacAddress.Services;

namespace BlazorCrud.Services
{
    public class MacService : IMacService
    {
        private readonly ApplicationDbContext _ctx;
        public MacService(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public bool AddUpdate(MacAddresses macAddresses)
        {
            try
            {
                if (macAddresses.MacAddId == 0)
                    _ctx.macaddresses.Add(macAddresses);
                else
                    _ctx.macaddresses.Update(macAddresses);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var macAddresses = FindById(id);
                if (macAddresses == null)
                    return false;
                _ctx.macaddresses.Remove(macAddresses);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public MacAddresses FindById(int id)
        {
            return _ctx.macaddresses.Find(id);
        }

        public List<MacAddresses> GetAll()
        {
            return _ctx.macaddresses.ToList();
        }
    }
}