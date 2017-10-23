using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineRTo;
using OnlineRTo.ViewModel;
using OnlineRTO.Models;
using System.Data.Entity;
namespace OnlineRTo
{
    public class RegistrationRepositories:IRegistration
    {
        private eRTOEntities dbRTOEntities = new eRTOEntities();
        public IEnumerable<Registration> GetData()
        {
            return dbRTOEntities.Registrations;
        }
        public  Registration GetDatabyRegId(int RegId)
        {
            return dbRTOEntities.Registrations.Where(r => r.RegId == RegId).SingleOrDefault();
        }
        public IEnumerable<Registration> GetPendingRegistration()
        {
            return dbRTOEntities.Registrations.Where(r=>r.Status!="Approve");
        }
        public void NewRegistration(Registration objVehicle)
        {
           
            dbRTOEntities.Registrations.Add(objVehicle);
            dbRTOEntities.SaveChanges();
        }

        public void UpdateRegistration(int RegId, Registration obj)
        {
            try
            {
                //db.Set<YourModel>().AddOrUpdate(model);
                var existingdetails = dbRTOEntities.Registrations.FirstOrDefault(x => x.RegId == RegId);
                existingdetails.Owner = obj.Owner;
                existingdetails.Manufacturer = obj.Manufacturer;
                existingdetails.Mobile = obj.Mobile;
                existingdetails.Email = obj.Email;
                existingdetails.Engine = obj.Engine;
                existingdetails.Address = obj.Address;
                existingdetails.ChasisNo = obj.ChasisNo;
                existingdetails.color = obj.color;
                existingdetails.Vehicle = obj.Vehicle;
                dbRTOEntities.SaveChanges();
            }
            catch(Exception ex)
            {

            }
        }

        public void Approve(int RegId,Registration obj)
        {
            var existingdetails = dbRTOEntities.Registrations.FirstOrDefault(x => x.RegId == RegId);
            existingdetails.Status = obj.Status;
            dbRTOEntities.SaveChanges();
        }
    }
}