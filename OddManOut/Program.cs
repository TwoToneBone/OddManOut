using System;
using System.Linq;

namespace OddManOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] outputs = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.ReadLine();
                int[] invitations = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                var invitationsCounted = invitations.GroupBy(a => a).Select(a => new { Number = a.Key, Count = a.Count() });
                outputs[i] = $"Case #{i + 1}: " + invitationsCounted.OrderBy(a => a.Count).First().Number.ToString();

            }
            foreach (string s in outputs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
