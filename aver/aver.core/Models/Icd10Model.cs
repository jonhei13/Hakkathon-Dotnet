using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.core.Models
{
    public class Icd10Model
    {

       
        public string Name { get; set; }
        public string Description { get; set; }
        public string Valid { get; set; }
        public object[] Inclusions { get; set; }
        public object[] ExcludesOne { get; set; }
        public object[] ExcludesTwo { get; set; }
        public string Type { get; set; }
        public string Response { get; set; }
        

    }
}