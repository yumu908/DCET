﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_SerializeSettingsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.SerializeSettings), typeof(System.Object));
		L.RegFunction("New", _CreatePF_SerializeSettings);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("nodes", get_nodes, set_nodes);
		L.RegVar("editorSettings", get_editorSettings, set_editorSettings);
		L.RegVar("Settings", get_Settings, null);
		L.RegFunction("getSettings", get_Settings);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePF_SerializeSettings(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				PF.SerializeSettings obj = new PF.SerializeSettings();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PF.SerializeSettings.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nodes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.SerializeSettings obj = (PF.SerializeSettings)o;
			bool ret = obj.nodes;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nodes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_editorSettings(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.SerializeSettings obj = (PF.SerializeSettings)o;
			bool ret = obj.editorSettings;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index editorSettings on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Settings(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, PF.SerializeSettings.Settings);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_nodes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.SerializeSettings obj = (PF.SerializeSettings)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.nodes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nodes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_editorSettings(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.SerializeSettings obj = (PF.SerializeSettings)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.editorSettings = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index editorSettings on a nil value");
		}
	}
}
