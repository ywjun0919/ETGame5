using FairyGUI;
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
            this.CurrentUIType.NeedClearingStack = false;
            this.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.ReverseChange;
            this.CurrentUIType.UIForms_Type = UIFormsType.Normal;
            Log.Debug("DlgPokerRoom Open");
        }

        private GObject btn_Close;
        public override void ExportFields()
        {
            base.ExportFields();
            btn_Close = this.GetChild("frame").asCom.GetChild("closeButton");
        }

        public override void RegistUIEvents()
        {
            base.RegistUIEvents();
            btn_Close.onClick.Add(OnButton_Close);
        }

        private void OnButton_Close()
        {
            this.Close();
        }

    }
}
