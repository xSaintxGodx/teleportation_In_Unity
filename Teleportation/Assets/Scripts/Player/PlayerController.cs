using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 mousePos;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            Teleportation();
    }
    public void Teleportation () 
    {
        transform.position = GetMousePosition ();
    }

    public Vector3 GetMousePosition () {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint (mousePos);

        return mousePos;
    }
}
