using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text _countdowText;
    //float i = 5;

    float countDownDelay = 0.5f;

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        SetCountDown();
    }

    void SetCountDown()
    {
        for (int i = 5; i >= 0; i--)
        {
            _countdowText.text = i.ToString();
            
            if(i >= 0)
            {
                
                Debug.Log("Contador completado");
            }
            StartCoroutine(CountDelay());
        }
    }

    IEnumerator CountDelay()
    {
        yield return new WaitForSeconds(countDownDelay);
    }
}
