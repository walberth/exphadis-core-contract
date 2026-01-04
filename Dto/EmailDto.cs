namespace Exphadis.Core.Contract.Dto;

using System.ComponentModel.DataAnnotations;

using Enums;

using Microsoft.AspNetCore.Http;

public class EmailDto
{
    [Required(ErrorMessage = "Es necesario indicar quien recibirá el correo")]
    public string To { get; set; }

    public string Cc { get; set; }

    [Required(ErrorMessage = "Es necesario indicar el asunto")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Es necesario indicar el template que se va a enviar")]
    public EmailTemplateEnum EmailTemplate { get; set; }

    public string UserRegister { get; set; }

    public DateTime TimeRegister { get; set; }

    [Required(ErrorMessage = "Es necesario indicar los parametros")]
    public IEnumerable<string> Parameters { get; set; } = new HashSet<string>();

    public IEnumerable<AttachmentDto> Attachments { get; set; } = new HashSet<AttachmentDto>();
}

public class AttachmentDto
{
    public string Name { get; set; }

    public MediaTypeEnum MediaTypeEnum { get; set; }

    public IFormFile File { get; set; }

    public string FileAsString { get; set; }

    public string Extension { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }
}

public class EmailLinkDto
{
    public string Description { get; set; }

    public string Link { get; set; }
}
