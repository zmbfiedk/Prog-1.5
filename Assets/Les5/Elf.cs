using UnityEngine;
using System.Collections;

public class Elf : EnemyParent
{
    private Renderer rend;

    void Start()
    {
        health = 2f;   // weinig levens
        moveSpeed = 5f; // snel
        rend = GetComponent<Renderer>();

        StartCoroutine(ToggleVisibility());
        Move();
        if(health <= 0)
        {
            Debug.Log("Elf died!");
            Die();
        }
    }

    IEnumerator ToggleVisibility()
    {
        while (health > 0)
        {
            yield return new WaitForSeconds(3f);
            if (rend != null)
            {
                rend.enabled = false;
            }
            yield return new WaitForSeconds(0.5f);
            if (rend != null)
            {
                rend.enabled = true;
            }
        }
    }

}
