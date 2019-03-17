using System;
using System.Linq;
using System.Collections.Generic;

namespace killNickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> goodSongs = new List<Dictionary<string, string>>();

            HashSet<Dictionary<string, string>> allSongs = new HashSet<Dictionary<string, string>>();

            allSongs.Add(new Dictionary<string, string>() {{"Fugazi", "Waiting Room"}} );
            allSongs.Add(new Dictionary<string, string>() {{"pumpkins", "zero"}} );
            allSongs.Add(new Dictionary<string, string>() {{"Nickelback", "gay song"}} );
            allSongs.Add(new Dictionary<string, string>() {{"Nickelback", "terrible music"}} );
            allSongs.Add(new Dictionary<string, string>() {{"Converge", "Jane Doe"}} );
            allSongs.Add(new Dictionary<string, string>() {{"Russian Circles", "Harper Lewis"}} );
            allSongs.Add(new Dictionary<string, string>() {{"Julian Lage", "Ramble"}} );

            foreach (Dictionary<string, string> songs in allSongs) {
                foreach(KeyValuePair<string, string> song in songs){
                    if(song.Key != "Nickelback"){
                        goodSongs.Add(songs);
                    }
                }
            }

                Console.WriteLine("SOME RAD TUNES");
                Console.WriteLine("-------------------");
            foreach(Dictionary<string, string> goodSong in goodSongs) {
                foreach(KeyValuePair<string, string> song in goodSong) {
                    Console.WriteLine($"{song.Value} by {song.Key}");
                }
            }
        }
    }
}
