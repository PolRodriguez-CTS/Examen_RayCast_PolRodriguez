using UnityEngine;
using UnityEngine.InputSystem;

public class RayCast : MonoBehaviour
{
    private InputAction _clickAction;
    private InputAction _mouseAction;
    private Vector2 _mousePosition;
    private bool _isCounting = false;

    void Awake()
    {
        _clickAction = InputSystem.actions["Click"];
        _mouseAction = InputSystem.actions["RayCast"];
    }


    void Start()
    {
        
    }

    void Update()
    {
        _mousePosition = _mouseAction.ReadValue<Vector2>();

        if(_clickAction.WasPressedThisFrame() && !_isCounting)
        {
            Debug.Log("Click");
            ShootRaycast();
        }
    }

    void ShootRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(_mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        { 
            Countdown _countdownScript = FindAnyObjectByType<Countdown>().GetComponent<Countdown>();  
            
            if(hit.transform.gameObject.CompareTag("Cubo 1"))
            {
                _isCounting = true;
                ChangeScene.Instance.sceneNumber = 0;

                Debug.Log("Cubo1, escena 1");

                //Empieza contador
                //Countdown _countdownScript = FindAnyObjectByType<Countdown>().GetComponent<Countdown>();
                StartCoroutine(_countdownScript.CountDelay());
            }
            
            if(hit.transform.gameObject.CompareTag("Esfera"))
            {
                _isCounting = true;
                ChangeScene.Instance.sceneNumber = 1;

                Debug.Log("Esfera, escena 2");

                //Empieza contador
                //Countdown _countdownScript = FindAnyObjectByType<Countdown>().GetComponent<Countdown>();
                StartCoroutine(_countdownScript.CountDelay());
            }

            if(hit.transform.gameObject.CompareTag("Cubo 2"))
            {
                _isCounting = true;
                ChangeScene.Instance.sceneNumber = 2;

                Debug.Log("Cubo2, escena 3");
                
                //Empieza contador
                //Countdown _countdownScript = FindAnyObjectByType<Countdown>().GetComponent<Countdown>();
                StartCoroutine(_countdownScript.CountDelay());
            }
        }
    }
}
