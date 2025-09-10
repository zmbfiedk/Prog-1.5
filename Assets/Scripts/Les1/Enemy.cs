using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
