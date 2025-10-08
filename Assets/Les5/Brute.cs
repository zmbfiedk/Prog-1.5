using UnityEngine;

public class Brute : EnemyParent
{
    void Start()
    {
        health = 10f;   // extra veel levens
        moveSpeed = 1f; // langzaam
        Move();
        if(health <= 0)
        {
            Debug.Log("Brute died!");
            Die();
        }
    }

}
