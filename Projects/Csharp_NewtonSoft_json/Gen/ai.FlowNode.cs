
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

public abstract partial class FlowNode : ai.Node
{
    public FlowNode(JToken _buf)  : base(_buf) 
    {
        JObject _obj = _buf as JObject;
        { var __json0 = _obj.GetValue("decorators"); Decorators = new System.Collections.Generic.List<ai.Decorator>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { ai.Decorator __v0;  __v0 = ai.Decorator.DeserializeDecorator(__e0);  Decorators.Add(__v0); }   }
        { var __json0 = _obj.GetValue("services"); Services = new System.Collections.Generic.List<ai.Service>((__json0 as JArray).Count); foreach(JToken __e0 in __json0) { ai.Service __v0;  __v0 = ai.Service.DeserializeService(__e0);  Services.Add(__v0); }   }
    }

    public static FlowNode DeserializeFlowNode(JToken _buf)
    {
        var _obj=_buf as JObject;
        switch (_obj.GetValue("$type").ToString())
        {
            case "Sequence": return new ai.Sequence(_buf);
            case "Selector": return new ai.Selector(_buf);
            case "SimpleParallel": return new ai.SimpleParallel(_buf);
            case "UeWait": return new ai.UeWait(_buf);
            case "UeWaitBlackboardTime": return new ai.UeWaitBlackboardTime(_buf);
            case "MoveToTarget": return new ai.MoveToTarget(_buf);
            case "ChooseSkill": return new ai.ChooseSkill(_buf);
            case "MoveToRandomLocation": return new ai.MoveToRandomLocation(_buf);
            case "MoveToLocation": return new ai.MoveToLocation(_buf);
            case "DebugPrint": return new ai.DebugPrint(_buf);
            default: throw new SerializationException();
        }
    }

    public readonly System.Collections.Generic.List<ai.Decorator> Decorators;
    public readonly System.Collections.Generic.List<ai.Service> Services;



    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        foreach (var _e in Decorators) { _e?.ResolveRef(tables); }
        foreach (var _e in Services) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + Luban.StringUtil.CollectionToString(Decorators) + ","
        + "services:" + Luban.StringUtil.CollectionToString(Services) + ","
        + "}";
    }
}
}
