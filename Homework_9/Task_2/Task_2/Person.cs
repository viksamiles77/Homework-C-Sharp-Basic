namespace Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; }

        public List<string> FavouriteSongs { get; set; }


        public void GetFavSongs(List<string> favouriteSongs)
        {
            Console.WriteLine($"{Id} || {FirstName} || {LastName} || {Age}");
            Console.WriteLine($"Favourite songs: ");
            foreach (string song in favouriteSongs)
            {
                Console.WriteLine(song);
            }
            
        }
    }
}
