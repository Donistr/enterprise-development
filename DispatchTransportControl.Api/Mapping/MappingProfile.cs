﻿using AutoMapper;
using DispatchTransportControl.Domain.Entity;
using DispatchTransportControl.Shared.DTO;

namespace DispatchTransportControl.Api.Mapping;

/// <summary>
///     Класс предназначен для настройки маппинга энтити в дто
/// </summary>
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Driver, DriverDto>();
        CreateMap<DriverDto, Driver>();
        CreateMap<Driver, DriverCreateDto>();
        CreateMap<DriverCreateDto, Driver>();

        CreateMap<VehicleModel, VehicleModelDto>();
        CreateMap<VehicleModelDto, VehicleModel>();
        CreateMap<VehicleModel, VehicleModelCreateDto>();
        CreateMap<VehicleModelCreateDto, VehicleModel>();

        CreateMap<Vehicle, VehicleDto>();
        CreateMap<VehicleDto, Vehicle>();

        CreateMap<RouteAssignment, RouteAssignmentDto>();
        CreateMap<RouteAssignmentDto, RouteAssignment>();
    }
}