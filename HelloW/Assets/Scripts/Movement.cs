using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float speed = 0.1f;
    [SerializeField] private float rotSpeed = 0.1f;
    [SerializeField] private float JumpPower = 1f;
    [SerializeField] private float GroundCheckDistance = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {  
        transform.position += transform.forward * Input.GetAxis("Vertical") * speed;
        transform.Rotate(0, rotSpeed* Input.GetAxis("Horizontal"), 0);
        if(Input.GetButtonDown("Jump")&&isGrounded())
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0, 100, 0)*JumpPower);
        }
        
    }

    bool isGrounded()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, GroundCheckDistance))
        {
            return true;
        }
       return false;
    }
}
