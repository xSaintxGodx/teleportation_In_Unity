using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 mousePos;
    void Start()
    {
        
    }

    void Update()
    {
        Teleporte();
    }
    private void Teleporte()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = MousePosition();
        }

    }

    Vector2 MousePosition()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        return mousePos;
    }
}
