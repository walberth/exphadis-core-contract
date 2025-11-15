namespace Exphadis.Core.Contract.Dto;

using Enums;

public class CustomerDto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Number { get; set; }

    public string Email { get; set; }

    public string Document { get; set; }

    public int Year { get; set; }

    public CustomerStageDto LastStage => this.Stages.LastOrDefault();

    public IEnumerable<CustomerStageDto> Stages { get; set; } = new HashSet<CustomerStageDto>();
}

public class CustomerStageDto
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int WorkerId { get; set; }

    public string WorkerName { get; set; }

    public InformStageEnum Stage { get; set; }

    public string Comment { get; set; }

    public int? NumberKids { get; set; }

    public DateTime? DateEnrollment { get; set; }

    public decimal? AmountPayment { get; set; }

    public string StageName => this.Stage.GetEnumMemberValue();

    public DateTime DateRegister { get; set; } = Date.CurrentTimeStamp();
}
