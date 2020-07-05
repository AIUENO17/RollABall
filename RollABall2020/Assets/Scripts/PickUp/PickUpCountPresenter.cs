using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpCountPresenter : MonoBehaviour
{
    [SerializeField] private Text m_pickupCountText = null;
    private static int m_CpickUpCounter = 0;
    public int GetPickUpCount
    {
        get { return m_CpickUpCounter; }
    }
    private void Update()
    {
        m_pickupCountText.text = $"{m_CpickUpCounter}";
    }

    public static void CountDisplay(int dissapearCount)
    {
        m_CpickUpCounter += dissapearCount;
    }


}
