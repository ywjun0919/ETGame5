using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHotfix
{
    class DlgPokerRoom:BaseUIForms
    {
        public DlgPokerRoom()
        {
            this.pakName = "Poker";
            this.cmpName = "Cards";
            this.CurrentUIType.NeedClearingStack = true;
            this.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.HideOther;
            this.CurrentUIType.UIForms_Type = UIFormsType.Normal;
            Log.Debug("DlgPokerRoom Open");
        }
    }
}
