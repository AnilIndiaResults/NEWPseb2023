// Create a
// model class (replace property types with actual types)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Web.Mvc;

namespace PSEBONLINE.Models
{
    public class ExamResultViewModel
    {
        public string Dist { get; set; }
        public string DISTNM { get; set; }
        public string SCHL { get; set; }
        public string Schlnme { get; set; }
        public string ContactInfo { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public int TotalCandidates { get; set; }
        public int FromRoll { get; set; }
        public int ToRoll { get; set; }
    }
}