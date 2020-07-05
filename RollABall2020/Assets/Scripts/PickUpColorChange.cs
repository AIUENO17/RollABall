using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class PickUpColorChange : MonoBehaviour
{
    private PickUpDisposition m_pickUpDisposition = null;

    private Color SpeedUpColor = Color.red;
    private Color SpeedDownColor = Color.blue;
    private Color QTEColor = Color.magenta;

    // Start is called before the first frame update
    void Start()
    {
        m_pickUpDisposition = GetComponent<PickUpDisposition>();

        var mat = GetComponent<MeshRenderer>().material;

        switch (m_pickUpDisposition.m_pickUpDisposition)
        {
            case PickUpDisposition.publicPickUpDisposition.SpeedUp:
                mat.color = SpeedUpColor;
                break;
            case PickUpDisposition.publicPickUpDisposition.SpeedDown:
                mat.color = SpeedDownColor;
                break;

            case PickUpDisposition.publicPickUpDisposition.QTE:
                mat.color = QTEColor;
                break;

        }
    }
}

    
