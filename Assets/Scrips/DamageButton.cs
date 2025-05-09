using UnityEngine;

public class DamageButton : MonoBehaviour
{
    public float damageAmount = 10f;  // Cantidad de daño que se aplica
    private HealthBarController healthBarController;

    void Start()
    {
        // Buscar el script que maneja la barra de salud
        healthBarController = FindObjectOfType<HealthBarController>();
    }

    void Update()
    {
        // Detectar cuando se presiona la tecla "I"
        if (Input.GetKeyDown(KeyCode.I))
        {
            ApplyDamage();  // Llama a la función que aplica el daño
        }
    }

    // Función que aplica el daño al personaje
    void ApplyDamage()
    {
        if (healthBarController != null)
        {
            healthBarController.TakeDamage(damageAmount);  // Aplica el daño
            Debug.Log("Daño aplicado: " + damageAmount);  // Muestra un mensaje en la consola
        }
    }
}