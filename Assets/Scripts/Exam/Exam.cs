using UnityEngine;

public class Exam : MonoBehaviour
{
    public interface IDamageable { void TakeDamage(int amount); }
    public abstract class Projectile : MonoBehaviour 
    { public abstract void OnHit(GameObject target); }

    public class Bullet : Projectile, IDamageable
    {
        public override void OnHit(GameObject target)
        {
            /* Implementation */
            Debug.Log("OnHit implementation");
        }

        public void TakeDamage(int amount)
        {
            /* Implementation */
            Debug.Log("TakeDamage implementation");
        }
    }

}
