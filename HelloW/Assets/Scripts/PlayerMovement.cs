using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 10f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector3(xMove, rb.linearVelocity.y, zMove) * Speed;
    }


}

