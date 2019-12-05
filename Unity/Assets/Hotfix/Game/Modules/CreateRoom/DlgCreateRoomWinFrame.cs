using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETHotfix
{
    public partial class DlgCreateRoomWinFrame:BaseUIForms
    {
        public override void InitUI()
        {
            base.InitUI();
            InitDataList();
        }

        public override void RegistUIEvents()
        {
            base.RegistUIEvents();
            m_OnClose.onClick.Add(() => {
                Close();
            });
        }

        private void InitDataList()
        {
            m_dataList.SetVirtual();
            m_dataList.itemRenderer = (index,obj) => {
                obj.asCom.GetChild("title").asTextField.text = index.ToString();
                obj.asCom.GetChild("icon").asLoader.url = "ui://Lobby/zjm_zhuozi";
            };
            m_dataList.numItems = 100;
        }
    }
}
