﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noerlund.Ui.Models
{
    public class CreateProductModel
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
    }
}