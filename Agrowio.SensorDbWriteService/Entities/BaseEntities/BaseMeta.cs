using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.BaseEntities
{
    [Serializable]
    public class BaseMeta
    {
        public string DeviceIdentity { get; set; }

        public Guid InputId { get; set; }

        //public string InputType { get; set; }
        //public string Ortam { get; set; }
    }
}
