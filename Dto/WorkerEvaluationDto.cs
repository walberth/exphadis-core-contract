namespace Exphadis.Core.Contract.Dto;

using Base;

public class WorkerEvaluationDto : AuditDto
{
    public int Id { get; set; }

    public int IdWorker { get; set; }

    public int IdWorkerEvaluator { get; set; }

    public string CompleteName { get; set; }

    public DateTime DateLastEvaluation { get; set; }

    public string LastEvaluator { get; set; }

    public string LastEvaluationState { get; set; }

    public int IdState { get; set; }

    public int IdPosition { get; set; }

    public string Position { get; set; }

    public DateTime EvaluationDate { get; set; }

    public string Evaluator { get; set; }

    public string State { get; set; }

    public string Comment { get; set; }

    public int Year { get; set; }

    public int IdCurrentRol { get; set; }

    public int LastEvaluationStateId { get; set; }

    public IEnumerable<WorkerEvaluationResponseDto> EvaluationResponses { get; set; } = new HashSet<WorkerEvaluationResponseDto>();
}

public class WorkerEvaluationResponseDto : AuditDto
{
    public int Id { get; set; }

    public int IdWorkerQuestion { get; set; }

    public int IdWorkerEvaluation { get; set; }

    public string Response { get; set; }

    public string QuestionVariable { get; set; }
}

public class EvaluationQuestionDto
{
    public int Id { get; set; }

    public string QuestionVariable { get; set; }

    public string Question { get; set; }

    public int Order { get; set; }

    public bool Required { get; set; }
}
