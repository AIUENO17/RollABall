using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTEPresenter : MonoBehaviour
{
    [SerializeField] private Text m_QTEText = null;
    [SerializeField] private Text m_QTETimeLimitText = null;
    [SerializeField] private InputField m_QTEInputField = null;
    [SerializeField] private float m_timeLimit = 5f;
    [SerializeField] private string m_theme = "SUSHI";

    public SphereDamage SphereDamage = null;

    public enum QTEStates
    {
        OFF = 0,
        ON,
        Input,
        Result,
    }

    public QTEStates QTESPresenterStates = QTEStates.OFF;

    private void Start()
    {
        SetQTEObject(false);
    }


    private void Update()
    {
        switch (QTESPresenterStates)
        {
            case QTEStates.OFF:
                return;

            case QTEStates.ON:

                Time.timeScale = 0f;
                m_timeLimit = 5f;
                SetQTEObject(true);

                m_QTEText.text = $" {m_theme}と入力しろ!";
                m_QTEInputField.text = string.Empty;

                QTESPresenterStates = QTEStates.Input;
                break;

            case QTEStates.Input:

                m_timeLimit -= Time.unscaledDeltaTime;

                m_QTETimeLimitText.text = $"{ m_timeLimit}";

                if (m_timeLimit < 0)
                {
                    QTESPresenterStates = QTEStates.Result;
                }
                break;

            case QTEStates.Result:

                if (m_QTEInputField.text.Equals(m_theme))
                {
                    SphereDamage.AddSphereDamage(-5);
                }
                else
                {
                    SphereDamage.AddSphereDamage(2);



                }

                SetQTEObject(false);

                Time.timeScale = 1f;
                QTESPresenterStates = QTEStates.OFF;
                break;

        }


       
    }
    private void SetQTEObject(bool active)
    {
        m_QTEText.gameObject.SetActive(active);
        m_QTETimeLimitText.gameObject.SetActive(active);
        m_QTEInputField.gameObject.SetActive(active);

    }

}

