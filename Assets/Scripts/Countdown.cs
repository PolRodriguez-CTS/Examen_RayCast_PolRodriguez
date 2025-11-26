using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public Text _countdowText;
    float countDownDelay = 1f;

    /*public void SetCountDown()
    {
        StartCoroutine(CountDelay());
        for (int i = 5; i >= 0; i--)
        {
            _countdowText.text = i.ToString();
            
            if(i >= 0)
            {
                
                Debug.Log("Contador completado");
            }
            StartCoroutine(CountDelay());
        }
    }*/
    public void ChangingScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public IEnumerator CountDelay()
    {
        for (int i = 5; i >= 0; i--)
        {
            _countdowText.text = i.ToString();
            
            if(i <= 0)
            {
                Debug.Log("Contador completado");

            }

            yield return new WaitForSeconds(countDownDelay);
        }
    }
}
