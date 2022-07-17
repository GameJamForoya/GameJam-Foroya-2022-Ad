using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
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
        Debug.Log("Hellp;asd");
        var animator = other.GetComponent<Animator>();
        animator.SetTrigger(Damage);
        
        gameObject.SetActive(false);
    }
}
