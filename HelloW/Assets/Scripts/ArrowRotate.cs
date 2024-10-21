using UnityEngine;

public class ArrowRotate : MonoBehaviour
{
    Rigidbody rb;
    Vector3 m_EulerAngleVelocity;
    Vector3 Left;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, 100, 0);
        Left = new Vector3(0, -100, 0);
    }

    void Update()
    {
        bool RightArrow = Input.GetKey(KeyCode.RightArrow);
        bool LeftArrow = Input.GetKey(KeyCode.LeftArrow);
        Quaternion deltaRotationRight = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        Quaternion deltaRotationLeft = Quaternion.Euler(Left * Time.fixedDeltaTime);
        if (RightArrow == true)
        {
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }
        if (LeftArrow == true)
        {
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }

    }
}
