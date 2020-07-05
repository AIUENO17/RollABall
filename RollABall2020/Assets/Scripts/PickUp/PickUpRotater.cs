using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotater : MonoBehaviour
{
    private Transform m_pickUpTransform = null;
    // Start is called before the first frame update
  private void Start()
    {
        m_pickUpTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        m_pickUpTransform.Rotate(0, 1, 0, Space.Self);
    }
}
