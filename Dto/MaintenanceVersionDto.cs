namespace Exphadis.Core.Contract.Dto;

public class MaintenanceVersionDto
{
    public string Version { get; set; }
}

public sealed class StudentEmailSyncResultDto
{
    public int Year { get; set; }

    public int TotalStudentsEvaluated { get; set; }

    public int AlreadyHadEmail { get; set; }

    public int SyncedCount { get; set; }

    public int NotFoundInGoogleCount { get; set; }

    public int FailedCount { get; set; }

    public List<StudentEmailSyncErrorDto> Errors { get; set; } = new List<StudentEmailSyncErrorDto>();
}

public sealed class StudentEmailSyncErrorDto
{
    public int StudentId { get; set; }

    public string StudentName { get; set; }

    public string Email { get; set; }

    public string Message { get; set; }
}