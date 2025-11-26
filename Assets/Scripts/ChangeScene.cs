using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangingScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
