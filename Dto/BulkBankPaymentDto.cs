// <copyright file="BulkBankPaymentDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class BulkBankPaymentDto
{
    public string[] FileInformation { get; set; }

    public string FileName { get; set; }

    public DateTime ChargedTime { get; set; }

    public string UsernameIp { get; set; }

    public string UsernameHostname { get; set; }

    public string Browser { get; set; }
}
