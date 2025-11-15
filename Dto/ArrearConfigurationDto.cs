// <copyright file="ArrearConfigurationDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class ArrearConfigurationDto
{
    public int Month { get; set; }

    public int Year { get; set; }

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public PeriodicityTypeEnum PeriodicityType { get; set; }

    public MoneyMovementTypeEnum MoneyMovementType { get; set; }
}
