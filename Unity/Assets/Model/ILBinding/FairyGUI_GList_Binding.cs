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
    unsafe class FairyGUI_GList_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(FairyGUI.GList);
            args = new Type[]{};
            method = type.GetMethod("SetVirtual", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetVirtual_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_numItems", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_numItems_1);
            args = new Type[]{};
            method = type.GetMethod("get_touchItem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touchItem_2);

            field = type.GetField("itemRenderer", flag);
            app.RegisterCLRFieldGetter(field, get_itemRenderer_0);
            app.RegisterCLRFieldSetter(field, set_itemRenderer_0);


        }


        static StackObject* SetVirtual_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GList instance_of_this_method = (FairyGUI.GList)typeof(FairyGUI.GList).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetVirtual();

            return __ret;
        }

        static StackObject* set_numItems_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            FairyGUI.GList instance_of_this_method = (FairyGUI.GList)typeof(FairyGUI.GList).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.numItems = value;

            return __ret;
        }

        static StackObject* get_touchItem_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            FairyGUI.GList instance_of_this_method = (FairyGUI.GList)typeof(FairyGUI.GList).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.touchItem;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_itemRenderer_0(ref object o)
        {
            return ((FairyGUI.GList)o).itemRenderer;
        }
        static void set_itemRenderer_0(ref object o, object v)
        {
            ((FairyGUI.GList)o).itemRenderer = (FairyGUI.ListItemRenderer)v;
        }


    }
}
