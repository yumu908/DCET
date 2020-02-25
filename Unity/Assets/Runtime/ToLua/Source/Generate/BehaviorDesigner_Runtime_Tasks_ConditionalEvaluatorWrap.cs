﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BehaviorDesigner_Runtime_Tasks_ConditionalEvaluatorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator), typeof(BehaviorDesigner.Runtime.Tasks.Decorator));
		L.RegFunction("OnAwake", OnAwake);
		L.RegFunction("OnStart", OnStart);
		L.RegFunction("CanExecute", CanExecute);
		L.RegFunction("CanReevaluate", CanReevaluate);
		L.RegFunction("OnTick", OnTick);
		L.RegFunction("OnChildExecuted", OnChildExecuted);
		L.RegFunction("OverrideStatus", OverrideStatus);
		L.RegFunction("OnEnd", OnEnd);
		L.RegFunction("OnReset", OnReset);
		L.RegFunction("New", _CreateBehaviorDesigner_Runtime_Tasks_ConditionalEvaluator);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("reevaluate", get_reevaluate, set_reevaluate);
		L.RegVar("conditionalTask", get_conditionalTask, set_conditionalTask);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateBehaviorDesigner_Runtime_Tasks_ConditionalEvaluator(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = new BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnAwake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
			obj.OnAwake();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
			obj.OnStart();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanExecute(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
			bool o = obj.CanExecute();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanReevaluate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
			bool o = obj.CanReevaluate();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnTick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
			BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.OnTick();
			LuaDLL.lua_pushinteger(L, (int)o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnChildExecuted(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
				obj.OnChildExecuted(arg0);
				return 0;
			}
			else if (count == 3)
			{
				BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg1 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 3);
				obj.OnChildExecuted(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator.OnChildExecuted");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OverrideStatus(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.OverrideStatus();
				LuaDLL.lua_pushinteger(L, (int)o);
				return 1;
			}
			else if (count == 2)
			{
				BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
				BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.OverrideStatus(arg0);
				LuaDLL.lua_pushinteger(L, (int)o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator.OverrideStatus");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
			obj.OnEnd();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnReset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator>(L, 1);
			obj.OnReset();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reevaluate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)o;
			bool ret = obj.reevaluate;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index reevaluate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_conditionalTask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)o;
			BehaviorDesigner.Runtime.Tasks.Conditional ret = obj.conditionalTask;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index conditionalTask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_reevaluate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.reevaluate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index reevaluate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_conditionalTask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator obj = (BehaviorDesigner.Runtime.Tasks.ConditionalEvaluator)o;
			BehaviorDesigner.Runtime.Tasks.Conditional arg0 = (BehaviorDesigner.Runtime.Tasks.Conditional)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Conditional>(L, 2);
			obj.conditionalTask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index conditionalTask on a nil value");
		}
	}
}
