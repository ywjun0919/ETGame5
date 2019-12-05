/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ETHotfix
{
	public partial class DlgCreateRoomWinFrame
	{
		public GComponent m_frame;
		public GComponent m_title;
		public GImage m_tipBg;
		public GTextField m_tip;
		public GImage m_listbg;
		public GGraph m_dragArea;
		public GGraph m_contentArea;
		public GList m_dataList;
		public Transition m_t0;
		public GButton m_OnClose;

		public const string URL = "ui://l8xvrp74t2i09";

		public DlgCreateRoomWinFrame()
		{
            this.pakName = "Lobby";
            this.cmpName = "CreateRoomWinFrame";
		}

        public override void ExportFields()
        {

			m_frame = (GComponent)this.GetChild("frame");
			m_title = (GComponent)this.GetChild("title");
			m_tipBg = (GImage)this.GetChild("tipBg");
			m_tip = (GTextField)this.GetChild("tip");
			m_listbg = (GImage)this.GetChild("listbg");
			m_dragArea = (GGraph)this.GetChild("dragArea");
			m_contentArea = (GGraph)this.GetChild("contentArea");
			m_dataList = (GList)this.GetChild("dataList");
			m_t0 = this.GetTransition("t0");
			m_OnClose = (GButton)m_frame.GetChild("closeButton");

        }
	}
}