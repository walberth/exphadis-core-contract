// <copyright file="BankPaymentDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class BankPaymentDto
{
    public int Id { get; set; }

    public int IdBank { get; set; }

    public string UrlImage { get; set; }

    public string OperationNumber { get; set; }

    public DateTime? OperationDate { get; set; }

    public int IdStudentPayment { get; set; }

    public int IdBankValidation { get; set; }

    public string InformationBankValidation { get; set; }

    public string UserRegister { get; set; }

    public string UserUpdated { get; set; }

    public DateTime? TimeRegister { get; set; }

    public DateTime? TimeUpdated { get; set; }

    public BankTypeDto BankType { get; set; }
}
