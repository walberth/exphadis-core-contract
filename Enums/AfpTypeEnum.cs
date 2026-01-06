namespace Exphadis.Core.Contract.Enums;

/// <summary>
/// Tipos de AFP con sus tasas de contribución.
/// </summary>
public enum AfpTypeEnum
{
    /// <summary>
    /// Sin AFP (para ONP o Recibo por Honorarios).
    /// </summary>
    [EnumMember(Value = "")]
    None = 0,

    /// <summary>
    /// AFP Profuturo - Tasa: 12.53%.
    /// </summary>
    [EnumMember(Value = "PROFUTURO")]
    Profuturo = 1,

    /// <summary>
    /// AFP Habitat - Tasa: 12.22%.
    /// </summary>
    [EnumMember(Value = "HABITAT")]
    Habitat = 2,

    /// <summary>
    /// AFP Prima - Tasa: 12.71%.
    /// </summary>
    [EnumMember(Value = "PRIMA")]
    Prima = 3,

    /// <summary>
    /// AFP Integra - Tasa: 12.66%.
    /// </summary>
    [EnumMember(Value = "INTEGRA")]
    Integra = 4,
}
