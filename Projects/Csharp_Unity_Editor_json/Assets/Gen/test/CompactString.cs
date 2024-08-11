
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

namespace editor.cfg.test
{

public sealed class CompactString :  Luban.EditorBeanBase 
{
    public CompactString()
    {
            s2 = "";
            s3 = "";
    }

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
            var _fieldJson = _json["s2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  s2 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["s3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  s3 = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {

            if (s2 == null) { throw new System.ArgumentNullException(); }
            _json["s2"] = new JSONString(s2);
        }
        {

            if (s3 == null) { throw new System.ArgumentNullException(); }
            _json["s3"] = new JSONString(s3);
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
        UnityEditor.EditorGUILayout.LabelField("s2", GUILayout.Width(100));
        s2 = UnityEditor.EditorGUILayout.TextField(s2, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("s3", GUILayout.Width(100));
        s3 = UnityEditor.EditorGUILayout.TextField(s3, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.EndVertical();
    }

    public static CompactString LoadJsonCompactString(SimpleJSON.JSONNode _json)
    {
        CompactString obj = new test.CompactString();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonCompactString(CompactString _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public UnityEngine.Object id_UnityObject;
    public string s2;
    public UnityEngine.Object s2_UnityObject;
    public string s3;
    public UnityEngine.Object s3_UnityObject;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "s2:" + s2 + ","
        + "s3:" + s3 + ","
        + "}";
    }
}

}
