using UnityEngine;

public class ArrowRotate : MonoBehaviour
{
    Rigidbody rb;
    Vector3 m_EulerAngleVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, 100, 0);
    }

    void Update()
    {
        bool RightArrow = Input.GetKey(KeyCode.RightArrow);
        bool LeftArrow = Input.GetKey(KeyCode.LeftArrow);
        float neg = -1f;
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        if(RightArrow == true)
        {
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        
    }
}
