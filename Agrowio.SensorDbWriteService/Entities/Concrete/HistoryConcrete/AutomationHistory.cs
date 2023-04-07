using Agrowio.Common.Models.Enums;
using Agrowio.SensorDbWriteService.Entities.Abstract;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Entities.Concrete.HistoryConcrete
{
    [Serializable]
    public class AutomationHistory : BaseHistory
    {
        [BsonElement("onofftype")]
        public OnOffType OnOffType { get; set; }

    }
}
