var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.csharp_net_aspire_waiting_screen_ApiService>("apiservice");

builder.AddProject<Projects.csharp_net_aspire_waiting_screen_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
