using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uQlustCore.Profiles
{
    public static class ProfileStat
    {
        public static Dictionary<string, protInfo> RearangeStates(Dictionary<string, protInfo> dic,double percent)
        {
            Dictionary<string, protInfo> res = new Dictionary<string, protInfo>();
            int[] freq = new int[byte.MaxValue];
            byte[] table = new byte[dic.Keys.Count];
            List<string> keys = new List<string>(dic.Keys);
            int[,,] interval = new int[dic[keys[0]].profile.Count,(int)Math.Floor(1.0 / percent)+1, 2];

            for (int j = 0; j < dic[keys[0]].profile.Count; j++)
            {
                for (int i = 0; i < freq.Length; i++)
                    freq[i] = 0;

                for (int i = 0; i < keys.Count; i++)
                {
                    table[i] = dic[keys[i]].profile[j];
                    freq[table[i]]++;
                }
                double sum = 0;
                int remIndex = 0;
                int intervCount = 0;
                for (int i = 0; i < freq.Length; i++)
                {
                    sum += freq[i];
                    //if (sum/keys.Count>percent)
                    if (i==0)
                    {
                        sum = 0;
                        interval[j, intervCount, 0] = remIndex;
                        interval[j, intervCount, 1] = i+1;
                        intervCount++;
                        remIndex = i+1;
                    }
                }
                if(sum!=0)
                {
                    interval[j, intervCount, 0] = remIndex;
                    interval[j, intervCount, 1] = int.MaxValue;
                    intervCount++;
                }
                interval[j, intervCount - 1, 1] = int.MaxValue;
            }
            for(int j=0;j<keys.Count;j++)
            { 
                protInfo xx = dic[keys[j]];
                List<byte> newProfile = new List<byte>();
                for (int i = 0; i < xx.profile.Count; i++)
                    for (byte k = 0; k < interval.Length; k++)
                        if (xx.profile[i] >= interval[i,k, 0] && xx.profile[i] < interval[i,k, 1])
                        {
                            newProfile.Add(k);
                            break;
                        }
                xx.profile = newProfile;
                res.Add(keys[j],xx);
            }


            return res;
        }
    }
}
