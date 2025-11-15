namespace Exphadis.Core.Contract.Dto;

using Enums;

public class ConfigurationVariableDto
{
    public ConfigurationVariableTypeEnum ConfigurationVariableType { get; set; }

    public dynamic Value { get; set; }
}
