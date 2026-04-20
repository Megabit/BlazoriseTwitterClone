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
        "https://api.dicebear.com/9.x/initials/svg?seed=Milo%20Arden",
        "https://images.unsplash.com/photo-1557682250-33bd709cbe85?auto=format&fit=crop&w=1200&q=80" );

    public IReadOnlyList<Tweet> HomeTimeline { get; } =
    [
        new(
            "poll-1",
            "Dev Ledger",
            "@devledger",
            "13h",
            "https://api.dicebear.com/9.x/initials/svg?seed=Dev%20Ledger",
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
            "https://api.dicebear.com/9.x/initials/svg?seed=Nova%20Reed",
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
            "https://api.dicebear.com/9.x/initials/svg?seed=Rowan%20Vale",
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
            "https://api.dicebear.com/9.x/initials/svg?seed=Finn%20Brooks",
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
            "https://api.dicebear.com/9.x/initials/svg?seed=Kai%20Mercer",
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
            "https://api.dicebear.com/9.x/initials/svg?seed=Galen%20Pike",
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
            "https://api.dicebear.com/9.x/initials/svg?seed=Milo%20Arden",
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
            "https://api.dicebear.com/9.x/initials/svg?seed=Milo%20Arden",
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
        new( "Astra UI", "@astraui", "https://api.dicebear.com/9.x/initials/svg?seed=Astra%20UI", true ),
        new( "North Studio", "@northstudio", "https://api.dicebear.com/9.x/initials/svg?seed=North%20Studio", true ),
        new( "Dane Clarke", "@daneclarke", "https://api.dicebear.com/9.x/initials/svg?seed=North%20Studio9", false )
    ];

    public IReadOnlyList<Conversation> Conversations { get; } =
    [
        new( "Sam T. River #dotnet", "@samriver", "https://api.dicebear.com/9.x/initials/svg?seed=Sam%20River", "Thanks, much appreciated. Looking ...", "33w", true ),
        new( "Ari Finch", "@arifinch", "https://api.dicebear.com/9.x/initials/svg?seed=Ari%20Finch", "The package stats are the only metric I ...", "78w", true ),
        new( "Cody Vale", "@codyvale", "https://api.dicebear.com/9.x/initials/svg?seed=Cody%20Vale", "Well, it's a little more complicated than ...", "82w", true ),
        new( "Mira Stone", "@mirastone", "https://api.dicebear.com/9.x/initials/svg?seed=Mira%20Stone", "You: Sorry for sending the message this late...", "108w", true ),
        new( "Toma North", "@tomanorth", "https://api.dicebear.com/9.x/initials/svg?seed=Sam%20River0", "You: So many times I got burned by ...", "139w" ),
        new( "Evan Hale", "@evanhale", "https://api.dicebear.com/9.x/initials/svg?seed=Sam%20River6", "You: I need to look that up", "140w" ),
        new( "Ravi Moss", "@ravimoss", "https://api.dicebear.com/9.x/initials/svg?seed=Sam%20River7", "Thanks for clarifying. Let me ask ...", "150w" ),
        new( "Luca West", "@lucawest", "https://api.dicebear.com/9.x/initials/svg?seed=Sam%20River9", "Hey Milo!...", "157w" ),
        new( "Chris Rowan", "@chrisrowan", "https://api.dicebear.com/9.x/initials/svg?seed=Chris%20Rowan", "You: Thank you!", "174w" )
    ];

    public IReadOnlyList<NotificationItem> Notifications { get; } =
    [
        new( "liked", "Nika Snow", "https://api.dicebear.com/9.x/initials/svg?seed=Nika%20Snow", "Apr 16", "Blazorise 2.1 is coming tomorrow, but we're already working on the future versions." ),
        new( "reply", "Juno Square", "https://api.dicebear.com/9.x/initials/svg?seed=Juno%20Square", "Apr 16", "It's an utterly ridiculous rule that demonstrates how lost the moderators are.", true ),
        new( "liked", "Sander Blue and 4 others", "https://api.dicebear.com/9.x/initials/svg?seed=Sander%20Blue", "Apr 15", "I don't see why there are problems with the csproj file. It's so simple.\n\nIn JS worlds, we have package.json, and somehow that is not a problem,..." ),
        new( "liked", "Mira Stone", "https://api.dicebear.com/9.x/initials/svg?seed=Mira%20Stone", "Apr 15", "Oh, you noticed...\n\nThe rule is pretty dumb to begin with. You can only post on Saturday and ..." ),
        new( "reply", "Eder Bond", "https://api.dicebear.com/9.x/initials/svg?seed=Ari%20Finch0", "Apr 15", "The platform team is trying to reinvent the wheel. Meanwhile, their UI framework needs more hands and more steady maintenance." )
    ];

    public IReadOnlyList<Tweet> GetAllTweets()
    {
        return HomeTimeline
            .Concat( ProfilePosts )
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
                "https://api.dicebear.com/9.x/initials/svg?seed=Ivy%20Lane",
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
                "https://api.dicebear.com/9.x/initials/svg?seed=Nico%20Vale",
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
                "https://api.dicebear.com/9.x/initials/svg?seed=Sage%20Porter",
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
                "https://api.dicebear.com/9.x/initials/svg?seed=Remy%20Hart",
                $"Replying to {replyTarget}\nA lot of this feels like separating product quality from personality. That is simple to say and harder to do in public.",
                0,
                0,
                6,
                "104" )
        ];
    }
}
