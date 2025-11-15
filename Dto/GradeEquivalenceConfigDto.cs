namespace Exphadis.Core.Contract.Dto;
public class GradeEquivalenceConfigDto
{
    public int Id { get; set; }

    public string Value { get; set; }

    public decimal LowerGrade { get; set; }

    public decimal UpperGrade { get; set; }

    public int IdLevel { get; set; }

    public int Year { get; set; }

    public string StringLowerGrade => $"{this.LowerGrade:0.00}";

    public string StringUpperGrade => $"{this.UpperGrade:0.00}";

    public static string AssignLetter(List<GradeEquivalenceConfigDto> equivalences, decimal number)
    {
        var value = string.Empty;

        number = Math.Round(number, 2);

        foreach (var equivalence in equivalences)
        {
            var lowerGrade = equivalence.LowerGrade.ConvertObjectToDecimal();
            var upperGrade = equivalence.UpperGrade.ConvertObjectToDecimal();

            if ((number < lowerGrade) || (number > upperGrade))
            {
                continue;
            }

            value = equivalence.Value;
            break;
        }

        return value;
    }

    public static decimal NoteAverage(decimal sumNotes, int count) =>
        count == 0
        ? 0
        : Math.Round(sumNotes / count, 0, MidpointRounding.AwayFromZero);
}
