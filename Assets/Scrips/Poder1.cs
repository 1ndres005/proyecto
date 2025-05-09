using UnityEngine;

public class Poder1 : MonoBehaviour
{
    public GameObject magicBombPrefab;
    public Transform firePoint;
    public float launchForce = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject bomb = Instantiate(magicBombPrefab, firePoint.position, Camera.main.transform.rotation);
            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            rb.linearVelocity = (bomb.transform.forward + Vector3.up*0.5f) * launchForce;
        }
    }
}

