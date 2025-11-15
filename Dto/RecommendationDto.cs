namespace Exphadis.Core.Contract.Dto;

public class RecommendationDto
{
    public int Bimester { get; set; }

    public virtual TutorshipMessageDto TutorshipMessage { get; set; }
}
