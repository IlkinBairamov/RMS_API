﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Core.Entities
{
    class Category : BaseEntity 
    {
        public string Name { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
