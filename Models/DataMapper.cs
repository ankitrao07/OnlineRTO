using eRTO.ViewModel;
using OnlineRTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace OnlineRTO.Models
{

    public static class DataMapper
    {
        public static Registration ToRegistration(this vehicleRegistration objVehicle)
        {
            return new Registration{
                Owner = objVehicle.Owner,
                Vehicle = objVehicle.VehicleName,
                Manufacturer = objVehicle.Manufacture,
                ChasisNo = objVehicle.ChasisNo,
                Engine = objVehicle.Engine,
                color = objVehicle.Color,
                Email = objVehicle.Email,
                Mobile = objVehicle.Mobile,
                Address = objVehicle.Address,
                RTOId = objVehicle.RTOId,
                TempRegistrationNo = objVehicle.TempRegistration,
            };

        }
     
    }
}