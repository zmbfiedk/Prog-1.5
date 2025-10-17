using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinPickup : MonoBehaviour
{

    public static event Action OnAddScore;

    void Start()
    {
        
    }



    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OnAddScore?.Invoke();
            Destroy(gameObject);
        }
    }
}
