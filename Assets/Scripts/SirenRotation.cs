using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    [Header("Configuración de la Sirena")]
    public float rotationSpeed = 250f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}