﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Serializers_IPEndPointSerializerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Serializers.IPEndPointSerializer), typeof(MongoDB.Bson.Serialization.Serializers.ClassSerializerBase<System.Net.IPEndPoint>));
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Serializers_IPEndPointSerializer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Serializers_IPEndPointSerializer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Serializers.IPEndPointSerializer obj = new MongoDB.Bson.Serialization.Serializers.IPEndPointSerializer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Serializers.IPEndPointSerializer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
