using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class TimeCount : MonoBehaviour
{

    /// <summary>
    /// 時間を計測するカウント
    /// </summary>
    public float TimeUpdateCounts { get; private set;  } = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
   public virtual void Update()
    {
        TimeUpdateCounts += Time.deltaTime;
    }
    public string GetTimeDecimal(float timeCounts, int decimalPlace)
    {
        var secondsTxt = timeCounts.ToString($"F{decimalPlace}");
        return secondsTxt;

    }


}