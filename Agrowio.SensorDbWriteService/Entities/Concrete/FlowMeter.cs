using Agrowio.SensorDbWriteService.Entities.Abstract;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.Concrete
{
    [Serializable]
    public class FlowMeter:BaseSensor
    {
    }
}
