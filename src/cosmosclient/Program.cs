using Azure.Identity;
using Azure.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Azure.Cosmos;

var configuration = new ConfigurationBuilder()
    .AddEnvironmentVariables()
    .AddUserSecrets<Program>()
    .Build();

TokenCredential credential = new DefaultAzureCredential();

using CosmosClient client = new(configuration["COSMOS_ENDPOINT"], credential);

Database database = await client.CreateDatabaseIfNotExistsAsync(id: "CosmosSuites");

// <create_container>
// New instance of Container class referencing the server-side container
Container container = database.GetContainer("MaintenanceRequests");
// </create_container>

// <create_object> 
// Create new item and add to container
MaintenanceRequest item1 = new() {
    Id="1",
    HotelId=1,
    Hotel="Oceanview Inn",
    Source="customer",
    Date=DateTime.Parse("2024-08-10"),
    Details="The air conditioning (A/C) unit in room 227 is malfunctioning and making a loud noise. Customer will be out of the room between 5:00 and 8:30 PM this evening. This needs immediate maintenance attention. If the issue cannot be resolved, we will need to move the customer to a new room.",
    RoomNumber=227
};

await container.CreateItemAsync<MaintenanceRequest>(item: item1, partitionKey: new PartitionKey(1));
