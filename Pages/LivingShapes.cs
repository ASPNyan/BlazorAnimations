using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAnimations.Pages;

public partial class LivingShapes
{
    private static readonly List<KeyValuePair<int, int>> Combinations = new()
    {
        new KeyValuePair<int, int>(1, 1),
        new KeyValuePair<int, int>(1, 2),
        new KeyValuePair<int, int>(1, 4),
        new KeyValuePair<int, int>(2, 2),
        new KeyValuePair<int, int>(2, 3),
        new KeyValuePair<int, int>(3, 3)
    };

    private async Task Animate()
    {
        while (true)
        {
            int Value = Rand(0, Combinations.Count - 1, Previous);
            KeyValuePair<int, int> Combination = Combinations[Value];
            
            Config = Combination.Key;
            Round = Combination.Value;
            
            Previous = Value;

            StateHasChanged();
            await Task.Delay(3000);
        }
    }

    private static int Rand(int Min, int Max, int Prev)
    {
        int Next = Prev;

        while (Prev == Next)
        {
            Next = new Random().Next(Min, Max);
        }

        return Next;
    }

    private static string RandRGB()
    {
        int R = new Random().Next(40, 255);
        int G = new Random().Next(40, 255);
        int B = new Random().Next(40, 255);

        return $"rgb({R}, {G}, {B})";
    }
}