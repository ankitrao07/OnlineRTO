using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using OnlineRTO.Models;
using eRTO;
using eRTO.ViewModel;

namespace OnlineRTO.Controllers
{
    public class RegistrationAPIController : ApiController
    {
        private CompanyEntities db = new CompanyEntities();
        static readonly IRegistration repository = new RegistrationRepositories();
        
        public IEnumerable<Registration> GetRegistrations()
        {
            
            return repository.GetData();
        }

        // GET: api/RegistrationAPI/5
        [ResponseType(typeof(Registration))]
        public IHttpActionResult GetEmployeeInfo(int id)
        {
           
            Registration regInfo = repository.GetDatabyRegId(id);
            if (regInfo == null)
            {
                return NotFound();
            }

            return Ok(regInfo);

        }

        // PUT: api/RegistrationAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRegisrationInfo(int id, vehicleRegistration registrationInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           
            repository.UpdateRegistration(id,registrationInfo.ToRegistration());
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/RegistrationAPI
        [ResponseType(typeof(Registration))]
        public IHttpActionResult PostEmployeeInfo(Registration obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            obj.TempRegistrationNo = Utility.GenerateTempRegNo();
            repository.NewRegistration(obj);
            return CreatedAtRoute("DefaultApi", new { id = obj.RegId }, obj);
        }
  
    }
}