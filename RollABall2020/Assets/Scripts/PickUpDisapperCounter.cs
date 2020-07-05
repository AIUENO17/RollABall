using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class PickUpDisapperCounter : MonoBehaviour
{
    public int DissapperCount { get; private set; } = 0;

    [SerializeField] private ColliderReceiveAction m_colliderReceiveAction = null;
    
    private PickUpDisposition m_pickUpDisposition = null;

    private void Start()
    {
        m_pickUpDisposition = GetComponent<PickUpDisposition>();
        switch ( m_pickUpDisposition.m_pickUpDisposition)
        {
            case PickUpDisposition.publicPickUpDisposition.None:
                DissapperCount = 1;
                break;
            case PickUpDisposition.publicPickUpDisposition.SpeedUp:
                DissapperCount = 2;
                break;
            case PickUpDisposition.publicPickUpDisposition.SpeedDown:
                DissapperCount = 3;
                break;
            case PickUpDisposition.publicPickUpDisposition.QTE:
                DissapperCount = 10;
                break;

        }
    }
    private void Update()
    {
        if (m_colliderReceiveAction == null)
        {
            return;
        }

        if (m_colliderReceiveAction.IsTriggerEnter)
        {
            DissapperCount++;
            PiackUpCountPresenter.CountDisplay(DissapperCount);
        }


    }
}

