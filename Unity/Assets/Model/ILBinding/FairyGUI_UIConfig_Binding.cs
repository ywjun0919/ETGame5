using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class FairyGUI_UIConfig_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.UIConfig);

            field = type.GetField("buttonSound", flag);
            app.RegisterCLRFieldGetter(field, get_buttonSound_0);
            app.RegisterCLRFieldSetter(field, set_buttonSound_0);
            field = type.GetField("modalLayerColor", flag);
            app.RegisterCLRFieldGetter(field, get_modalLayerColor_1);
            app.RegisterCLRFieldSetter(field, set_modalLayerColor_1);


        }



        static object get_buttonSound_0(ref object o)
        {
            return FairyGUI.UIConfig.buttonSound;
        }
        static void set_buttonSound_0(ref object o, object v)
        {
            FairyGUI.UIConfig.buttonSound = (FairyGUI.NAudioClip)v;
        }
        static object get_modalLayerColor_1(ref object o)
        {
            return FairyGUI.UIConfig.modalLayerColor;
        }
        static void set_modalLayerColor_1(ref object o, object v)
        {
            FairyGUI.UIConfig.modalLayerColor = (UnityEngine.Color)v;
        }


    }
}
