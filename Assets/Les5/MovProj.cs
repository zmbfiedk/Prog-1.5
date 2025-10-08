using UnityEngine;

public class MoveProj : MonoBehaviour
{
    public float moveSpeed = 20f;

    void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
