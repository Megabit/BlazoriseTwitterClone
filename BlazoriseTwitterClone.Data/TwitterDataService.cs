using System;
using System.Collections.Generic;
using System.Linq;
using BlazoriseTwitterClone.Models;

namespace BlazoriseTwitterClone.Data;

public sealed class TwitterDataService
{
    public UserProfile CurrentUser { get; } = new(
        "Milo Arden",
        "@miloarden",
        "Building the future of Blazor UI -> blazorise.com",
        "Split",
        "blazorise.com",
        "Joined December 2014",
        "Born December 31, 1983",
        177,
        571,
        2082,
        Avatar( 1 ),
        OfficeImage( 1 ) );

    public IReadOnlyList<Tweet> HomeTimeline { get; } =
    [
        new(
            "poll-1",
            "Dev Ledger",
            "@devledger",
            "13h",
            Avatar( 2 ),
            "Planning on picking up a new programming language?\n\nBased on my development needs, I'm primarily anchored in one language. I know enough about other languages to navigate and get by, but certainly not an expert.\n\nWhat language are you learning next? Comment if not included!",
            null,
            null,
            null,
            1,
            0,
            3,
            "643",
            true,
            [
                new( "C#" ),
                new( "Rust" ),
                new( "C++" ),
                new( "Golang" )
            ],
            "15 votes - 6 days left" ),
        new(
            "1",
            "Nova Reed",
            "@novareed",
            "4h",
            Avatar( 3 ),
            "I feel disappointed to find out that the creator of such a good software has such harsh public opinions. It always seems like the programming industry is caught between brilliant tools and very loud arguments.",
            "Rowan Vale",
            "@rowanvale",
            "As a dad of five kids, having gone through pregnancy with my beloved wife, talking to our children while they were in the womb, singing to them, feeling their first kicks, watching their births, seeing them open their eyes for the first time...",
            3,
            1,
            12,
            "1.9K" ),
        new(
            "2",
            "Rowan Vale",
            "@rowanvale",
            "2h",
            Avatar( 4 ),
            "What's harsh in my post?",
            null,
            null,
            null,
            4,
            0,
            54,
            "1.4K",
            true ),
        new(
            "3",
            "Finn Brooks",
            "@finnbuilds",
            "19h",
            Avatar( 5 ),
            "Amazing how many seemingly simple tools are mini distributed systems running on a single machine.",
            null,
            null,
            null,
            6,
            5,
            52,
            "8.9K",
            true ),
        new(
            "4",
            "Kai Mercer",
            "@kaimercer",
            "Apr 18",
            Avatar( 6 ),
            "software is only getting worse, more bugs, bad uptime\n\nwhich is weird because ai is really good at coding at this point\n\nthe productivity gains are erased by the speed of creation; we move faster but not better",
            null,
            null,
            null,
            106,
            29,
            577,
            "21K",
            true ),
        new(
            "5",
            "Galen Pike",
            "@galenpike",
            "Apr 17",
            Avatar( 7 ),
            "I still use ChatGPT.\n\nCouldn't find a better model for brainstorming yet.",
            null,
            null,
            null,
            27,
            8,
            144,
            "9K",
            true )
    ];

    public IReadOnlyList<Tweet> ProfilePosts { get; } =
    [
        new(
            "p1",
            "Milo Arden",
            "@miloarden",
            "Apr 16",
            Avatar( 1 ),
            "What is your opinion on line endings in C# and Razor files? Especially for generated files. Personally I hate the inconsistency, but I want to know what other people think...",
            null,
            null,
            null,
            0,
            2,
            0,
            "81" ),
        new(
            "p2",
            "Milo Arden",
            "@miloarden",
            "Apr 15",
            Avatar( 1 ),
            "Blazorise 2.1 is now available.\n\nOne of the largest releases so far, introducing Material 3, AntDesign provider, DataGrid hierarchical data support, and a new Maps extension.\n\nMany components are improved, including accessibility and responsive behavior.",
            null,
            null,
            null,
            2,
            9,
            26,
            "1.8K" )
    ];

