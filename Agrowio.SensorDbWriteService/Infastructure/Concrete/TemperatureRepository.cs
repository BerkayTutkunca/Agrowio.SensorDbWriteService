using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class TemperatureRepository : DbService<Temperature> , ITemperatureRepository
    {
        public TemperatureRepository():base("Temperature")
        {
            
        }

    }
}
