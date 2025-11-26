using UnityEngine;
using UnityEngine.InputSystem;

public class RayCast : MonoBehaviour
{
    private InputAction _clickAction;
    private InputAction _mouseAction;
    private Vector2 _mousePosition;

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

        if(_clickAction.WasPressedThisFrame())
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
            if(hit.transform.gameObject.CompareTag("Cubo 1"))
            {
                Debug.Log("Has clicado cubo 1");
                Debug.Log("Cambio a escena 1");
            }
            
            if(hit.transform.gameObject.CompareTag("Esfera"))
            {
                Debug.Log("Has clicado esfera");
                Debug.Log("Cambio a escena 3");
            }

            if(hit.transform.gameObject.CompareTag("Cubo 2"))
            {
                Debug.Log("Has clicado cubo 2");
                Debug.Log("Cambio a escena 3");
            }
        }
    }
}
