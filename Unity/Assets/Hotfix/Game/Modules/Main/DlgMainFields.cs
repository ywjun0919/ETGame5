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
            btn_CreateRoom = this.GetChild("CreateRoomBtn").asButton;
            btn_EnterRoom = this.GetChild("EnterRoomBtn").asButton;
            btn_Daikai = this.GetChild("DaikaiBtn").asButton;
        }
    }
}
