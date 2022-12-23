using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : BaseController
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float _detectionRange = 10f;

    private void Update()
    {
        RotateHeadTo(AimToTarget());
    }

    private Vector3 AimToTarget()
    {
        RaycastHit hit;
        Vector3 targetPos= new Vector3(_target.transform.position.x, _head.transform.position.y,_target.transform.position.z);
        Vector3 direction = targetPos - _head.transform.position;
        Debug.DrawRay(_head.transform.position, direction*20f, Color.red);
        if(Physics.Raycast(_head.transform.position, direction, out hit, _detectionRange))
        {
            if (hit .collider.GetComponentInParent<TankController>() != null)
            {
                return hit.point;
            }
        }
        return Vector3.zero;
    }
}
