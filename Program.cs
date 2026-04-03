using System;
// Pastikan baris di bawah ini sesuai dengan nama project kamu
using TP_MODUL6_103022400024;

namespace TP_MODUL6_103022400024
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Pengujian Kondisi Normal
            Console.WriteLine("=== PENGUJIAN 1: KONDISI NORMAL ===");
            try
            {
                // Membuat objek lagu baru
                SayaMusicTrack lagu1 = new SayaMusicTrack("Bernapas Tanpamu - Last Child");
                lagu1.IncreasePlayCount(1000000);
                lagu1.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error pada Pengujian 1: {ex.Message}");
            }

            // 2. Pengujian Kondisi Overflow (Sesuai Instruksi E.3)
            Console.WriteLine("\n=== PENGUJIAN 2: OVERFLOW TEST (FOR LOOP) ===");
            try
            {
                SayaMusicTrack lagu2 = new SayaMusicTrack("Lagu Viral");

                // Melakukan loop 220 kali x 10.000.000 = 2.2 Miliar (Melebihi batas int)
                for (int i = 0; i < 220; i++)
                {
                    lagu2.IncreasePlayCount(10000000);
                }
                lagu2.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error pada Pengujian 2: {ex.Message}");
            }

            Console.WriteLine("\nTekan Enter untuk menutup program...");
            Console.ReadLine();
        }
    }
}