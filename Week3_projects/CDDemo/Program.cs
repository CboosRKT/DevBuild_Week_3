// Compact Disk

CompactDisc theWall = new CompactDisc("Pink Floyd", "Rock", 80);
Console.WriteLine(theWall);

theWall.Songs.Add("In the Flesh?");
theWall.Songs.Add("The Thin Ice");
theWall.Songs.Add("Another Brick in the Wall, Part 1");
theWall.Songs.Add("The Happiest Days of Our Lives");
theWall.Songs.Add("Another Brick in the Wall, Part 2");

foreach (string song in theWall.Songs)
{
    Console.WriteLine(song);
}
Console.WriteLine($"This album has {theWall.Songcount()}");




// Practicing


//
    

class CompactDisc
{
    public string Artist;
    public string Genre;
    public int Duration;
    public List<string> Songs;

    public CompactDisc(string _Artist, string _Genre, int _Duration)
    {
        Artist = _Artist;
        Genre = _Genre;
        Duration = _Duration;
        Songs = new List<string>();
    }

    public int Songcount(){
        return Songs.Count();
    }

    public override string ToString()
    {
        return $"Artist: {Artist}   Genre: {Genre}   Duration: {Duration}   minutes";
    }

}