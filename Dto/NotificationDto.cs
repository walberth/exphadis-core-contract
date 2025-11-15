namespace Exphadis.Core.Contract.Dto;

public class NotificationDto : AuditDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    public bool IsReaded { get; set; }

    public int PersonPublisherId { get; set; }

    public PersonDto PersonPublisher { get; set; }

    public int PersonReaderId { get; set; }

    public NotificationPriorityEnum Priority { get; set; }

    public string PriorityName { get; set; }

    public List<int> RoleIds { get; set; }

    public string Roles { get; set; }

    public int LevelId { get; set; }

    public int? MediaId { get; set; }

    public List<int> GradeIds { get; set; }

    public DateTime DateToPublish { get; set; }

    public DateTime DateReaded { get; set; }

    public NotificationMessageTypeEnum MessageType { get; set; }

    public string MessageTypeName { get; set; }
}
