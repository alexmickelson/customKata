using System;
using System.Collections.Generic;
using System.Text;

namespace customKata
{
    public static class Kata
    {
        public static string FindMissingNums(int [] incoming)
        {
            //special case for empty array
            if (incoming.Length < 1)
            {
                return "0-99";
            }
            string answer = string.Empty;

            var start = incoming[0] == 0 //first value to add on to answer
                ? 1
                : 0;
            //handle value in context of what we need to add up to the current value
            for(int i = 0; i < incoming.Length; i++)
            {
                var end = incoming[i]-1; //next value to add on answer

                var diff = end-start;
                if (diff == 1)
                {
                    answer += $"{start},";
                }
                else if (diff > 1) {
                    answer += $"{start}-{end},";

                }
                start = incoming[i]+1;
            }

            //handle last value
            if (incoming[incoming.Length - 1] != 99)
            {
                var diff = 99 - start;
                if (diff == 1)
                {
                    answer += $"{start}";
                }
                else
                {
                    answer += $"{start}-99";
                }
            }


            return answer.EndsWith(',')
                ? answer.Substring(0, answer.Length - 1)
                : answer;
        }
    }
}
