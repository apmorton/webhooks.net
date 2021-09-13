﻿namespace JamieMagee.Octokit.Webhooks.Models.CheckSuiteEvent
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public sealed record CheckSuite
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        [JsonPropertyName("head_branch")]
        public string? HeadBranch { get; set; }

        [JsonPropertyName("head_sha")]
        public string HeadSha { get; set; } = null!;

        [JsonPropertyName("status")]
        public CheckSuiteStatus? Status { get; set; }

        [JsonPropertyName("conclusion")]
        public CheckSuiteConclusion? Conclusion { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; } = null!;

        [JsonPropertyName("before")]
        public string? Before { get; set; }

        [JsonPropertyName("after")]
        public string After { get; set; } = null!;

        [JsonPropertyName("pull_requests")]
        public IEnumerable<CheckRunPullRequest> PullRequests { get; set; } = null!;

        [JsonPropertyName("app")]
        public App App { get; set; } = null!;

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = null!;

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = null!;

        [JsonPropertyName("latest_check_runs_count")]
        public int LatestCheckRunsCount { get; set; }

        [JsonPropertyName("check_runs_url")]
        public string CheckRunsUrl { get; set; } = null!;

        [JsonPropertyName("head_commit")]
        public SimpleCommit HeadCommit { get; set; } = null!;
    }
}