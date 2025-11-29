using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Bullet bullet = other.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.Interact(this);
        }
    }
}
