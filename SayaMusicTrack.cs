using System;

namespace TP_MODUL6_103022400024
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        // C.3: Konstruktor menerima judul lagu
        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999); // Generate 5 digit random
            this.playCount = 0;
        }

        // C.4: Method IncreasePlayCount
        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        // C.5: Method PrintTrackDetails
        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID Lagu    : {id}");
            Console.WriteLine($"Judul      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
            Console.WriteLine("------------------------------------------");
        }
    }
}