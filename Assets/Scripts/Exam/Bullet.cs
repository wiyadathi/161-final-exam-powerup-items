using UnityEngine;

public class Bullet : Projectile, IDamageable
{
    public void TakeDamage(int amount)
    {
        throw new System.NotImplementedException();
    }

    public void Interact(Projectile p) { }
}
