using System.Net;
using System.Net.Http.Json;

namespace Ombrelin.AdventOfCode.Core.Day1;

public class Day1
{
    public int GetResult(IEnumerable<Elf> elves) =>
        (elves.MaxBy(elf => elf.CaloriesCount) ?? throw new ArgumentException())
        .CaloriesCount;

    public async Task<IEnumerable<Elf>> ParseElves()
    {
        string[] lines = await File.ReadAllLinesAsync("day1.txt");
        IList<Elf> elves = new List<Elf>();

        ISet<string> currentBatch = new HashSet<string>();
        foreach (string line in lines)
        {
            if (line == string.Empty)
            {
                elves.Add(new Elf(currentBatch.Select(int.Parse)));
                currentBatch = new HashSet<string>();
            }
            else
            {
                currentBatch.Add(line);
            }
        }

        return elves;
    }
}