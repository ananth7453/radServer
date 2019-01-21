using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadiologyTeam.Models
{
    public class Cfind
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ReportingPhysician { get; set; }
    }


    //[SUID],[SDT],[PID],[PNA],[GEN],[MOD],[SDS],[CHY],[RFP],[NOI],[RPS]
    public class StudyDetails
    {
        public string SUID { get; set; }
        public DateTime SDT { get; set; }
        public string PID { get; set; }
        public string PNA { get; set; }
        public string GEN { get; set; }
        public string MOD { get; set; }
        public string SDS { get; set; }
        public string CHY { get; set; }
        public string RFP { get; set; }
        public string NOI { get; set; }
        public string RPS { get; set; }

    }
}