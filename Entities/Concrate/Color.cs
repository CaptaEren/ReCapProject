﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Color:IEntity
    {
        public int ColorId { get; set; }
        public string? ColorName { get; set; }
    }
}
