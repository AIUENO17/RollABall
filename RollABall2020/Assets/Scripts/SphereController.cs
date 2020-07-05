using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    private Rigidbody m_sphereRigidBody;

    private Vector3 m_inputAxis = Vector3.zero;

    // Start is called before the first frame update

    //玉の加速度
    public float SphereAcceleration = 1.0f;

    void Start()
    {
        m_sphereRigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        m_inputAxis.Set(Input.GetAxis("Horizontal") * SphereAcceleration, 0, Input.GetAxis("Vertical") * SphereAcceleration);
       m_sphereRigidBody.AddForce(m_inputAxis);
        
        
    }
}