    public IReadOnlyList<Trend> Trends { get; } =
    [
        new( "Trending in Croatia", "Google Books", null ),
        new( "Trending in Croatia", "ORBITAL NOTES", null ),
        new( "Trending in Croatia", "#vac", null ),
        new( "Trending in Croatia", "#nudebeach", null )
    ];

    public IReadOnlyList<FollowSuggestion> Suggestions { get; } =
    [
        new( "Astra UI", "@astraui", Avatar( 2 ), true ),
        new( "North Studio", "@northstudio", Avatar( 5 ), true ),
        new( "Dane Clarke", "@daneclarke", Avatar( 7 ), false )
    ];

    public IReadOnlyList<Conversation> Conversations { get; } =
    [
        new( "Sam T. River #dotnet", "@samriver", Avatar( 3 ), "Thanks, much appreciated. Looking ...", "33w", true ),
        new( "Ari Finch", "@arifinch", Avatar( 4 ), "The package stats are the only metric I ...", "78w", true ),
        new( "Cody Vale", "@codyvale", Avatar( 5 ), "Well, it's a little more complicated than ...", "82w", true ),
        new( "Mira Stone", "@mirastone", Avatar( 6 ), "You: Sorry for sending the message this late...", "108w", true ),
        new( "Toma North", "@tomanorth", Avatar( 7 ), "You: So many times I got burned by ...", "139w" ),
        new( "Evan Hale", "@evanhale", Avatar( 1 ), "You: I need to look that up", "140w" ),
        new( "Ravi Moss", "@ravimoss", Avatar( 2 ), "Thanks for clarifying. Let me ask ...", "150w" ),
        new( "Luca West", "@lucawest", Avatar( 3 ), "Hey Milo!...", "157w" ),
        new( "Chris Rowan", "@chrisrowan", Avatar( 4 ), "You: Thank you!", "174w" )
    ];

    public IReadOnlyList<NotificationItem> Notifications { get; } =
    [
        new( "liked", "Nika Snow", Avatar( 5 ), "Apr 16", "Blazorise 2.1 is coming tomorrow, but we're already working on the future versions." ),
        new( "reply", "Juno Square", Avatar( 6 ), "Apr 16", "It's an utterly ridiculous rule that demonstrates how lost the moderators are.", true ),
        new( "liked", "Sander Blue and 4 others", Avatar( 7 ), "Apr 15", "I don't see why there are problems with the csproj file. It's so simple.\n\nIn JS worlds, we have package.json, and somehow that is not a problem,..." ),
        new( "liked", "Mira Stone", Avatar( 6 ), "Apr 15", "Oh, you noticed...\n\nThe rule is pretty dumb to begin with. You can only post on Saturday and ..." ),
        new( "reply", "Eder Bond", Avatar( 4 ), "Apr 15", "The platform team is trying to reinvent the wheel. Meanwhile, their UI framework needs more hands and more steady maintenance." )
    ];

    public IReadOnlyList<Tweet> GetAllTweets()
    {
        var timelineTweets = HomeTimeline
            .Concat( ProfilePosts )
            .GroupBy( tweet => tweet.Id )
            .Select( group => group.First() )
            .ToList();

        return timelineTweets
            .Concat( GetGeneratedProfileTweetsForKnownUsers( timelineTweets ) )
            .GroupBy( tweet => tweet.Id )
            .Select( group => group.First() )
            .ToList();
    }

    public Tweet? GetTweetById( string id )
    {
        return GetAllTweets().FirstOrDefault( tweet => tweet.Id == id );
    }

