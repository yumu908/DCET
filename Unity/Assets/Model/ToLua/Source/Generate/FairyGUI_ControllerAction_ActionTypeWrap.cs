﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_ControllerAction_ActionTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.ControllerAction.ActionType));
		L.RegConstant("PlayTransition", FairyGUI.ControllerAction.ActionType.PlayTransition);
		L.RegConstant("ChangePage", FairyGUI.ControllerAction.ActionType.ChangePage);
		L.EndEnum();
		TypeTraits<FairyGUI.ControllerAction.ActionType>.Check = CheckType;
		StackTraits<FairyGUI.ControllerAction.ActionType>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.ControllerAction.ActionType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.ControllerAction.ActionType), L, pos);
	}
}
