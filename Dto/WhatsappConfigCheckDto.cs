namespace Exphadis.Core.Contract.Dto;

public class WhatsappConfigCheckDto
{
    public bool Success { get; set; }

    public bool HasHttpContext { get; set; }

    public string BaseUrl { get; set; } = string.Empty;

    public string PhoneNumberId { get; set; } = string.Empty;

    public string TokenFingerprint { get; set; } = string.Empty;

    public string GraphId { get; set; } = string.Empty;

    public string DisplayPhoneNumber { get; set; } = string.Empty;

    public string VerifiedName { get; set; } = string.Empty;

    public string CodeVerificationStatus { get; set; } = string.Empty;

    public string NameStatus { get; set; } = string.Empty;

    public string QualityRating { get; set; } = string.Empty;

    public int? HttpStatus { get; set; }

    public string ErrorCode { get; set; } = string.Empty;

    public string ErrorType { get; set; } = string.Empty;

    public string ErrorMessage { get; set; } = string.Empty;

    public string ErrorDetails { get; set; } = string.Empty;

    public string Endpoint { get; set; } = string.Empty;

    public string CorrelationId { get; set; } = string.Empty;
}