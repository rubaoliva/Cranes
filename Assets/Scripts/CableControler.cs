using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableControler : MonoBehaviour
{
    private CableMovilControls cableMovilControls;
    [SerializeField]
    private float speed;

    private void Awake()
    {
        cableMovilControls = new CableMovilControls();
    }

    private void OnEnable()
    {
        cableMovilControls.Enable();
    }
    private void OnDisable()
    {
        cableMovilControls.Disable();
    }

    void Update()
    {
        float moveFront = cableMovilControls.Land.MoveFront.ReadValue<float>();
        float moveBack = cableMovilControls.Land.MoveBack.ReadValue<float>();
        float moveUp = cableMovilControls.Land.MoveUp.ReadValue<float>();
        float moveDown = cableMovilControls.Land.MoveDown.ReadValue<float>();
        float cablePosition = transform.localPosition.x;

        Debug.Log(cablePosition);

        if (moveFront > 0 && transform.localPosition.x < 7.6)                            // Mueve el cable de la grua hacia la zona más alejada de la torre
        {
            
            transform.Translate(x: moveFront * Time.deltaTime, y: 0, z: 0);
           
        }
        else if (moveBack > 0 && transform.localPosition.x > 2)                         // Mueve el cable de la grua hacia la zona más cercana de la torre
        {
            transform.Translate(x: -moveBack  * Time.deltaTime, y: 0, z: 0);
        }
        else if (moveUp > 0 && transform.localScale.y > 0.10)                           // Recoge cable hacia arriba
        {
            Vector3 scale = transform.localScale;
            transform.localScale = new Vector3(1, scale.y + (-speed * Time.deltaTime), 1);
        }
        else if (moveDown > 0)                                                          //Suelta cable hacia abajo
        {
            Vector3 scale = transform.localScale;
            transform.localScale = new Vector3(1, scale.y + (speed * Time.deltaTime), 1);
        }
    }
}
