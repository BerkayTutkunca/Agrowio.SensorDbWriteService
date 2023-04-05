using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.Concrete
{
    [Serializable]
    public class BaseMeta
    {
        public string DeviceIdentity { get; set; }

        public string InputType { get; set; }
        public string Ortam { get; set; }
    }
}
