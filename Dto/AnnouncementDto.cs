// <copyright file="AnnouncementDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Exphadis.Core.Contract.Dto;

public class AnnouncementDto : AuditDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Body { get; set; }

    public DateTime DateToPublish { get; set; }

    public int MediaId { get; set; }

    public IEnumerable<int> RoleIds { get; set; }

    public string Roles { get; set; }

    public int FilesNumber { get; set; }

    public int LevelId { get; set; }

    public IEnumerable<int> GradeIds { get; set; }
}
