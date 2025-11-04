using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnFall()
    {
        rb.linearVelocity = Vector2.down * 10.0f;
    }
    void OnMove(InputValue input)
    {
        Vector2 force = input.Get<Vector2>();
        rb.linearVelocity = 5.0f * force;
    }
}
