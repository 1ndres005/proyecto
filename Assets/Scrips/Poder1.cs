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
            GameObject bomb = Instantiate(magicBombPrefab, firePoint.position, Quaternion.identity);
            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            rb.linearVelocity = (transform.forward + Vector3.up * 0.5f) * launchForce;
        }
    }
}