    public IReadOnlyList<PostComment> GetCommentsFor( string id )
    {
        var tweet = GetTweetById( id );
        var replyTarget = tweet?.Handle ?? "@post";

        return
        [
            new(
                $"{id}-comment-1",
                "Ivy Lane",
                "@ivylane",
                "18m",
                Avatar( 2 ),
                $"Replying to {replyTarget}\nThis is the kind of thread that makes the tradeoffs visible. The tool can be useful and the social noise around it can still be exhausting.",
                1,
                2,
                14,
                "248",
                true ),
            new(
                $"{id}-comment-2",
                "Nico Vale",
                "@nicovale",
                "32m",
                Avatar( 3 ),
                $"Replying to {replyTarget}\nI keep coming back to incentives. The best tools get adopted quickly, but the conversations around them often move faster than the facts.",
                0,
                1,
                9,
                "190" ),
            new(
                $"{id}-comment-3",
                "Sage Porter",
                "@sageporter",
                "1h",
                Avatar( 4 ),
                $"Replying to {replyTarget}\nThe practical answer is usually boring: use the useful parts, ignore the noise, and document the boundaries for the team.",
                2,
                4,
                31,
                "612",
                true ),
            new(
                $"{id}-comment-4",
                "Remy Hart",
                "@remyhart",
                "2h",
                Avatar( 5 ),
                $"Replying to {replyTarget}\nA lot of this feels like separating product quality from personality. That is simple to say and harder to do in public.",
                0,
                0,
                6,
                "104" )
        ];
    }

    public UserProfile GetProfileByHandle( string? handle )
    {
        var normalizedHandle = NormalizeHandle( handle );

        if ( normalizedHandle == NormalizeHandle( CurrentUser.Handle ) )
        {
            return CurrentUser;
        }

        var tweet = HomeTimeline
            .Concat( ProfilePosts )
            .FirstOrDefault( item => NormalizeHandle( item.Handle ) == normalizedHandle );

        if ( tweet is not null )
        {
            return CreateProfile( tweet.Author, tweet.Handle, tweet.AvatarUrl, tweet.Verified );
        }

        var suggestion = Suggestions.FirstOrDefault( item => NormalizeHandle( item.Handle ) == normalizedHandle );

        if ( suggestion is not null )
        {
            return CreateProfile( suggestion.Name, suggestion.Handle, suggestion.AvatarUrl, suggestion.Verified );
        }

        var commentAuthor = GetCommentAuthors().FirstOrDefault( item => NormalizeHandle( item.Handle ) == normalizedHandle );

        if ( commentAuthor is not null )
        {
            return CreateProfile( commentAuthor.Author, commentAuthor.Handle, commentAuthor.AvatarUrl, commentAuthor.Verified );
        }

        var generatedHandle = string.IsNullOrWhiteSpace( normalizedHandle ) ? "@guest" : $"@{normalizedHandle}";

        return CreateProfile( ToDisplayName( generatedHandle ), generatedHandle, AvatarFor( generatedHandle ), false );
    }

    public IReadOnlyList<Tweet> GetProfilePosts( string? handle )
    {
        var profile = GetProfileByHandle( handle );
        var normalizedHandle = NormalizeHandle( profile.Handle );

        if ( normalizedHandle == NormalizeHandle( CurrentUser.Handle ) )
        {
            return ProfilePosts;
        }

        var existingTweets = HomeTimeline
            .Concat( ProfilePosts )
            .Where( tweet => NormalizeHandle( tweet.Handle ) == normalizedHandle )
            .ToList();

        if ( existingTweets.Count > 0 )
        {
            return existingTweets;
        }

        return CreateGeneratedProfileTweets( profile );
    }

    public string GetProfileUrl( string handle )
    {
        return $"/profile/{NormalizeHandle( handle )}";
    }

    public bool IsCurrentUser( UserProfile profile )
    {
        return NormalizeHandle( profile.Handle ) == NormalizeHandle( CurrentUser.Handle );
    }

