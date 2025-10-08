using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float health = 3f;
    public float moveSpeed = 2f;

    private Vector3 direction = Vector3.right;

    void Update()
    {
        Move();
    }

    protected void Move()
    {
        if (health > 0)
        {
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            TakeDamage(1f);
            Destroy(other.gameObject);
        }
    }
}
