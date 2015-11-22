using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class WorkerrController : ApiController
    {

        Workers[] workers = new Workers[] 
        { 
            new Workers { idworker = 1, name = "Tom", surname = "Smith"}, 
            new Workers { idworker = 2, name = "Jack", surname = "Lee"}, 
            new Workers { idworker = 3, name = "Alex", surname = "Jackson"} 
        };



        public IEnumerable<Workers> GetAllWorkers()
        {
            return workers;
        }

        public IHttpActionResult GetWorker(int id)
        {
            var worker = workers.FirstOrDefault((p) => p.idworker == id);
            if (worker == null)
            {
                return NotFound();
            }
            return Ok(worker);
        }

    }

     



}
