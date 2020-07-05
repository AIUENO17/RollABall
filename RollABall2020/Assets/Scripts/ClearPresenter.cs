using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearPresenter : MonoBehaviour
{
    [SerializeField] private Text m_clearText = null;
    [SerializeField] private PiackUpCountPresenter m_pickUpPresenter = null; 
    // Start is called before the first frame update
   private void Start()
    {
        m_clearText.text = string.Empty;
    }

    // Update is called once per frame

    void Update()
    {
        if (m_pickUpPresenter.GetPickUpCount.Equals(12))
        {
            m_clearText.text = "クリアー";
        }
    }
    
}
