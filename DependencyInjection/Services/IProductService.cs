﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    internal interface IProductService
    {
        public void GetProductList();

        public void GetProductById(int id);
    }
}
