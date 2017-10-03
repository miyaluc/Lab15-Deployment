﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab15_miya.Controllers
{
    public class StudentsController
    {
        [Route("Registration")]
        public string RegisterStudents(string name, int age)
        {
            return $"{name} is {age} years old.";
        }
        //view students who have registered so far
        public string ViewStudents()
        {
            //insert using file reader here
            //return data in string format
            return "If I had decided to use file reader, I would be able to display the names of students who registered. Instead, all you get to see is this dumb message.";
        }
    }
}
