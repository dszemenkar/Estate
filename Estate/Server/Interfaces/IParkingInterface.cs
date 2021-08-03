using Estate.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Estate.Server.Interfaces
{
    public interface IParkingInterface
    {
        Task<IList<ParkingSpace>> GetParkingSpaces();
        Task<ServiceResponse<int>> AddParkingSpace(ParkingSpace parking);
        Task<ServiceResponse<int>> EditParkingSpace(ParkingSpace parking);
        Task<ServiceResponse<int>> DeleteParkingSpace(int id);
        Task<ParkingSpace> GetParkingSpace(int id);
    }
}
