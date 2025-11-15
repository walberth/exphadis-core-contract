// Copyright (c) {year} Exphadis. All rights reserved.

namespace Exphadis.Core.Contract.Enums;

public enum MediaTypeEnum
{
    [EnumMember(Value = "")]
    Default = 0,

    [EnumMember(Value = "gif")]
    Gif = 1,

    [EnumMember(Value = "jpeg")]
    Jpeg = 2,

    [EnumMember(Value = "png")]
    Png = 3,

    [EnumMember(Value = "svg")]
    Svg = 4,

    [EnumMember(Value = "pdf")]
    Pdf = 5,

    [EnumMember(Value = "txt")]
    Txt = 6,

    [EnumMember(Value = "mpeg")]
    Mpeg = 7,

    [EnumMember(Value = "wav")]
    Wav = 9,

    [EnumMember(Value = "webm")]
    Webm = 10,

    [EnumMember(Value = "xlsx")]
    Excel = 11,

    [EnumMember(Value = "pptx")]
    PowerPoint = 12,

    [EnumMember(Value = "xml")]
    Xml = 13,

    [EnumMember(Value = "sql")]
    Sql = 14,
}
