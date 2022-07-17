using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectile;


    public void Shoot()
    {
        var trans = transform;
        Instantiate(projectile, trans.position, trans.rotation);
    }
}
