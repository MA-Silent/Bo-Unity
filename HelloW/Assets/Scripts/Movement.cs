using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private float rotSpeed = 0.1f;
    [SerializeField] private float JumpPower = 1f;
    [SerializeField] private float GroundCheckDistance = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        

        transform.position += transform.forward * Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Rotate(0, rotSpeed* Input.GetAxisRaw("Horizontal") * Time.deltaTime, 0);
        if(Input.GetButtonDown("Jump"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0, 210, 0)*JumpPower);
            _animator.SetFloat("Jump", 1);
        }
        else
        {
            _animator.SetFloat("Jump", 0);
        }
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            _animator.SetFloat("speed", 1);
        }
        else
        {
            _animator.SetFloat("speed", 0.1f);
        }
        


    }

    bool isGrounded()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit,GroundCheckDistance))
        {
            return true;
        }
        return false;
    }
}
