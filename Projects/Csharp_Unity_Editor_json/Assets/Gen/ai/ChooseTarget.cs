
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

public sealed class ChooseTarget :  ai.Service 
{
    public ChooseTarget()
    {
            resultTargetKey = "";
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "ai.ChooseTarget";

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
            var _fieldJson = _json["result_target_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  resultTargetKey = _fieldJson;
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

            if (resultTargetKey == null) { throw new System.ArgumentNullException(); }
            _json["result_target_key"] = new JSONString(resultTargetKey);
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
        UnityEditor.EditorGUILayout.LabelField("result_target_key", GUILayout.Width(100));
        resultTargetKey = UnityEditor.EditorGUILayout.TextField(resultTargetKey, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.EndVertical();
    }

    public static ChooseTarget LoadJsonChooseTarget(SimpleJSON.JSONNode _json)
    {
        ChooseTarget obj = new ai.ChooseTarget();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonChooseTarget(ChooseTarget _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string resultTargetKey;
    public UnityEngine.Object resultTargetKey_UnityObject;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "resultTargetKey:" + resultTargetKey + ","
        + "}";
    }
}

}
