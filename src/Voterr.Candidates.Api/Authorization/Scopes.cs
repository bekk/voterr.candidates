namespace Voterr.Candidates.Api.Authorization
{
    public static class Scopes
    {
        public const string CandidatesRead = "candidates.read";

        public static string GetFullScope(string scope) => $"api://voterr.candidates.api/{scope}";
    }
}