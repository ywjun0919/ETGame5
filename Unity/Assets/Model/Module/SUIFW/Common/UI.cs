﻿/**
 *
 */

using System;
using FairyGUI;

namespace ETModel
{
    public static class UI
    {
        public static BaseUIForms Open(Type type)
        {
            return UIManagerComponent.Instance.ShowUIForms(type);
        }


        public static void Close(Type type)
        {
            UIManagerComponent.Instance.CloseUIForms(type);
        }

        /// <summary>
        /// 清空ui
        /// </summary>
        public static void ClearUI()
        {
            Game.Scene.RemoveComponent<UIManagerComponent>();
            Game.Scene.AddComponent<UIManagerComponent>();
        }

        /// <summary>
        /// 提示
        /// </summary>
        /// <param name="content"></param>
        private static GComponent tip;
        public static void Tip(string content)
        {
            if (tip == null)
            {
#if UNITY_EDITOR
                UIPackage.AddPackage("UI/Common");
#endif
                tip = UIPackage.CreateObject("Common", "Tip").asCom;
            }
            tip.GetChild("textContent").asTextField.text = content;
            GRoot.inst.ShowPopup(tip);
            tip.Center();
        }


    }//class_end
}