using RadiologyTeam.Data;
using RadiologyTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RadiologyTeam.Controllers
{
    public class TeleController : ApiController
    {
        

        // GET api/<controller>
        public IEnumerable<string> ManageCFind(Cfind _cfind)
        {
            dbClass dbcc = new dbClass();
            return dbcc.getCFind(_cfind);
        }

        public IEnumerable<string> ManageSeriesCFind()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> RetrieveRQ()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> ReportStoreRQ()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> LoginRQ()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> CHStoreRQ()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> RetrieveReportRQ()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> TemplateListAll()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> TemplateLoad()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> CAC()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> Attachment()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> Popup()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> TemplateList()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }
        
    }
}