﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
}
