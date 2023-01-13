using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : ActorController
{
    [SerializeField] private float speed = 0.2f;
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);

        }

    }
}
