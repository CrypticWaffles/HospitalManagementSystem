using Microsoft.AspNetCore.SignalR;

namespace HospitalManagerServer
{
    public class PatientDataSimulator : BackgroundService
    {
        private readonly IHubContext<DashboardHub> hub;

        public PatientDataSimulator(IHubContext<DashboardHub> hub)
        {
            this.hub = hub;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Random rand = new Random();

            while (!stoppingToken.IsCancellationRequested)
            {
                await hub.Clients.All.SendAsync("UpdateHeartRate", rand.Next(60, 120));
                await hub.Clients.All.SendAsync("UpdateBloodPressure", $"{rand.Next(110, 140)}/{rand.Next(70, 90)}");
                await hub.Clients.All.SendAsync("UpdateSpO2", rand.Next(92, 100));
                await hub.Clients.All.SendAsync("UpdateBedStatus", rand.Next(0, 20), 20);
                await hub.Clients.All.SendAsync("UpdateEmergencies", rand.Next(0, 5));
                await hub.Clients.All.SendAsync("UpdateTemperature", rand.Next(30, 40));

                await Task.Delay(2000, stoppingToken); // Every 2 seconds
            }
        }
    }
}
