namespace Albums;

public class Album
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string ReleaseDate { get; set; }
    public int Tracks { get; set; }
    public bool ExplicitLyrics { get; set; }

    /// <summary>
    /// Creates an instance of the Album class.
    /// </summary>
    /// <param name="title"></param>
    /// <param name="artist"></param>
    /// <param name="releaseDate"></param>
    /// <param name="tracks"></param>
    /// <param name="explicitLyrics"></param>
    public Album(string title, string artist, string releaseDate, int tracks, bool explicitLyrics)
    {
        Title = title;
        Artist = artist;
        ReleaseDate = releaseDate;
        Tracks = tracks;
        ExplicitLyrics = explicitLyrics;
    }
}