using lab15_miya.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab15_miya.ViewModel
{
    public class SchoolActivityViewModel
    {
        public List<Register> activities;
        public SelectList types;
        public string activityType
        {
            get; set;
        }
    }
}
