using System;
using System.Diagnostics;

namespace TP_MODUL6_103022400024
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        // Konstruktor dengan Precondition (DbC)
        public SayaMusicTrack(string title)
        {
            // --- IMPLEMENTASI DESIGN BY CONTRACT  ---
            // Syarat: Judul tidak boleh null dan panjang maksimal 100 karakter
            Debug.Assert(title != null, "Precondition Gagal: Judul tidak boleh null.");
            Debug.Assert(title.Length <= 100, "Precondition Gagal: Judul maksimal 100 karakter.");

            this.title = title;
            Random random = new Random();

            // Generate random 5 digit (Bagian C.3)
            this.id = random.Next(10000, 99999);
            this.playCount = 0;
        }

        // Method IncreasePlayCount dengan DbC dan Exception Handling
        public void IncreasePlayCount(int count)
        {
            // --- IMPLEMENTASI DESIGN BY CONTRACT
            // Syarat: Input penambahan tidak boleh lebih dari 10.000.000
            Debug.Assert(count <= 10000000, "Precondition Gagal: Input penambahan maksimal 10.000.000.");

            // --- IMPLEMENTASI DEFENSIVE PROGRAMMING (Bagian E.2.a) ---
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                // Menangkap error jika playCount melebihi 2.147.483.647 (batas int)
                Console.WriteLine("LOG ERROR: Terdeteksi Overflow! Play count melebihi kapasitas tipe data integer.");
            }
        }

        // Method untuk menampilkan detail track
        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID Lagu    : {id}");
            Console.WriteLine($"Judul      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
            Console.WriteLine("------------------------------------------");
        }
    }
}