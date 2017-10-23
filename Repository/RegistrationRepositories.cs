using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRTO;
using eRTO.ViewModel;
using OnlineRTO.Models;
using System.Data.Entity;
namespace eRTO
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
        public void NewRegistration(Registration objVehicle)
        {
            //Registration obj = new Registration();
            //obj.Owner = objVehicle.Owner;
            //obj.Vehicle = objVehicle.VehicleName;
            //obj.Manufacturer = objVehicle.Manufacture;
            //obj.ChasisNo = objVehicle.ChasisNo;
            //obj.Engine = objVehicle.Engine;
            //obj.color = objVehicle.Color;
            //obj.Email = objVehicle.Email;
            //obj.Mobile = objVehicle.Mobile;
            //obj.Address = objVehicle.Address;
            //obj.RTOId = objVehicle.RTOId;
            //obj.TempRegistrationNo = objVehicle.TempRegistration;
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
                //var attached = dbRTOEntities.Entry(existingdetails);
                //attached.CurrentValues.SetValues(obj);
                //dbRTOEntities.Entry(obj).State = EntityState.Modified;
                //dbRTOEntities.Registrations.Add(existingdetails);
                dbRTOEntities.SaveChanges();
            }
            catch(Exception ex)
            {

            }
        }
    }
}