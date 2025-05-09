using UnityEngine;

public class Stat
{
    public int MaxValue { get; private set; }
    public int MinValue { get; private set; }
    public int CurrentValue { get; private set; }
    public Stat(int min, int max)
        {
            MinValue = min;
            MaxValue = max;
            CurrentValue = max;
        }

    public void AffectValue(int amount)
        {
            CurrentValue = Mathf.Clamp(CurrentValue + amount, MinValue, MaxValue);
        }

    public enum FlowType  // tipo de carga del recurso
        {
            Time,
            Instant
        }

}
