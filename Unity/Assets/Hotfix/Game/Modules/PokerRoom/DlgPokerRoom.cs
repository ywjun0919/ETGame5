using FairyGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

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

        private GObject m_Btn_Close;
        private GList m_List_Role;
        public override void ExportFields()
        {
            base.ExportFields();
            m_Btn_Close = this.GetChild("frame").asCom.GetChild("closeButton");
            m_List_Role = this.GetChild("RoleList").asList;
        }

        public override void RegistUIEvents()
        {
            base.RegistUIEvents();
            m_Btn_Close.onClick.Add(OnButton_Close);
            List<CardDto> cards = new List<CardDto>();
            Dictionary<int, int> select = new Dictionary<int, int>();
            for(int i = CardWeight.THREE;i<=CardWeight.LJOKER; ++i)
            {
                string name = "";
                if (i >= CardWeight.SJOKER)
                {
                    name = CardWeight.GetString(i);
                }
                else
                {
                    name = CardColor.GetString(CardColor.CLUB) + CardWeight.GetString(i);
                }
                cards.Add(new CardDto(name,CardColor.HEART,i));
            }
            int start = -1;
            int end = -1;
            bool over = false;
            m_List_Role.itemRenderer = (index,obj) => {
                CardDto cardDto = cards[index];
                obj.asCom.GetChild("icon").asLoader.url = "ui://Poker/" + cardDto.Name;
                obj.onTouchBegin.Add((context) =>
                {
                    over = false;
                    context.CaptureTouch();
                    Log.Debug("onTouchBegin:" + index.ToString());
                    start = index;
                });

                obj.onTouchEnd.Add((context) =>
                {
                    int realEnd= m_List_Role.GetChildIndex(m_List_Role.touchItem);

                    if (realEnd == end || realEnd <0)
                    {
                        return;
                    }
                    end = realEnd;
                    if (end < 0 || over) return;
                    Log.Debug("onTouchEnd:" + end.ToString());
                    if (start > end)
                    {
                        int temp = start;
                        start = end;
                        end = temp;
                    }
                    for (int i = start; i <= end; ++i)
                    {
                        SetSelectCards(i, select, m_List_Role.GetChildAt(i));
                    }
                    start = -1;
                    end = -1;
                    over = true;
                });
            };
            m_List_Role.numItems = cards.Count;
            //m_List_Role.onClickItem.Add((context) =>
            //{
            //    Log.Debug("Test");
            //    GButton button = (GButton)context.data;
            //    int index = m_List_Role.GetChildIndex(button);
            //    Log.Debug(index.ToString());
            //    SetSelectCards(index,select,button);
            //});


            //m_List_Role.onTouchBegin.Add((obj) =>
            //{
            //    //int index = m_List_Role.GetChildIndex(m_List_Role.touchItem);
            //    Log.Debug("onTouchBegin:" + obj.data.ToString());
            //});
            //m_List_Role.onTouchEnd.Add((obj) =>
            //{
            //    //int index = m_List_Role.GetChildIndex(m_List_Role.touchItem);
            //    Log.Debug("onTouchEnd:" + obj.data.ToString());
            //});
            //m_List_Role.onTouchEnd.Add((obj) => {
            //    //int index = m_List_Role.GetChildIndex(m_List_Role.touchItem);
            //    //Log.Debug("onTouchEnd:" + index.ToString());
            //    //end = index;
            //    //if (start > index)
            //    //{
            //    //    end = start;
            //    //    start = index;
            //    //}
            //    //for(int i = start;i<=end;++i)
            //    //{
            //    //    //SetSelectCards(i, select, m_List_Role.GetChildAt(i));
            //    //}
            //    GObject gObject = GRoot.inst.touchTarget;
            //    if(null != gObject)
            //    {
            //        Log.Debug("aaaaaaaaaa");
            //    }
            //});
            m_List_Role.onTouchMove.Add((obj) =>
            {
                Log.Debug("onTouchMove:" + obj.ToString());
                if(null != m_List_Role.touchItem)
                {
                    int index = m_List_Role.GetChildIndex(m_List_Role.touchItem);
                    Log.Debug("onTouchMove:" + index.ToString());
                }
            });
        }

        private void SetSelectCards(int index,Dictionary<int,int> select,GObject button)
        {
            int upValue = -10;
            if (!select.ContainsKey(index))
            {
                select.Add(index, -upValue);
            }
            else
            {
                upValue = select[index];
                select.Remove(index);
            }
            var pos = button.position + upValue * Vector3.up;
            button.SetPosition(pos.x, pos.y, pos.z);
        }


        private void OnButton_Close()
        {
            this.Close();
        }

    }
}
