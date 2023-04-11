using Agrowio.SensorDbWriteService;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;

BsonDefaults.GuidRepresentationMode = GuidRepresentationMode.V3;
BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));


IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
