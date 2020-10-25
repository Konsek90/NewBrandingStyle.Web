using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
    public class CompanyAddedViewModel: CompanyModel
    {
       
        public int NumberOfCharsInDescription { get; set; }

        public bool IsHidden { get; set; }

        public int NumberOfCharsInName { get; set; }

        
    }
}
