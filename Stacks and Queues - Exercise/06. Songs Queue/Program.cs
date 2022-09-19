using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/*
 Write a program that keeps track of a song's queue. The first song that is put in the queue, should be the first that gets played. A song cannot be added if it is currently in the queue.
You will be given a sequence of songs, separated by a comma and a single space. After that, you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.
The possible commands are:
•	"Play" - plays a song (removes it from the queue)
•	"Add {song}" - adds the song to the queue if it isn’t contained already, otherwise print "{song} is already contained!"
•	"Show" - prints all songs in the queue separated by a comma and a white space (start from the first song in the queue to the last)
Input
•	On the first line, you will be given a sequence of strings, separated by a comma and a white space
•	On the next lines, you will be given commands until there are no songs in the queue
Output
•	While receiving the commands, print the proper messages described above
•	After the command "Show", print the songs from the first to the last
Constraints
•	The input will always be valid and in the formats described above
•	There might be commands even after there are no songs in the queue (ignore them)
•	There will never be duplicate songs in the initial queue
Examples
Input	                 Output

All Over Again, Watch Me
Play
Add Watch Me
Add Love Me Harder
Add Promises
Show
Play
Play
Play
Play
                         Watch Me is already contained!
                         Watch Me, Love Me Harder, Promises
                         No more songs!
 */
namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songQueue = new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
            string pattern = @"Add (?<song>[A-Za-z 1-9]+)";
            Regex regexSong = new Regex(pattern);

            while (songQueue.Count > 0)
            {
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "Play":
                        songQueue.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songQueue));
                        break;
                    default:
                        Match match = regexSong.Match(cmd);
                        if (match.Success)
                        {
                            string song = match.Groups["song"].Value;
                            if (!songQueue.Contains(song))
                            {
                                songQueue.Enqueue(song);
                                continue;
                            }

                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
