
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using SimpleJSON;
using Luban;
using UnityEngine;
using System.Linq;

namespace editor.cfg.ai
{

public sealed class UeCooldown :  ai.Decorator 
{
    public UeCooldown()
    {
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "ai.UeCooldown";

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["node_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  nodeName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["flow_abort_mode"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { flowAbortMode = (ai.EFlowAbortMode)System.Enum.Parse(typeof(ai.EFlowAbortMode), _fieldJson); } else if(_fieldJson.IsNumber) { flowAbortMode = (ai.EFlowAbortMode)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
        }
        
        { 
            var _fieldJson = _json["cooldown_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  cooldownTime = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {

            if (nodeName == null) { throw new System.ArgumentNullException(); }
            _json["node_name"] = new JSONString(nodeName);
        }
        {
            _json["flow_abort_mode"] = new JSONNumber((int)flowAbortMode);
        }
        {
            _json["cooldown_time"] = new JSONNumber(cooldownTime);
        }
    }


    public override void Render()
    {
        UnityEditor.EditorGUILayout.BeginVertical();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("id", GUILayout.Width(100));
        id = UnityEditor.EditorGUILayout.IntField(id, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("node_name", GUILayout.Width(100));
        nodeName = UnityEditor.EditorGUILayout.TextField(nodeName, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("flow_abort_mode", GUILayout.Width(100));
        flowAbortMode = (ai.EFlowAbortMode)UnityEditor.EditorGUILayout.EnumPopup(flowAbortMode, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("cooldown_time", GUILayout.Width(100));
        cooldownTime = UnityEditor.EditorGUILayout.FloatField(cooldownTime, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.EndVertical();
    }

    public static UeCooldown LoadJsonUeCooldown(SimpleJSON.JSONNode _json)
    {
        UeCooldown obj = new ai.UeCooldown();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonUeCooldown(UeCooldown _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public float cooldownTime;
    public UnityEngine.Object cooldownTime_UnityObject;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "cooldownTime:" + cooldownTime + ","
        + "}";
    }
}

}
