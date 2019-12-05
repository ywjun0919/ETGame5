using FairyGUI;

namespace ETHotfix
{ 
    partial class DlgMain:BaseUIForms
    {
        public DlgMain()
        {
            this.pakName = "Lobby";
            this.cmpName = "LobbyBg";
            this.CurrentUIType.NeedClearingStack = true;
            this.CurrentUIType.UIForms_ShowMode = UIFormsShowMode.HideOther;
            this.CurrentUIType.UIForms_Type = UIFormsType.Normal;
        }

        public override void RegistUIEvents()
        {
            base.RegistUIEvents();
            btn_CreateRoom.onClick.Add(OnBtn_CreateRoom);
            btn_EnterRoom.onClick.Add(OnBtn_EnterRoom);
            btn_Daikai.onClick.Add(OnBtn_Daikai);
        }

        private void OnBtn_CreateRoom()
        {
            Log.Debug("OnBtn_CreateRoom");
            Game.EventSystem.Run(EventIdType.RoomOpen);
        }
        private void OnBtn_EnterRoom()
        {
            Log.Debug("OnBtn_EnterRoom");
        }
        private void OnBtn_Daikai()
        {
            Log.Debug("OnBtn_Daikai");
        }
    }
}
