using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;

namespace YoutubeExplode.Search;

/// <summary>
/// Metadata associated with a YouTube music returned by a search query.
/// </summary>
public class MusicSearchResult : ISearchResult
{
    /// <inheritdoc />
    public VideoId Id { get; }

    /// <inheritdoc cref="IVideo.Url" />
    public string Url => $"https://www.youtube.com/watch?v={Id}";

    /// <inheritdoc cref="IVideo.Title" />
    public string Title { get; }

    /// <inheritdoc />
    public TimeSpan? Duration { get; }

    /// <inheritdoc />
    public IReadOnlyList<Thumbnail> Thumbnails { get; }

    /// <summary>
    /// Initializes an instance of <see cref="MusicSearchResult" />.
    /// </summary>
    public MusicSearchResult(
        VideoId id,
        string title,
        //TimeSpan? duration,
        IReadOnlyList<Thumbnail> thumbnails
    )
    {
        Id = id;
        Title = title;
        //Duration = duration;
        Thumbnails = thumbnails;
    }

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public override string ToString() => $"Music ({Title})";
}
