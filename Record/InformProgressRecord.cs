namespace Exphadis.Core.Contract.Record
{
    public record InformProgressRecord(
        int levelId,
        int gradeId,
        int sectionId,
        int turnId,
        int periodId,
        int year,
        MediaTypeEnum mediaType,
        DateTime timeStamp,
        string EmailTo,
        string EmailCc,
        string Subject
    );
}
