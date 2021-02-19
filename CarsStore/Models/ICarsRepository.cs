﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsStore.Models
{
    interface ICarsRepository
    {
        IQueryable<Car> Cars { get; }
    }
}
