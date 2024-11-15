using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DispatchTransportControl.Shared.DTO;

/// <summary>
///     DTO для создания водителя
/// </summary>
public class DriverCreateDto
{
    /// <summary>
    ///     Имя
    /// </summary>
    [JsonPropertyName("name")]
    [Required(ErrorMessage = "Имя обязательно для заполнения")]
    public required string Name { get; set; }

    /// <summary>
    ///     Фамилия
    /// </summary>
    [JsonPropertyName("surname")]
    [Required(ErrorMessage = "Фамилия обязательна для заполнения")]
    public required string Surname { get; set; }

    /// <summary>
    ///     Отчество
    /// </summary>
    [JsonPropertyName("patronymic")]
    [Required(ErrorMessage = "Отчество обязательно для заполнения")]
    public required string Patronymic { get; set; }

    /// <summary>
    ///     Паспорт
    /// </summary>
    [JsonPropertyName("passport")]
    [Required(ErrorMessage = "Паспорт обязателен для заполнения")]
    public required string Passport { get; set; }

    /// <summary>
    ///     Водительское удостоверение
    /// </summary>
    [JsonPropertyName("driver_license")]
    [Required(ErrorMessage = "Водительское удостоверение обязательно для заполнения")]
    public required string DriverLicense { get; set; }

    /// <summary>
    ///     Адрес
    /// </summary>
    [JsonPropertyName("address")]
    [Required(ErrorMessage = "Адрес обязателен для заполнения")]
    public required string Address { get; set; }

    /// <summary>
    ///     Телефон
    /// </summary>
    [JsonPropertyName("phone")]
    [Required(ErrorMessage = "Телефон обязателен для заполнения")]
    public required string Phone { get; set; }
}