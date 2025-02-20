using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Test_01
{
    Dictionary<int, string> items = null;


    public void Main()
    {
        string text = "apple banana apple grape banana apple";
        var wordCount = new Dictionary<string, int>();

        foreach (var word in text.Split(' '))
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        foreach (var kv in wordCount)
        {
            Console.WriteLine($"{kv.Key}: {kv.Value}");
        }

        foreach (var key in wordCount.Keys)
        {
            Console.WriteLine($"Key: {key}");
        }
    }
}
