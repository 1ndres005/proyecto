using UnityEngine;

public class Mana : Stat
{
    public FlowType NewFlowType { get; private set; }

    public Mana(int min, int max, FlowType flowType) : base(min, max)
    {
        NewFlowType = flowType;
    }
}
