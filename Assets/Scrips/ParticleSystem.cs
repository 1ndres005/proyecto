using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public float damagePerSecond = 10f;
    public float duration = 5f;

    void Start()
    {
        Destroy(gameObject, duration);  // Se destruye sola tras 5 seg.
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))  // Puedes usar otra etiqueta
        {
            // Aquí haces daño continuo al jugador
            Debug.Log("Dañando a: " + other.name);
            // Ejemplo real: other.GetComponent<Health>().TakeDamage(damagePerSecond * Time.deltaTime);
        }
    }
}