using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
namespace uQlustCore.Profiles
{
    class FragBagRNA:FragBagProfile
    {
        public FragBagRNA()
        {
            dirSettings.Load();

            destination = new List<INPUTMODE>();
            destination.Add(INPUTMODE.RNA);
            profileName = "FragBagRNA";
            contactProfile = "FragBagRNA profile ";
            AddInternalProfiles();
            maxV = 1;

        }
        public override void CheckIfAvailable()
        {
            if (!Directory.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
                    Path.DirectorySeparatorChar + "fragLib"))
                if (!Directory.Exists("C:\\Projects\\UQlast\\fragLib"))
                    throw new Exception("Directory fragLib not exists. Profile FragBag cannot be used!");

            ReadLibrary("fragBagRNAv2.txt");
        }
        public override void AddInternalProfiles()
        {
            profileNode node = new profileNode();

            node.profName = "FragBagRNA";
            node.internalName = "FragBagRNA";
            for (int i = 1; i <= 10; i++)
                node.AddStateItem(i.ToString(), i.ToString());

            InternalProfilesManager.AddNodeToList(node, typeof(FragBagRNA).FullName);

        }
        public override Dictionary<string, protInfo> GetProfile(profileNode node, string listFile, DCDFile dcd = null)
        {
            Dictionary<string, protInfo> res = ReadProfile(node, listFile, dcd);
            // int[] index = new int[29] { 21, 64, 29, 2, 33, 57, 77, 84, 14, 44, 81, 0, 90, 74, 30, 71, 76, 8, 48, 61,86,41,3,7,15,20,23,25,51};//for rna
            /*List<string> keys = new List<string>(res.Keys);

            foreach(var item in keys)
            {
                List<byte> newProfile = new List<byte>();
                for (int i = 0; i < index.Length; i++)
                    newProfile.Add(res[item].profile[index[i]]);
                protInfo xx = res[item];
                xx.profile = newProfile;
                res[item] = xx;
            }*/
            //res = RearangeColumnOrder(res);
            // res = RearangeColumnOrder(res, "C:\\Projects\\listIndex");
            res = ProfileStat.RearangeStates(res, 0.51);
            return res;
        }

    }
}
