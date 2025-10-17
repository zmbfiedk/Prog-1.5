// MoveFrontBackSteering.cs
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 6f;       
    [SerializeField] private float rotationSpeed = 120f;  

    private float moveInput;
    private float turnInput;

    void Update()
    {
        moveInput = Input.GetAxis("Vertical"); 

        turnInput = Input.GetAxis("Horizontal");

        Vector3 move = transform.forward * moveInput * moveSpeed * Time.deltaTime;
        transform.position += move;

        float turn = turnInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, turn, 0f);
    }
}
