using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZeptoBt;

public class NodeLeafDemoLog : NodeLeaf
{
    public override string[] Params
    {
        get => base.Params;
        set
        {
            base.Params = value;

            if (base.Params.Length > 0)
            {
                prefix = base.Params[0];
            }
        }
    }

    string prefix = "base prefix";

    public override void Tick()
    {
        Debug.Log($"Demo tick from - {prefix}");
        Status = NodeReturn.Success;
    }

    public override string ToString()
    {
        return $"NODE LEAF DEMO LOG {Index}";
    }
}
