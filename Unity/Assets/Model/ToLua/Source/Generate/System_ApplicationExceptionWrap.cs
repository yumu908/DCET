﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_ApplicationExceptionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.ApplicationException), typeof(System.Exception));
		L.RegFunction("New", _CreateSystem_ApplicationException);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSystem_ApplicationException(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				System.ApplicationException obj = new System.ApplicationException();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				System.ApplicationException obj = new System.ApplicationException(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				System.Exception arg1 = (System.Exception)ToLua.CheckObject<System.Exception>(L, 2);
				System.ApplicationException obj = new System.ApplicationException(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: System.ApplicationException.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
