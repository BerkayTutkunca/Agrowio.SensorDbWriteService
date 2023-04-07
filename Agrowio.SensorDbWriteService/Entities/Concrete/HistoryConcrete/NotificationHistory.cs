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
    public class NotificationHistory : BaseHistory
    {
        [BsonElement("inputnotification")]
        public InputNotificationStatus NotificationStatus { get; set; }
    }
}
