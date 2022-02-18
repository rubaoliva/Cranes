using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruaBrazoControler : MonoBehaviour
{
    private GruaBrazoControls gruaBrazoControls;
    [SerializeField]
    private float speed;

    private void Awake()
    {
        gruaBrazoControls = new GruaBrazoControls();
    }

    private void OnEnable()
    {
        gruaBrazoControls.Enable();
    }
    private void OnDisable()
    {
        gruaBrazoControls.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 move = playerControls.Land.Move.ReadValue<Vector2>();
        // Debug.Log(move);
        float rotateR = gruaBrazoControls.Land.RotateR.ReadValue<float>();
        float rotateL = gruaBrazoControls.Land.RotateL.ReadValue<float>();
        
        if (rotateR > 0)                                                                                        //Rota la grua en el sentido de las agujas del reloj
        {
            transform.Rotate(xAngle: 0, yAngle: (rotateR * speed) * Time.deltaTime, zAngle: 0);
        }
        else if ((rotateL > 0))                                                                                 //Rota la grua en el sentido contrario de las agujas del reloj
        {
            transform.Rotate(xAngle: 0, yAngle: (-rotateL * speed) * Time.deltaTime, zAngle: 0);
        }
    }
}
