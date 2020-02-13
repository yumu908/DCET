-- Generated by CSharp.lua Compiler
local System = System
local UnityEngine = UnityEngine
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("LayerNames", function (namespace)
    local GetLayerInt, GetLayerStr
    -- <summary>
    -- 通过Layers名字得到对应层
    -- </summary>
    -- <returns></returns>
    GetLayerInt = function (name)
      return UnityEngine.LayerMask.NameToLayer(name)
    end
    GetLayerStr = function (name)
      return UnityEngine.LayerMask.LayerToName(name)
    end
    return {
      GetLayerInt = GetLayerInt,
      GetLayerStr = GetLayerStr
    }
  end)
end)