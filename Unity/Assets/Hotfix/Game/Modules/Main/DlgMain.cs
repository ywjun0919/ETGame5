using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHotfix
{ 
    class DlgMain:BaseUIForms
    {
        public DlgMain()
        {
            this.pakName = "Lobby";
            this.cmpName = "LobbyBg";
            this.CurrentUIType.NeedClearingStack = true;
            this.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.HideOther;
            this.CurrentUIType.UIForms_Type = UIFormsType.Normal;
        }
    }
}
