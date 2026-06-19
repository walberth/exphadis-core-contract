// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Mapper;

using System.Globalization;

/// <summary>
/// Conversiones tolerantes entre la hora de ingreso del contrato (TimeSpan? en el dominio)
/// y su representacion "HH:mm" en el DTO. Se usan dentro de los perfiles de AutoMapper.
/// </summary>
public static class ContractMappingExtensions
{
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
}
