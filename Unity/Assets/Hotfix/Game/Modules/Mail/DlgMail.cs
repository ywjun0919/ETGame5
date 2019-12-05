using FairyGUI;

namespace ETHotfix
{
    class DlgMail:BaseUIForms
    {
        GList _list;
        public DlgMail()
        {
            this.pakName = "VirtualList";
            this.cmpName = "Main";
            this.CurrentUIType.NeedClearingStack = true;
            this.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.HideOther;
            this.CurrentUIType.UIForms_Type = UIFormsType.Normal;
        }

        public override void ExportFields()
        {
            base.ExportFields();
            _list = this.GetChild("mailList").asList;
        }

        public override void InitUI()
        {
            base.InitUI();
            //_list.SetVirtual();
            //_list.itemRenderer = RenderListItem;
            _list.numItems = 100;
        }

        void RenderListItem(int index, GObject obj)
        {
            //MailItem item = (MailItem)obj;
            //item.setFetched(index % 3 == 0);
            //item.setRead(index % 2 == 0);
            //item.setTime("5 Nov 2015 16:24:33");
            //item.title = index + " Mail title here";
        }
    }


    public class MailItem : GButton
    {
        GTextField _timeText;
        Controller _readController;
        Controller _fetchController;
        Transition _trans;

        //public override void ConstructFromXML(FairyGUI.Utils.XML cxml)
        //{
        //    base.ConstructFromXML(cxml);

        //    _timeText = this.GetChild("timeText").asTextField;
        //    _readController = this.GetController("IsRead");
        //    _fetchController = this.GetController("c1");
        //    _trans = this.GetTransition("t0");
        //}

        public void setTime(string value)
        {
            _timeText.text = value;
        }

        public void setRead(bool value)
        {
            _readController.selectedIndex = value ? 1 : 0;
        }

        public void setFetched(bool value)
        {
            _fetchController.selectedIndex = value ? 1 : 0;
        }

        public void PlayEffect(float delay)
        {
            this.visible = false;
            _trans.Play(1, delay, null);
        }
    }
}
