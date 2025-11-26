using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public Text _countdowText;
    float countDownDelay = 0.75f;

    public IEnumerator CountDelay()
    {
        for (int i = 5; i >= 0; i--)
        {
            _countdowText.text = i.ToString();
            
            if(i <= 0)
            {
                Debug.Log("Contador completado");
                //Pequeño delay en el 0 antes de cambiar de escena
                yield return new WaitForSeconds(countDownDelay);
                ChangeScene.Instance.ChangingScene();
            }

            yield return new WaitForSeconds(countDownDelay);
        }
    }
}
