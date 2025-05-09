using UnityEngine;
using static Stat;

public class Jugador : MonoBehaviour, IDamageable
{
    public Stat Life { get; private set; }
    public Mana Mana { get; private set; }
    // public AbilitySystem AbilitySystem { get; private set; } pendiente conección con el sistema de habilidad

    private void Awake()
    {
        Life = new Stat(0, 100);
        Mana = new Mana(0, 100, FlowType.Time);
        // AbilitySystem = new AbilitySystem(); pendiente conección con el sistema de habilidad
    }

    public void Damage(int amount)
    {
        Life.AffectValue(-amount);
    }
}
