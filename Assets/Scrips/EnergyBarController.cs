using UnityEngine;
using UnityEngine.UI;

public class EnergyBarController : MonoBehaviour
{
    public float maxEnergy = 100f;
    public float currentEnergy = 100f;
    public RectTransform energyBarRect;
    public float maxWidth = 300f;

    public float regenRate = 10f; // Energía recuperada por segundo
    private bool isUsingEnergy = false;

    void Update()
    {
        // Presiona R para gastar energía
        if (Input.GetKeyDown(KeyCode.R))
        {
            UseEnergy(10f);
        }

        // Recuperar energía automáticamente si no está llena
        if (currentEnergy < maxEnergy)
        {
            RegenerateEnergy();
        }
    }

    void RegenerateEnergy()
    {
        currentEnergy += regenRate * Time.deltaTime;
        currentEnergy = Mathf.Min(currentEnergy, maxEnergy);
        UpdateEnergyBar();
    }

    public void UseEnergy(float amount)
    {
        currentEnergy = Mathf.Max(currentEnergy - amount, 0);
        UpdateEnergyBar();
    }

    void UpdateEnergyBar()
    {
        float energyPercent = currentEnergy / maxEnergy;
        float newWidth = energyPercent * maxWidth;
        energyBarRect.sizeDelta = new Vector2(newWidth, energyBarRect.sizeDelta.y);
    }
}
