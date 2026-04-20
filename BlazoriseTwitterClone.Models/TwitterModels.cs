using System.Collections.Generic;

namespace BlazoriseTwitterClone.Models;

public sealed record UserProfile(
    string DisplayName,
    string Handle,
    string Bio,
    string Location,
    string Website,
    string Joined,
    string Birthday,
    int Following,
    int Followers,
    int Posts,
    string AvatarUrl,
    string BannerUrl );

public sealed record Tweet(
    string Id,
    string Author,
    string Handle,
    string Time,
    string AvatarUrl,
    string Body,
    string? QuotedAuthor,
    string? QuotedHandle,
    string? QuotedBody,
    int Replies,
    int Reposts,
    int Likes,
    string Views,
    bool Verified = false,
    IReadOnlyList<PollOption>? PollOptions = null,
    string? PollFooter = null );

public sealed record PollOption(
    string Label );

public sealed record PostComment(
    string Id,
    string Author,
    string Handle,
    string Time,
    string AvatarUrl,
    string Body,
    int Replies,
    int Reposts,
    int Likes,
    string Views,
    bool Verified = false );

public sealed record Trend(
    string Category,
    string Title,
    string? Posts );

public sealed record FollowSuggestion(
    string Name,
    string Handle,
    string AvatarUrl,
    bool Verified = false );

public sealed record Conversation(
    string Name,
    string Handle,
    string AvatarUrl,
    string Preview,
    string Age,
    bool Verified = false );

public sealed record NotificationItem(
    string Type,
    string Actor,
    string AvatarUrl,
    string Time,
    string Body,
    bool Verified = false );
