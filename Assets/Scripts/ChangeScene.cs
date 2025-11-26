using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static ChangeScene Instance {get; private set;}
    public int sceneNumber;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        if(Instance != null && this != null)
        {
            Destroy(gameObject);
        }
    }

    public void ChangingScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
