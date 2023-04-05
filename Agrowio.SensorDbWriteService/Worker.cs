using Agrowio.SensorDbWriteService.Entities.Concrete;
using Agrowio.SensorDbWriteService.Infastructure.Concrete;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Agrowio.SensorDbWriteService
{
    public class Worker : BackgroundService
    {


        public Worker()
        {
            
          
        }



        
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //const string uri = "mongodb://localhost:27017";
            //var client = new MongoClient(uri);
            //var collection = client.GetDatabase("Agrowio").GetCollection<BsonDocument>("Temp");
            //Temperature etemp = new Temperature() { Id=Guid.NewGuid(),InputType = "Sıcaklık", DeviceIdentity = "Birşey" ,Value = 11, };
            //Temperature temp = new Temperature() { Id = Guid.NewGuid(), Value = 555555, Timestamp = DateTime.Now, Metadata = new BaseMeta() { Ortam="22",DeviceIdentity = "123231", InputType = "yarrra" } };
            //new BaseMetmpa() { DeviceIdentity = "aaa", InputType = "nem" };
            //Temperature tmp1 = new Temperature() {Id=Guid.NewGuid(),Value=8484848,Timestamp=DateTime.Now,Metadata=new HumidityMetadata () {PoliField="aaaaa",DeviceIdentity="111",InputType="adad",Ortam="asda"} };
            
            //Humidity hum= new Humidity() {Value = 1212, Timestamp = DateTime.Now, Metadata = new HumidityMetadata() { DeviceIdentity = "7777", InputType = "Nemmmmm" , Ortam = "Dünya",PoliField="asdasda" } };
            //WindDirection wd = new WindDirection() {Metadata=new BaseMeta() {DeviceIdentity="222",InputType="aaa",Ortam="11" },Timestamp=DateTime.Now,Value=21 };
            //var dbService = new DbService<Humidity>("Humidity");
            
                //var dbService = new WindDirectionRepository();
            
            
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