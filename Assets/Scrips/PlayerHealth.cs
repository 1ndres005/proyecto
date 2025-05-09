using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public float maxHealth = 100f;   // Salud máxima
    private float currentHealth;     // Salud actual
    public Image healthBar;
    public RectTransform healthBarRect;  // Referencia al RectTransform de la barra
    public float maxWidth = 300f;   // Referencia a la barra de vida

    void Start()
    {
        currentHealth = maxHealth;  // Establece la salud inicial al máximo
    }

    // Método para recibir daño
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;  // Resta el daño de la salud
        if (currentHealth < 0) currentHealth = 0;  // Evita que la salud sea menor que 0
        UpdateHealthBar();  // Actualiza la barra de vida
    }

    // Método para curar
    public void Heal(float healing)
    {
        currentHealth += healing;  // Aumenta la salud
        if (currentHealth > maxHealth) currentHealth = maxHealth;  // Evita que la salud sea mayor que el máximo
        UpdateHealthBar();  // Actualiza la barra de vida
    }

 

void UpdateHealthBar()
    {
        float healthPercent = currentHealth / maxHealth;
        float newWidth = healthPercent * maxWidth;

        // Cambia el ancho de la barra de vida
        healthBarRect.sizeDelta = new Vector2(newWidth, healthBarRect.sizeDelta.y);
    }

}
