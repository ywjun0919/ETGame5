using FairyGUI;

namespace ETHotfix
{
    partial class DlgMain
    {
        private GButton btn_CreateRoom;
        private GButton btn_EnterRoom;
        private GButton btn_Daikai;

        public override void ExportFields()
        {
            base.ExportFields();
            GComponent gcmp = this.GObject.asCom;
            btn_CreateRoom = gcmp.GetChild("CreateRoomBtn").asButton;
            btn_EnterRoom = gcmp.GetChild("EnterRoomBtn").asButton;
            btn_Daikai = gcmp.GetChild("DaikaiBtn").asButton;
        }
    }
}
