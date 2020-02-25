﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_AdvancedSmooth_TurnConstructorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.AdvancedSmooth.TurnConstructor), typeof(System.Object));
		L.RegFunction("Prepare", Prepare);
		L.RegFunction("OnTangentUpdate", OnTangentUpdate);
		L.RegFunction("PointToTangent", PointToTangent);
		L.RegFunction("TangentToPoint", TangentToPoint);
		L.RegFunction("TangentToTangent", TangentToTangent);
		L.RegFunction("GetPath", GetPath);
		L.RegFunction("Setup", Setup);
		L.RegFunction("PostPrepare", PostPrepare);
		L.RegFunction("AddCircleSegment", AddCircleSegment);
		L.RegFunction("DebugCircleSegment", DebugCircleSegment);
		L.RegFunction("DebugCircle", DebugCircle);
		L.RegFunction("GetLengthFromAngle", GetLengthFromAngle);
		L.RegFunction("ClockwiseAngle", ClockwiseAngle);
		L.RegFunction("CounterClockwiseAngle", CounterClockwiseAngle);
		L.RegFunction("AngleToVector", AngleToVector);
		L.RegFunction("ToDegrees", ToDegrees);
		L.RegFunction("ClampAngle", ClampAngle);
		L.RegFunction("Atan2", Atan2);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("constantBias", get_constantBias, set_constantBias);
		L.RegVar("factorBias", get_factorBias, set_factorBias);
		L.RegVar("turningRadius", get_turningRadius, set_turningRadius);
		L.RegConstant("ThreeSixtyRadians", 6.28318530717959);
		L.RegVar("prev", get_prev, set_prev);
		L.RegVar("current", get_current, set_current);
		L.RegVar("next", get_next, set_next);
		L.RegVar("t1", get_t1, set_t1);
		L.RegVar("t2", get_t2, set_t2);
		L.RegVar("normal", get_normal, set_normal);
		L.RegVar("prevNormal", get_prevNormal, set_prevNormal);
		L.RegVar("changedPreviousTangent", get_changedPreviousTangent, set_changedPreviousTangent);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Prepare(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector3[] arg1 = ToLua.CheckStructArray<UnityEngine.Vector3>(L, 3);
			obj.Prepare(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnTangentUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			obj.OnTangentUpdate();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PointToTangent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn> arg0 = (System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn>));
			obj.PointToTangent(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TangentToPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn> arg0 = (System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn>));
			obj.TangentToPoint(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TangentToTangent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn> arg0 = (System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<Pathfinding.AdvancedSmooth.Turn>));
			obj.TangentToTangent(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			Pathfinding.AdvancedSmooth.Turn arg0 = StackTraits<Pathfinding.AdvancedSmooth.Turn>.Check(L, 2);
			System.Collections.Generic.List<UnityEngine.Vector3> arg1 = (System.Collections.Generic.List<UnityEngine.Vector3>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
			obj.GetPath(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Setup(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Vector3[] arg1 = ToLua.CheckStructArray<UnityEngine.Vector3>(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.Setup(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PostPrepare(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			Pathfinding.AdvancedSmooth.TurnConstructor.PostPrepare();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddCircleSegment(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 7);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			double arg1 = (double)LuaDLL.luaL_checknumber(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			UnityEngine.Vector3 arg3 = ToLua.ToVector3(L, 5);
			System.Collections.Generic.List<UnityEngine.Vector3> arg4 = (System.Collections.Generic.List<UnityEngine.Vector3>)ToLua.CheckObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
			float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
			obj.AddCircleSegment(arg0, arg1, arg2, arg3, arg4, arg5);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DebugCircleSegment(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			double arg1 = (double)LuaDLL.luaL_checknumber(L, 3);
			double arg2 = (double)LuaDLL.luaL_checknumber(L, 4);
			double arg3 = (double)LuaDLL.luaL_checknumber(L, 5);
			UnityEngine.Color arg4 = ToLua.ToColor(L, 6);
			obj.DebugCircleSegment(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DebugCircle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			double arg1 = (double)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.Color arg2 = ToLua.ToColor(L, 4);
			obj.DebugCircle(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLengthFromAngle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			double arg1 = (double)LuaDLL.luaL_checknumber(L, 3);
			double o = obj.GetLengthFromAngle(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClockwiseAngle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			double arg1 = (double)LuaDLL.luaL_checknumber(L, 3);
			double o = obj.ClockwiseAngle(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CounterClockwiseAngle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			double arg1 = (double)LuaDLL.luaL_checknumber(L, 3);
			double o = obj.CounterClockwiseAngle(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AngleToVector(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector3 o = obj.AngleToVector(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToDegrees(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			double o = obj.ToDegrees(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClampAngle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			double arg0 = (double)LuaDLL.luaL_checknumber(L, 2);
			double o = obj.ClampAngle(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Atan2(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)ToLua.CheckObject<Pathfinding.AdvancedSmooth.TurnConstructor>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			double o = obj.Atan2(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_constantBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)o;
			float ret = obj.constantBias;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index constantBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_factorBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)o;
			float ret = obj.factorBias;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index factorBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_turningRadius(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, Pathfinding.AdvancedSmooth.TurnConstructor.turningRadius);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_prev(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Pathfinding.AdvancedSmooth.TurnConstructor.prev);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_current(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Pathfinding.AdvancedSmooth.TurnConstructor.current);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_next(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Pathfinding.AdvancedSmooth.TurnConstructor.next);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_t1(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Pathfinding.AdvancedSmooth.TurnConstructor.t1);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_t2(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Pathfinding.AdvancedSmooth.TurnConstructor.t2);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_normal(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Pathfinding.AdvancedSmooth.TurnConstructor.normal);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_prevNormal(IntPtr L)
	{
		try
		{
			ToLua.Push(L, Pathfinding.AdvancedSmooth.TurnConstructor.prevNormal);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_changedPreviousTangent(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, Pathfinding.AdvancedSmooth.TurnConstructor.changedPreviousTangent);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_constantBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.constantBias = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index constantBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_factorBias(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.AdvancedSmooth.TurnConstructor obj = (Pathfinding.AdvancedSmooth.TurnConstructor)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.factorBias = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index factorBias on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_turningRadius(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.turningRadius = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_prev(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.prev = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_current(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.current = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_next(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.next = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_t1(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.t1 = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_t2(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.t2 = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_normal(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.normal = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_prevNormal(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.prevNormal = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_changedPreviousTangent(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			Pathfinding.AdvancedSmooth.TurnConstructor.changedPreviousTangent = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
