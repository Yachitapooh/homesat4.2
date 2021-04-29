using System;

namespace homesat_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char rep = 'Y';
            while (rep == 'Y')
            {
                string DNA = Console.ReadLine();
                bool nuc = true;
                nuc = IsValidSequence(DNA);
                if (nuc == true)
                {
                    Console.WriteLine("Current half DNA sequence : " + DNA);
                    char YN1 = 'Y';
                    YN1 = checkYN(YN1);
                    while (YN1 != 'Y' && YN1 != 'N')
                    {
                        while (YN1 != 'Y' && YN1 != 'N')
                        {
                            Console.WriteLine("Please input Y or N.");
                            YN1 = checkYN(YN1);
                        }
                        if (YN1 == 'Y')
                        {
                            string nuc2;
                            nuc2 = ReplicateSequence(DNA);
                            Console.WriteLine("Replicated half DNA sequence : " + nuc2);
                            YN1 = 'Y';
                            YN1 = checkYN(YN1);
                        }
                        if (YN1 == 'N')
                        {
                            YN1 = 'N';
                        }
                    }
                    if (YN1 == 'Y')
                    {
                        string nuc2;
                        nuc2 = ReplicateSequence(DNA);
                        Console.WriteLine("Replicated half DNA sequence : " + nuc2);
                    }
                }
                if (nuc == false)
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                char repl = 'Y';
                repl = Con(repl);

                while (repl != 'Y' && repl != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                    repl = Con(repl);
                }
                if (repl == 'N')
                {
                    rep = 'N';
                }
            }
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSequence(string halfDNASequence)
        {
            string result = " ";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static char checkYN(char YN1)
        {
            Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
            char YN = char.Parse(Console.ReadLine());
            return YN;
        }
        static char Con(char repl)
        {
            Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
            char repl2 = char.Parse(Console.ReadLine());
            return repl2;
        }        
    }
}
