using System;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public static event Action OnAddScore;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnAddScore?.Invoke();
            Debug.Log("OnAddScore event invoked!");
        }
    }
}
