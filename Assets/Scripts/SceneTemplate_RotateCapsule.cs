using UnityEngine;

public class SceneTemplate_RotateCapsule : MonoBehaviour
{
    [Header("Paramètres de rotation")]
    [Tooltip("Vitesse de rotation en degrés par seconde")]
    public float rotationSpeed = 50f;

    [Tooltip("Axe de rotation (X, Y, Z)")]
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        // Applique la rotation chaque frame
        // On multiplie par Time.deltaTime pour que la rotation soit fluide et indépendante du framerate
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
