namespace JamieMagee.Octokit.Webhooks.Events.Star
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    public sealed record StarCreatedEvent : StarEvent
    {
        [JsonPropertyName("action")]
        public override string Action => StarAction.Created;
    }
}