using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDisposition : MonoBehaviour
{
    public enum publicPickUpDisposition
    {
        None = 0,
        SpeedUp,
        SpeedDown,
        QTE,
        DispositionMax
    }
            public publicPickUpDisposition m_pickUpDisposition = publicPickUpDisposition.None;
    private void Awake()
    {
        var randomDisposition = 0;
        randomDisposition = Random.Range((int)publicPickUpDisposition.None, (int)publicPickUpDisposition.DispositionMax);

        m_pickUpDisposition = (publicPickUpDisposition)randomDisposition;
 
        
    }
}

