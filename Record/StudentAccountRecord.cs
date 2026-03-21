namespace Exphadis.Core.Contract.Record
{
    public sealed record StudentAccountRecord(
        string primaryEmail,
        string givenName,
        string familyName,
        string initialPassword)
    {
        public string PrimaryEmail { get; } = primaryEmail;

        public string GivenName { get; } = givenName;

        public string FamilyName { get; } = familyName;

        public string InitialPassword { get; } = initialPassword;
    }
}