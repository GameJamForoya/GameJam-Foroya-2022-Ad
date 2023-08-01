using UnityEngine;

public class BasicRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1f;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(Vector3.forward * (rotationSpeed * Time.deltaTime));
    }
}