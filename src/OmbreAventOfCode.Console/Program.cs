// See https://aka.ms/new-console-template for more information

using Ombrelin.AdventOfCode.Core.Day1;

Console.WriteLine("Day 1");
var day1 = new Day1();
var elves = await day1.ParseElves();
Console.WriteLine(day1.GetResult(elves));