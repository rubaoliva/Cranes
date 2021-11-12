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

        if (moveFront > 0)
        {
            transform.Translate(x: moveFront * Time.deltaTime, y: 0, z: 0);
        }
        else if (moveBack > 0)
        {
            transform.Translate(x: -moveBack  * Time.deltaTime, y: 0, z: 0);
        }
        else if (moveUp > 0)
        {
            Vector3 scale = transform.localScale;
            transform.localScale = new Vector3(1, scale.y + (-speed * Time.deltaTime), 1);
        }
        else if (moveDown > 0)
        {
            Vector3 scale = transform.localScale;
            transform.localScale = new Vector3(1, scale.y + (speed * Time.deltaTime), 1);
        }
        //Vector3 CablePosition = transform.localPosition;

        /*
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(x: (speed * Time.deltaTime), y: 0, z: 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(x: (-speed * Time.deltaTime), y: 0, z: 0);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            Vector3 v3Scale = transform.localScale;
            transform.localScale = new Vector3(1, v3Scale.y + (-cableSpeed * Time.deltaTime), 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 v3Scale = transform.localScale;
            transform.localScale = new Vector3(1, v3Scale.y + (cableSpeed * Time.deltaTime), 1);
        }
        */
    }
}
