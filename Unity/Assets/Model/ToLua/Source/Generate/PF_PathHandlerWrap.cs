﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_PathHandlerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.PathHandler), typeof(System.Object));
		L.RegFunction("InitializeForPath", InitializeForPath);
		L.RegFunction("DestroyNode", DestroyNode);
		L.RegFunction("InitializeNode", InitializeNode);
		L.RegFunction("GetPathNode", GetPathNode);
		L.RegFunction("ClearPathIDs", ClearPathIDs);
		L.RegFunction("New", _CreatePF_PathHandler);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("threadID", get_threadID, null);
		L.RegVar("totalThreadCount", get_totalThreadCount, null);
		L.RegVar("heap", get_heap, null);
		L.RegVar("nodes", get_nodes, set_nodes);
		L.RegVar("DebugStringBuilder", get_DebugStringBuilder, null);
		L.RegVar("PathID", get_PathID, null);
		L.RegFunction("getPathID", get_PathID);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePF_PathHandler(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				PF.PathHandler obj = new PF.PathHandler(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PF.PathHandler.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitializeForPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.PathHandler obj = (PF.PathHandler)ToLua.CheckObject<PF.PathHandler>(L, 1);
			PF.Path arg0 = (PF.Path)ToLua.CheckObject<PF.Path>(L, 2);
			obj.InitializeForPath(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyNode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.PathHandler obj = (PF.PathHandler)ToLua.CheckObject<PF.PathHandler>(L, 1);
			PF.GraphNode arg0 = (PF.GraphNode)ToLua.CheckObject<PF.GraphNode>(L, 2);
			obj.DestroyNode(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitializeNode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.PathHandler obj = (PF.PathHandler)ToLua.CheckObject<PF.PathHandler>(L, 1);
			PF.GraphNode arg0 = (PF.GraphNode)ToLua.CheckObject<PF.GraphNode>(L, 2);
			obj.InitializeNode(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPathNode(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<int>(L, 2))
			{
				PF.PathHandler obj = (PF.PathHandler)ToLua.CheckObject<PF.PathHandler>(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				PF.PathNode o = obj.GetPathNode(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<PF.GraphNode>(L, 2))
			{
				PF.PathHandler obj = (PF.PathHandler)ToLua.CheckObject<PF.PathHandler>(L, 1);
				PF.GraphNode arg0 = (PF.GraphNode)ToLua.ToObject(L, 2);
				PF.PathNode o = obj.GetPathNode(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.PathHandler.GetPathNode");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearPathIDs(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PF.PathHandler obj = (PF.PathHandler)ToLua.CheckObject<PF.PathHandler>(L, 1);
			obj.ClearPathIDs();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_threadID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.PathHandler obj = (PF.PathHandler)o;
			int ret = obj.threadID;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index threadID on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_totalThreadCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.PathHandler obj = (PF.PathHandler)o;
			int ret = obj.totalThreadCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index totalThreadCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_heap(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.PathHandler obj = (PF.PathHandler)o;
			PF.BinaryHeap ret = obj.heap;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index heap on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nodes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.PathHandler obj = (PF.PathHandler)o;
			PF.PathNode[] ret = obj.nodes;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nodes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DebugStringBuilder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.PathHandler obj = (PF.PathHandler)o;
			System.Text.StringBuilder ret = obj.DebugStringBuilder;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DebugStringBuilder on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PathID(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.PathHandler obj = (PF.PathHandler)o;
			ushort ret = obj.PathID;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PathID on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_nodes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.PathHandler obj = (PF.PathHandler)o;
			PF.PathNode[] arg0 = ToLua.CheckObjectArray<PF.PathNode>(L, 2);
			obj.nodes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nodes on a nil value");
		}
	}
}
