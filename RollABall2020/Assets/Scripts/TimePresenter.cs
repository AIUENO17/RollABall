using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePresenter : TimeCount
{
    [SerializeField] private Text m_timeText = null;
    // Start is called before the first frame update
    
    //秒数の下の桁数
    public enum TimeDecimalPlace
    {
        None = 0,
        DecimalOne,
        DecimalTwo

    }

    public TimeDecimalPlace timeDecimal = TimePresenter.TimeDecimalPlace.None;
   
    //Update is called once per frame
   
    
    public override void Update()
    {
        base.Update();
        m_timeText.text = GetTimeDecimal(TimeUpdateCounts, (int)timeDecimal);

        






    }

}
