namespace Exphadis.Core.Contract.Dto;

public sealed class MoneyMovementIngressMonitoringFilterDto
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool? IsValidated { get; set; }

    public string Search { get; set; }

    public int Page { get; set; } = 1;

    public int PageSize { get; set; } = 25;
}

public sealed class MoneyMovementIngressMonitoringResponseDto
{
    public MoneyMovementIngressKpisDto Kpis { get; set; }

    public List<IncomeMovementRowDto> Items { get; set; } = new();

    public int TotalCount { get; set; }
}

public sealed class MoneyMovementIngressKpisDto
{
    public int TotalTransactions { get; set; }

    public decimal TotalAmount { get; set; }

    public int Validated { get; set; }

    public int NotValidated { get; set; }

    public int Generated { get; set; }

    public int NotGenerated { get; set; }
}

public sealed class IncomeMovementRowDto
{
    public int Id { get; set; }

    public bool IsValidated { get; set; }

    public string Posee { get; set; }

    public bool? SeGenero { get; set; }

    public string Codigo { get; set; }

    public string FechaPago { get; set; }

    public string OperationNumber { get; set; }

    public decimal Monto { get; set; }

    public decimal MontoA { get; set; }

    public string StudentName { get; set; }

    public string Apoderado { get; set; }

    public string Documento { get; set; }

    public string MetodoPago { get; set; }

    public string Banco { get; set; }

    public string TipoPago { get; set; }

    public string Nivel { get; set; }

    public string Grado { get; set; }

    public string Mes { get; set; }

    public int Anio { get; set; }

    public string RegistradoPor { get; set; }

    public string Comentario { get; set; }
}
