// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

using System.Globalization;

/// <summary>
/// Conversiones tolerantes entre la hora de ingreso del contrato (TimeSpan? en el dominio)
/// y su representacion "HH:mm" en el DTO. Se usan dentro de los perfiles de AutoMapper.
/// </summary>
public static class ContractMappingExtensions
{
    /// <summary>
    /// Valores permitidos para WeekDays, en el mismo formato (minusculas, sin tildes)
    /// que envia el front.
    /// </summary>
    public static readonly string[] AllowedWeekDays =
    {
        "domingo", "lunes", "martes", "miercoles", "jueves", "viernes", "sabado",
    };

    private static readonly Dictionary<string, DayOfWeek> WeekDayByName = new(StringComparer.OrdinalIgnoreCase)
    {
        ["domingo"] = DayOfWeek.Sunday,
        ["lunes"] = DayOfWeek.Monday,
        ["martes"] = DayOfWeek.Tuesday,
        ["miercoles"] = DayOfWeek.Wednesday,
        ["jueves"] = DayOfWeek.Thursday,
        ["viernes"] = DayOfWeek.Friday,
        ["sabado"] = DayOfWeek.Saturday,
    };

    public static string ToAdmissionTimeString(this TimeSpan? value) =>
        value.HasValue
            ? value.Value.ToString(@"hh\:mm", CultureInfo.InvariantCulture)
            : null;

    public static TimeSpan? ToAdmissionTimeSpan(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return TimeSpan.TryParse(value.Trim(), CultureInfo.InvariantCulture, out var parsed)
            ? parsed
            : null;
    }

    /// <summary>
    /// Convierte la lista de nombres de dias del DTO al string separado por comas
    /// que se persiste en la entidad (mismo criterio que la columna `positions`).
    /// </summary>
    public static string ToWeekDaysString(this IEnumerable<string> weekDays) =>
        weekDays == null
            ? null
            : string.Join(",", weekDays.Select(day => day?.Trim().ToLowerInvariant()));

    /// <summary>
    /// Convierte el string separado por comas persistido en la entidad a la lista de
    /// nombres de dias que expone el DTO.
    /// </summary>
    public static List<string> ToWeekDaysList(this string weekDays) =>
        string.IsNullOrWhiteSpace(weekDays)
            ? new List<string>()
            : weekDays
                .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Select(day => day.ToLowerInvariant())
                .ToList();

    /// <summary>
    /// Resuelve el <see cref="DayOfWeek"/> correspondiente a un nombre de dia en español
    /// (p.ej. "lunes"). Lanza si el nombre no es reconocido.
    /// </summary>
    public static DayOfWeek ToDayOfWeek(this string weekDay) =>
        WeekDayByName.TryGetValue(weekDay?.Trim() ?? string.Empty, out var day)
            ? day
            : throw new ArgumentOutOfRangeException(nameof(weekDay), weekDay, "Día de la semana no reconocido.");
}
