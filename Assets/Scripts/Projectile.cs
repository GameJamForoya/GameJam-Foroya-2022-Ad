
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    private void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
