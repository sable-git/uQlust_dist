using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uQlustCore;

namespace WorkFlows
{
    public interface IclusterType
    {
        void SetProfileName(string name);
       void Show();
       INPUTMODE GetInputType();
       string ToString();
       void HideRmsdLike();
    }
}
