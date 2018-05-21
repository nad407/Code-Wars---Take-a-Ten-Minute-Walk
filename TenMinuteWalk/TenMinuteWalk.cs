using System;

namespace Kata
{

    public class TenMinuteWalk 
    {
        public TenMinuteWalk()
        {
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length == 10)
            {
                int[] arr = new int[] { 0, 0, 0, 0 };
                for (int i = 0; i < walk.Length; i++)
                {
                    if (walk[i].CompareTo("n") == 0) { arr[0]++; }
                    if (walk[i].CompareTo("s") == 0) { arr[1]++; }
                    if (walk[i].CompareTo("e") == 0) { arr[2]++; }
                    if (walk[i].CompareTo("w") == 0) { arr[3]++; }
                }

                if ((arr[0] == arr[1]) & (arr[2] == arr[3]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
