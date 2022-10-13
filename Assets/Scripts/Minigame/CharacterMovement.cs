using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{
    public float maxVel = 10f;
    public float maxJump = 5f;
    float lastTimeJumped;
    Rigidbody2D rb2d;
    Vector2 force;
    float horizontalMovement, verticalMovement;
    public CheckFloor checkFloor;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        lastTimeJumped = 100;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
        if(verticalMovement > 0)
        {
            if (checkFloor.isTouchingFloor && lastTimeJumped > 0.10)
            {
                Debug.Log("Character jumped");
                force = new Vector2(0, maxJump);
                rb2d.AddForce(force, ForceMode2D.Impulse);
                lastTimeJumped = 0;
            }
            lastTimeJumped += Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        force = new Vector2(horizontalMovement * maxVel, 0);
        rb2d.AddForce(force * Time.fixedDeltaTime, ForceMode2D.Impulse);

    }



    
}
