using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace jsonAPI.Models
{
    public class Jsondata
    {
        public int ID { get; set; }
        public string PAYLOAD { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public DateTime MODIFIEDDATE {get;set;}
        public string CREATEDBY { get; set; }
        public string MODIFIEDBY { get; set; }

    }
}