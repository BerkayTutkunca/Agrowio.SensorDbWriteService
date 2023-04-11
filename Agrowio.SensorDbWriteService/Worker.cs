using Agrowio.Common.Models.Enums;
using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Entities.Concrete.HistoryConcrete;
using Agrowio.SensorDbWriteService.Infastructure.Concrete;
using Bogus.DataSets;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Diagnostics;

using Bogus;

namespace Agrowio.SensorDbWriteService
{
    public class Worker : BackgroundService
    {


        public Worker()
        {
            
          
        }



        
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            const string uri = "mongodb://localhost:27017";
            var client = new MongoClient(uri);
            var database = client.GetDatabase("Agrowio");

            var options = new CreateCollectionOptions { TimeSeriesOptions = new TimeSeriesOptions("timestamp", "metadata", TimeSeriesGranularity.Minutes) };
            //database.CreateCollection("OutTemperature", options);

           // var collection = client.GetDatabase("Agrowio").GetCollection<OutTemperature>("Temperature");







            //Önemli üst taraf



            //Temperature etemp = new Temperature() { Id=Guid.NewGuid(),InputType = "Sıcaklık", DeviceIdentity = "Birşey" ,Value = 11, };
            //new BaseMetmpa() { DeviceIdentity = "aaa", InputType = "nem" };
            //Temperature tmp1 = new Temperature() {Id=Guid.NewGuid(),Value=8484848,Timestamp=DateTime.Now,Metadata=new HumidityMetadata () {PoliField="aaaaa",DeviceIdentity="111",InputType="adad",Ortam="asda"} };

            //Humidity hum= new Humidity() {Value = 1212, Timestamp = DateTime.Now, Metadata = new HumidityMetadata() { DeviceIdentity = "7777", InputType = "Nemmmmm" , Ortam = "Dünya",PoliField="asdasda" } };
            //WindDirection wd = new WindDirection() {Metadata=new BaseMeta() {DeviceIdentity="222",InputType="aaa",Ortam="11" },Timestamp=DateTime.Now,Value=21 };


            //var dbService = new WindDirectionRepository();


            var dbService = new AutomationHistoryRepository();

            var bogus = new BogusService();
            var q =bogus.Generator(10);
            var b = bogus.OutTemperatureGenerator(10);

            foreach ( var item in b)
            {
                item.Metadata.DeviceIdentity = "111111111";

            }
            var c = bogus.BaseMetaGenerator(10);
            //await collection.InsertManyAsync(b);

            //await dbService.AddManyAsync(b);
            Console.WriteLine("Başladı");

            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();


            //var ajk = await dbService.GetAllAsync(p => p.InputId == Guid.Parse("5c162b61-dc33-ae1d-d4ae-a92a373f86f5") && p.Timestamp > DateTime.Now );
            
            stopwatch.Stop();

            
                Console.WriteLine("---" + stopwatch.ElapsedMilliseconds.ToString());

           // var faker = new Faker<BaseSensor>()
           //.RuleFor(u => u.Metadata.DeviceIdentity, f => f.Random.);


            //var bbbbbB = faker.Generate(1); // 10 örnek oluşturmak için Generate() metodu kullanılır


            //var result =await dbService.GetAllAsync(p => true);
            //for (int i = 0; i < 25; i++)
            //{
            //    await Console.Out.WriteLineAsync(result[i].Id.ToString());

            //}


            //var kkk = ajk.First();




            //var qqq = ax.Id.GetType();
            //var vv = 22;
            //await Console.Out.WriteLineAsync(qqq.Name);

            // var a = await dbService.GetAllAsync(p=>p.Name=="Ec");
            //var b =await dbService.GetAllAsync(p => p.Id == ("642ec8fe7101dc50ebb6bff3"));
            //var a = await dbService.GetAllAsync(p => p.Id == ObjectId.Parse("642ec8fe7101dc50ebb6c33c"));

            //const string uri = "mongodb://localhost:27017";
            //var _client = new MongoClient(uri);
            //var _db = _client.GetDatabase("Agrowio");
            //var _collection = _db.GetCollection<DenemeClass>("Deneme");





            //var deneme=new DenemeClass() { Id=Guid.NewGuid(),value=1};


            //_collection.InsertOne(deneme);







            while (!stoppingToken.IsCancellationRequested)
            {

                

                //for (int i = 0; i < 4; i++)
                //{
                //    await dbService.AddSignleAsync(wd);

                //}
                //await Task.Delay(1000, stoppingToken);

                //await dbService.DeleteSingleAsync(p => p.Metadata.DeviceIdentity=="7777");

                //await dbService.DeleteManyAsync(p => p.Metadata.DeviceIdentity=="7777");
            }
        }
    }
}