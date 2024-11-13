using DispatchTransportControl.Shared.DTO;

namespace DispatchTransportControl.Wasm.Api;

public interface IApiClientWrapper
{
    Task<ICollection<DriverDto>> GetDrivers();
    Task<DriverDto> GetDriver(int id);
    Task<DriverDto> CreateDriver(DriverCreateDto driverDto);
    Task<DriverDto> UpdateDriver(DriverDto driverDto);
    Task DeleteDriver(int id);
    Task<ICollection<DriverDto>> GetDriversByPeriod(TimePeriodDto timePeriodDto);
    Task<ICollection<DriverTripCountDto>> GetTop5DriversByTripCount();
    Task<ICollection<DriverTripStatsDto>> GetDriverTripStats(TimePeriodDto timePeriodDto);
}