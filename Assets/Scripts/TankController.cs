using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TankController : BaseController
{
    //----déclaration des variables--------//
    //speed
    [SerializeField] private float backwardSpeed = 10f;
    [SerializeField] private float forwardSpeed = 10f;

    [SerializeField] private float angleSpeed = 10f;


    void Update()
    {
        Move();
    }
    //fonction déplacement le tank
    void Move()
    {

        if
            (Input.GetKey(KeyCode. UpArrow) || Input.GetKey(KeyCode.Z))
        {//avancer , reculer
            transform.Translate(0f, 0f, forwardSpeed * Time.deltaTime);
        }
        else if 

            (Input.GetKey(KeyCode. DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, backwardSpeed * Time.deltaTime);
        }
        // rotate
        if
            (Input.GetKey(KeyCode. RightArrow) || Input.GetKey(KeyCode.D))
        {//avancer , reculer
            transform.Rotate(0f, 0f, angleSpeed * Time.deltaTime);
        }
        else if

            (Input.GetKey(KeyCode. LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, angleSpeed * Time.deltaTime);
        }

    }
        
        
    }
    //void Fire()
    //{
       
    //}
}


