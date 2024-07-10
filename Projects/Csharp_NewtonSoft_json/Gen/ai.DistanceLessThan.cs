
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using Newtonsoft.Json.Linq;



namespace cfg.ai
{

public sealed partial class DistanceLessThan : ai.Decorator
{
    public DistanceLessThan(JToken _buf)  : base(_buf) 
    {
        JObject _obj = _buf as JObject;
        Actor1Key = (string)_obj.GetValue("actor1_key");
        Actor2Key = (string)_obj.GetValue("actor2_key");
        Distance = (float)_obj.GetValue("distance");
        ReverseResult = (bool)_obj.GetValue("reverse_result");
    }

    public static DistanceLessThan DeserializeDistanceLessThan(JToken _buf)
    {
        return new ai.DistanceLessThan(_buf);
    }

    public readonly string Actor1Key;
    public readonly string Actor2Key;
    public readonly float Distance;
    public readonly bool ReverseResult;


    public const int __ID__ = -1207170283;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "flowAbortMode:" + FlowAbortMode + ","
        + "actor1Key:" + Actor1Key + ","
        + "actor2Key:" + Actor2Key + ","
        + "distance:" + Distance + ","
        + "reverseResult:" + ReverseResult + ","
        + "}";
    }
}
}
