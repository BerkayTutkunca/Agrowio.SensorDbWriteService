﻿using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public  class WindSpeedRepository:DbService<WindSpeed>,IWindSpeedRepository
    {
        public WindSpeedRepository() :base("WindSpeed")
        {
        
        }
    }
}
