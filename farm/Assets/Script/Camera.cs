using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Vector3 oldMousePosition;

    

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            FuncionMoverCamara();

        }
        oldMousePosition = Input.mousePosition;
    }

    void FuncionMoverCamara()
    {

        Vector3 deltapos = oldMousePosition - Input.mousePosition;
        Camera.main.transform.position += new Vector3(deltapos.x, 0.0f, deltapos.y);

    }
    
}

