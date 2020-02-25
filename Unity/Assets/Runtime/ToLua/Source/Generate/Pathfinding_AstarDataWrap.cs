﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_AstarDataWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.AstarData), typeof(System.Object));
		L.RegFunction("GetData", GetData);
		L.RegFunction("SetData", SetData);
		L.RegFunction("Awake", Awake);
		L.RegFunction("UpdateShortcuts", UpdateShortcuts);
		L.RegFunction("LoadFromCache", LoadFromCache);
		L.RegFunction("SerializeGraphs", SerializeGraphs);
		L.RegFunction("DeserializeGraphs", DeserializeGraphs);
		L.RegFunction("OnDestroy", OnDestroy);
		L.RegFunction("DeserializeGraphsAdditive", DeserializeGraphsAdditive);
		L.RegFunction("FindGraphTypes", FindGraphTypes);
		L.RegFunction("AddGraph", AddGraph);
		L.RegFunction("RemoveGraph", RemoveGraph);
		L.RegFunction("FindGraph", FindGraph);
		L.RegFunction("FindGraphOfType", FindGraphOfType);
		L.RegFunction("FindGraphWhichInheritsFrom", FindGraphWhichInheritsFrom);
		L.RegFunction("FindGraphsOfType", FindGraphsOfType);
		L.RegFunction("GetGraphIndex", GetGraphIndex);
		L.RegFunction("New", _CreatePathfinding_AstarData);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("graphs", get_graphs, set_graphs);
		L.RegVar("file_cachedStartup", get_file_cachedStartup, set_file_cachedStartup);
		L.RegVar("data_cachedStartup", get_data_cachedStartup, set_data_cachedStartup);
		L.RegVar("cacheStartup", get_cacheStartup, set_cacheStartup);
		L.RegVar("recastGraph", get_recastGraph, null);
		L.RegFunction("getrecastGraph", get_recastGraph);
		L.RegVar("graphTypes", get_graphTypes, null);
		L.RegFunction("getgraphTypes", get_graphTypes);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathfinding_AstarData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Pathfinding.AstarData obj = new Pathfinding.AstarData();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Pathfinding.AstarData.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			byte[] o = obj.GetData();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.SetData(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Awake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			obj.Awake();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateShortcuts(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			obj.UpdateShortcuts();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadFromCache(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			obj.LoadFromCache();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SerializeGraphs(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
				byte[] o = obj.SerializeGraphs();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
				PF.SerializeSettings arg0 = (PF.SerializeSettings)ToLua.CheckObject<PF.SerializeSettings>(L, 2);
				byte[] o = obj.SerializeGraphs(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
				PF.SerializeSettings arg0 = (PF.SerializeSettings)ToLua.CheckObject<PF.SerializeSettings>(L, 2);
				uint arg1;
				byte[] o = obj.SerializeGraphs(arg0, out arg1);
				ToLua.Push(L, o);
				LuaDLL.lua_pushnumber(L, arg1);
				return 2;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.AstarData.SerializeGraphs");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeserializeGraphs(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
				obj.DeserializeGraphs();
				return 0;
			}
			else if (count == 2)
			{
				Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				obj.DeserializeGraphs(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.AstarData.DeserializeGraphs");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDestroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			obj.OnDestroy();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeserializeGraphsAdditive(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.DeserializeGraphsAdditive(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindGraphTypes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			obj.FindGraphTypes();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddGraph(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			PF.NavGraph o = obj.AddGraph(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveGraph(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			PF.NavGraph arg0 = (PF.NavGraph)ToLua.CheckObject<PF.NavGraph>(L, 2);
			bool o = obj.RemoveGraph(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindGraph(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			System.Func<PF.NavGraph,bool> arg0 = (System.Func<PF.NavGraph,bool>)ToLua.CheckDelegate<System.Func<PF.NavGraph,bool>>(L, 2);
			PF.NavGraph o = obj.FindGraph(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindGraphOfType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			PF.NavGraph o = obj.FindGraphOfType(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindGraphWhichInheritsFrom(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			PF.NavGraph o = obj.FindGraphWhichInheritsFrom(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindGraphsOfType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			System.Collections.IEnumerable o = obj.FindGraphsOfType(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGraphIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)ToLua.CheckObject<Pathfinding.AstarData>(L, 1);
			PF.NavGraph arg0 = (PF.NavGraph)ToLua.CheckObject<PF.NavGraph>(L, 2);
			int o = obj.GetGraphIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_graphs(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			PF.NavGraph[] ret = obj.graphs;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index graphs on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_file_cachedStartup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			UnityEngine.TextAsset ret = obj.file_cachedStartup;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index file_cachedStartup on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_data_cachedStartup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			byte[] ret = obj.data_cachedStartup;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index data_cachedStartup on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cacheStartup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			bool ret = obj.cacheStartup;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cacheStartup on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_recastGraph(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			PF.RecastGraph ret = obj.recastGraph;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index recastGraph on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_graphTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			System.Type[] ret = obj.graphTypes;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index graphTypes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_graphs(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			PF.NavGraph[] arg0 = ToLua.CheckObjectArray<PF.NavGraph>(L, 2);
			obj.graphs = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index graphs on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_file_cachedStartup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			UnityEngine.TextAsset arg0 = (UnityEngine.TextAsset)ToLua.CheckObject<UnityEngine.TextAsset>(L, 2);
			obj.file_cachedStartup = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index file_cachedStartup on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_data_cachedStartup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.data_cachedStartup = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index data_cachedStartup on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cacheStartup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AstarData obj = (Pathfinding.AstarData)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.cacheStartup = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cacheStartup on a nil value");
		}
	}
}