    private IReadOnlyList<Tweet> GetGeneratedProfileTweetsForKnownUsers( IReadOnlyList<Tweet> existingTweets )
    {
        var existingHandles = existingTweets
            .Select( tweet => NormalizeHandle( tweet.Handle ) )
            .ToHashSet();

        var commentProfiles = GetCommentAuthors()
            .Select( author => CreateProfile( author.Author, author.Handle, author.AvatarUrl, author.Verified ) );

        var suggestionProfiles = Suggestions
            .Select( suggestion => CreateProfile( suggestion.Name, suggestion.Handle, suggestion.AvatarUrl, suggestion.Verified ) );

        return commentProfiles
            .Concat( suggestionProfiles )
            .Where( profile => !existingHandles.Contains( NormalizeHandle( profile.Handle ) ) )
            .GroupBy( profile => NormalizeHandle( profile.Handle ) )
            .Select( group => group.First() )
            .SelectMany( CreateGeneratedProfileTweets )
            .ToList();
    }

    private static IReadOnlyList<PostComment> GetCommentAuthors()
    {
        return
        [
            new( "comment-author-1", "Ivy Lane", "@ivylane", "", Avatar( 2 ), "", 0, 0, 0, "", true ),
            new( "comment-author-2", "Nico Vale", "@nicovale", "", Avatar( 3 ), "", 0, 0, 0, "" ),
            new( "comment-author-3", "Sage Porter", "@sageporter", "", Avatar( 4 ), "", 0, 0, 0, "", true ),
            new( "comment-author-4", "Remy Hart", "@remyhart", "", Avatar( 5 ), "", 0, 0, 0, "" )
        ];
    }

    private static IReadOnlyList<Tweet> CreateGeneratedProfileTweets( UserProfile profile )
    {
        var slug = NormalizeHandle( profile.Handle );

        return
        [
            new(
                $"profile-{slug}-1",
                profile.DisplayName,
                profile.Handle,
                "Apr 18",
                profile.AvatarUrl,
                "I keep a small list of things that made the work easier this week. Most of them are boring, but boring is usually what survives.",
                null,
                null,
                null,
                4,
                3,
                28,
                "734",
                true ),
            new(
                $"profile-{slug}-2",
                profile.DisplayName,
                profile.Handle,
                "Apr 14",
                profile.AvatarUrl,
                "A clean interface is mostly restraint: fewer surprises, sharper defaults, and enough space for people to understand what just happened.",
                null,
                null,
                null,
                2,
                5,
                41,
                "1.2K" )
        ];
    }

    private static UserProfile CreateProfile( string displayName, string handle, string avatarUrl, bool verified )
    {
        var slug = NormalizeHandle( handle );
        var seed = slug.Length == 0 ? "profile" : slug;
        var followers = 240 + ( seed.Length * 37 );
        var following = 80 + ( seed.Length * 11 );
        var posts = 120 + ( seed.Length * 19 );

        return new(
            displayName,
            handle,
            verified ? "Designing small systems that stay understandable." : "Writing notes about software, tools, and the little decisions between them.",
            "Somewhere online",
            $"{seed}.example",
            "Joined March 2021",
            "Born July 8",
            following,
            followers,
            posts,
            avatarUrl,
            OfficeImageFor( seed ) );
    }

    private static string NormalizeHandle( string? handle )
    {
        return ( handle ?? string.Empty ).Trim().TrimStart( '@' ).ToLowerInvariant();
    }

    private static string ToDisplayName( string handle )
    {
        var normalized = NormalizeHandle( handle );

        if ( string.IsNullOrWhiteSpace( normalized ) )
        {
            return "Guest Profile";
        }

        return string.Join( ' ', normalized.Split( ['.', '-', '_'], System.StringSplitOptions.RemoveEmptyEntries )
            .Select( part => char.ToUpperInvariant( part[0] ) + part[1..] ) );
    }

    private static string AvatarFor( string handle )
    {
        var index = ( NormalizeHandle( handle ).Length % 7 ) + 1;

        return Avatar( index );
    }

    private static string Avatar( int index )
    {
        return $"/_content/BlazoriseTwitterClone.UI/img/avatars/square/avatar{index:00}.jpg";
    }

    private static string OfficeImageFor( string seed )
    {
        var index = ( seed.Length % 7 ) + 1;

        return OfficeImage( index );
    }

    private static string OfficeImage( int index )
    {
        return $"/_content/BlazoriseTwitterClone.UI/img/office/office{index:00}.jpg";
    }
}
