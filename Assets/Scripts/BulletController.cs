using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _damage = 1f;
    [SerializeField] private float _lifeDuration = 2f;


    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * _speed;
        //pour gérer le temps de vie de la bullet 
        Destroy(gameObjet, _lifeDuration);
    }

    
    private void OneCollisionEnter(Collision collision)
    {
        if (collision.gameObjet.GetComponentInParent<BaseController>() != null)
        {

        }
            collision.gameObject.GetComponent<BaseController>().ApplyDamage(_damage);
    }
    Destroy(gameObject);
}

