using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETModel
{
    class LoadingUI:BaseUIForms
    {
        public LoadingUI()
        {
            this.pakName = "Loading";
            this.cmpName = "cmp_loading";
            this.CurrentUIType.NeedClearingStack = true;
            this.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.HideOther;
            this.CurrentUIType.UIForms_Type = UIFormsType.Normal;

        }
    }
}
