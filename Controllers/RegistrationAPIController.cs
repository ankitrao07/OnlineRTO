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
using OnlineRTo;
using OnlineRTo.ViewModel;

namespace OnlineRTO.Controllers
{
    public class RegistrationAPIController : ApiController
    {
        
        static readonly IRegistration repository = new RegistrationRepositories();
        
        public IEnumerable<Registration> GetRegistrations()
        {
            
            return repository.GetData();
        }

        // GET: api/RegistrationAPI/5
        [ResponseType(typeof(Registration))]
        public IHttpActionResult GetRegistrationInfo(int id)
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
        public IHttpActionResult PostRegistrationInfo(Registration obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            obj.TempRegistrationNo = Utility.GenerateTempRegNo();
            repository.NewRegistration(obj);
            return CreatedAtRoute("DefaultApi", new { id = obj.RegId }, obj);
        }

        [HttpGet]
        [Route("api/RegistrationAPI/GetPendings")]
        public IEnumerable<Registration> GetPendingRegistration()
        {
            return repository.GetPendingRegistration();
        }
        [HttpPut]
        [Route("api/RegistrationAPI/Approve/{id}")]
        public IHttpActionResult Approve(int id,Registration obj)
        {
            obj.RegistrationNo = Utility.GenerateRegNo();
            repository.Approve(id, obj);
            return Ok();
        }
  
    }
}