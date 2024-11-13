﻿using System.Text.Json.Serialization;

namespace DispatchTransportControl.Shared.DTO;

/// <summary>
///     DTO для создания транспортного средства
/// </summary>
public class VehicleCreateDto
{
    /// <summary>
    ///     Гос. номер транспортного средства
    /// </summary>
    [JsonPropertyName("registration_number")]
    public required string RegistrationNumber { get; set; }

    /// <summary>
    ///     Тип транспортного средства
    /// </summary>
    [JsonPropertyName("vehicle_type")]
    public required VehicleType VehicleType { get; set; }

    /// <summary>
    ///     Уникальный идентификатор модели транспортного средства
    /// </summary>
    [JsonPropertyName("vehicle_model_id")]
    public required int VehicleModelId { get; set; }

    /// <summary>
    ///     Год выпуска транспортного средства
    /// </summary>
    [JsonPropertyName("year_of_manufacture")]
    public required int YearOfManufacture { get; set; }
}