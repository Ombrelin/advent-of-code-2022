namespace Ombrelin.AdventOfCode.Core.Day1;

public record Elf(IEnumerable<int> CaloriesSets)
{
    public int CaloriesCount => CaloriesSets.Sum();
}