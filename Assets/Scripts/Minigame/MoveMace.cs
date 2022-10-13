using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveMace : MonoBehaviour
{
    public float topLimit, bottomLimit;
    public float speed;
    Vector3 currentPos;
    // Start is called before the first frame update
    
    private void FixedUpdate()
    {
        currentPos = transform.position;
        currentPos.y += speed;
        if (currentPos.y >= topLimit || currentPos.y <= bottomLimit)
        {
            changeDirection();
        }
        transform.position = currentPos;
    }

    private void changeDirection()
    {
        speed *= -1;
    }



}
