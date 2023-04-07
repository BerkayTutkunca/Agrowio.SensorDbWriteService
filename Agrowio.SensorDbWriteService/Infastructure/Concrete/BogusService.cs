using Agrowio.Common.Models.Enums;
using Agrowio.SensorDbWriteService.Entities.Concrete.HistoryConcrete;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Agrowio.SensorDbWriteService.Infastructure.Concrete
{
    public class BogusService
    { 
        string[] _sensorTypes = new string[]
        {
            "İç Sıcaklık",
            "Dış Sıcaklık",
            "İç Nem",
            "Basınç",
            "Rüzgar Hız",
            "Rüzgar Yön",
            "Debimetre",
            "Ec",
            "Ph",
            "Yağmur",
            "Solar Radyasyon",
            "Karbondioksit",
            "Depo",
            "Diğer"};

        public BogusService()
        {
           

        }
        public List<AutomationHistory> Generator(int count)
        {
            var faker = new Faker<AutomationHistory>()
                //.RuleFor(u => u.Id, f => f.Random.Guid())
                .RuleFor(u => u.Value, f => f.Random.Int(0, 45))
                .RuleFor(u => u.Timestamp, f => f.Date.Between(new DateTime(2022, 1, 1), new DateTime(2025, 1, 1)))
                .RuleFor(u => u.Name, f => f.PickRandom(_sensorTypes))
                 .RuleFor(u => u.OnOffType, f => f.PickRandom<OnOffType>());



            return faker.Generate(count); // 10 örnek oluşturmak için Generate() metodu kullanılır
        }

        public void GetterProperties()
        {
            Type type = typeof(SensorType);
            PropertyInfo[] property = type.GetProperties();
            List<string> propertyGetter = new List<string>();
            string val = string.Empty;
            if (property != null)
            {
                foreach (PropertyInfo prop in property)
                {
                    val = prop.GetValue(type, null).ToString();
                    propertyGetter.Add(val);
                }
            }
            Console.WriteLine(val);


        }

    }
}
