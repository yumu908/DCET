﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_RelevantGraphSurfaceWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.RelevantGraphSurface), typeof(Pathfinding.VersionedMonoBehaviour));
		L.RegFunction("UpdatePosition", UpdatePosition);
		L.RegFunction("UpdateAllPositions", UpdateAllPositions);
		L.RegFunction("FindAllGraphSurfaces", FindAllGraphSurfaces);
		L.RegFunction("OnDrawGizmos", OnDrawGizmos);
		L.RegFunction("OnDrawGizmosSelected", OnDrawGizmosSelected);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("maxRange", get_maxRange, set_maxRange);
		L.RegVar("Position", get_Position, null);
		L.RegFunction("getPosition", get_Position);
		L.RegVar("Next", get_Next, null);
		L.RegFunction("getNext", get_Next);
		L.RegVar("Prev", get_Prev, null);
		L.RegFunction("getPrev", get_Prev);
		L.RegVar("Root", get_Root, null);
		L.RegFunction("getRoot", get_Root);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdatePosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.RelevantGraphSurface obj = (Pathfinding.RelevantGraphSurface)ToLua.CheckObject<Pathfinding.RelevantGraphSurface>(L, 1);
			obj.UpdatePosition();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateAllPositions(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			Pathfinding.RelevantGraphSurface.UpdateAllPositions();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindAllGraphSurfaces(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			Pathfinding.RelevantGraphSurface.FindAllGraphSurfaces();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrawGizmos(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.RelevantGraphSurface obj = (Pathfinding.RelevantGraphSurface)ToLua.CheckObject<Pathfinding.RelevantGraphSurface>(L, 1);
			obj.OnDrawGizmos();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrawGizmosSelected(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.RelevantGraphSurface obj = (Pathfinding.RelevantGraphSurface)ToLua.CheckObject<Pathfinding.RelevantGraphSurface>(L, 1);
			obj.OnDrawGizmosSelected();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxRange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RelevantGraphSurface obj = (Pathfinding.RelevantGraphSurface)o;
			float ret = obj.maxRange;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxRange on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RelevantGraphSurface obj = (Pathfinding.RelevantGraphSurface)o;
			UnityEngine.Vector3 ret = obj.Position;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Next(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RelevantGraphSurface obj = (Pathfinding.RelevantGraphSurface)o;
			Pathfinding.RelevantGraphSurface ret = obj.Next;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Next on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Prev(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RelevantGraphSurface obj = (Pathfinding.RelevantGraphSurface)o;
			Pathfinding.RelevantGraphSurface ret = obj.Prev;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Prev on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Root(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Pathfinding.RelevantGraphSurface.Root);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxRange(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RelevantGraphSurface obj = (Pathfinding.RelevantGraphSurface)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.maxRange = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxRange on a nil value");
		}
	}
}
