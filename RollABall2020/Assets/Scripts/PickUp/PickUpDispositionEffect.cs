using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class PickUpDispositionEffect : MonoBehaviour
{
    private PickUpDisposition m_pickUpDisposition = null;

    private QTEPresenter m_QTEPresenter = null;

    private void Start()
    {
        m_pickUpDisposition = GetComponent<PickUpDisposition>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DispositionEffect(other);

        }
    }
    private void DispositionEffect(Collider other)
    {
        var vec = Vector3.Normalize(transform.position - other.transform.position);

        switch (m_pickUpDisposition.m_pickUpDisposition)
        {
            case PickUpDisposition.publicPickUpDisposition.SpeedUp:
                other.GetComponent<Rigidbody>().AddForce(vec * 5f, ForceMode.Impulse);
                break;
            case PickUpDisposition.publicPickUpDisposition.SpeedDown:
                other.GetComponent<Rigidbody>().AddForce(vec * -100f, ForceMode.Acceleration);
                break;

            case PickUpDisposition.publicPickUpDisposition.QTE:
                if (m_QTEPresenter == null)
                {
                    m_QTEPresenter = GameObject.Find("Canvas").GetComponent<QTEPresenter>();
                   
                }
                m_QTEPresenter.SphereDamage = other.GetComponent<SphereDamage>();
                m_QTEPresenter.QTESPresenterStates = QTEPresenter.QTEStates.ON;
                break;
        }
    }
}
  
