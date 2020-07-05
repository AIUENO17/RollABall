using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAutoPlacement : MonoBehaviour
{
    [SerializeField] private GameObject m_pickUp;
    [SerializeField] private float m_radius = 5f;

    public Transform[] PickupTransforms = null;

    private void Start()
    {
        var pos = Vector3.zero;
        var defPos = GetComponent<Transform>().position;

        var radian = Mathf.PI * 2 / 12;
        pos.z += m_radius;
        PickupTransforms = new Transform[12];
        for (int i = 0; i < 12; i++)
        {
            var pickUp = Instantiate(m_pickUp);
            pos.z = Mathf.Cos(radian * i) * m_radius + defPos.z;
            pos.x = Mathf.Sin(radian * i) * m_radius + defPos.x;
            pos.y = defPos.y;
            pickUp.transform.position = pos;

            PickupTransforms[i] = pickUp.transform;
        }
    }
}

