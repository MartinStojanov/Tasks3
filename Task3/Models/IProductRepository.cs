﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
    }
}
