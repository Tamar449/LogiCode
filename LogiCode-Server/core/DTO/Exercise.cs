﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instruction { get; set; }
        public int Points { get; set; }
    }
}
