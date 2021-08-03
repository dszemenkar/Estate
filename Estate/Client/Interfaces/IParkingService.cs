using Estate.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Client.Interfaces
{
    public interface IParkingService
    {
        IList<ParkingSpace> ParkingSpaces { get; set; }
        Task<ParkingSpace> GetParkingSpace(int id);
        Task AddParkingSpace(ParkingSpace parking);
        Task EditParkingSpace(ParkingSpace parking);
        Task DeleteParkingSpace(int id);
        Task GetParkingSpaces();
    }
}
