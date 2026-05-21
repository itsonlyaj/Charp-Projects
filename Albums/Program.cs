namespace Albums;

class Program
{
    static void Main(string[] args)
    {
        int numOfAlbums;

        string title;
        string artist;
        string releaseDate;
        int tracks;
        bool explicitLyrics;
        string explicitInput;

        // Asks the user how many albums they would like to enter.
        Console.Write("Enter the amount of albums you would like to enter: ");
        numOfAlbums = Convert.ToInt32(Console.ReadLine());

        // Creates an array based on the number of albums.
        Album[] albums = new Album[numOfAlbums];

        // Loops through based on how many albums the user wanted to put in.
        for (int i = 0; i < albums.Length; i++)
        {
            Console.Write("Enter album title: ");
            title = Console.ReadLine();

            Console.Write("Enter the name of the artist: ");
            artist = Console.ReadLine();

            Console.Write("Enter the release date of the album: ");
            releaseDate = Console.ReadLine();

            Console.Write("How many tracks are on this album: ");
            tracks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Does this album have explicit lyrics: ");
            explicitInput = Console.ReadLine();
            if (explicitInput == "Yes")
            {
                explicitLyrics = true;
            }
            else
            {
                explicitLyrics = false;
            }

            // After the user had entered all of the required information, the program will create a new object based on the index
            // of the array.
            albums[i] = new Album(title, artist, releaseDate, tracks, explicitLyrics);

            Console.Write("\n");
        }

        // Displays the albums that the user had entered.
        foreach (var albumList in albums)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Title: {albumList.Title}");
            Console.WriteLine($"Artist: {albumList.Artist}");
            Console.WriteLine($"Release Date: {albumList.ReleaseDate}");
            Console.WriteLine($"Tracks: {albumList.Tracks}");
            Console.WriteLine($"Explicit Lyrics: {albumList.ExplicitLyrics}");
            Console.WriteLine("================================");
            Console.Write("\n");
        }
    }
}
