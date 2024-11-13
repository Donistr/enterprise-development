using DispatchTransportControl.Shared.DTO;

namespace DispatchTransportControl.Wasm.Api;

public class ApiClientWrapper(IConfiguration configuration) : IApiClientWrapper
{
    private readonly Client _apiClient = new(configuration["OpenApi:ServerUrl"], new HttpClient());

    public async Task<ICollection<DriverDto>> GetDrivers()
    {
        return await _apiClient.DriverAllAsync();
    }

    public async Task<DriverDto> GetDriver(int id)
    {
        return await _apiClient.DriverGETAsync(id);
    }

    public async Task<DriverDto> CreateDriver(DriverCreateDto driverDto)
    {
        return await _apiClient.DriverPOSTAsync(driverDto);
    }

    public async Task<DriverDto> UpdateDriver(DriverDto driverDto)
    {
        return await _apiClient.DriverPUTAsync(driverDto);
    }

    public async Task DeleteDriver(int id)
    {
        await _apiClient.DriverDELETEAsync(id);
    }

    public async Task<ICollection<DriverDto>> GetDriversByPeriod(TimePeriodDto timePeriodDto)
    {
        return await _apiClient.GetAllByPeriodAsync(timePeriodDto);
    }

    public async Task<ICollection<DriverTripCountDto>> GetTop5DriversByTripCount()
    {
        return await _apiClient.GetTop5DriversByTripCountAsync();
    }

    public async Task<ICollection<DriverTripStatsDto>> GetDriverTripStats(TimePeriodDto timePeriodDto)
    {
        return await _apiClient.GetDriversTripStatsAsync();
    }
}