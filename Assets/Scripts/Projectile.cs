using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private GameObject visual;
    [SerializeField] private ParticleSystem hit;

    private static readonly int Damage = Animator.StringToHash("damage");

    private void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var animator = other.GetComponent<Animator>();
        animator.SetTrigger(Damage);

        enabled = false;
        visual.SetActive(false);

        hit.Play();
    }
}
