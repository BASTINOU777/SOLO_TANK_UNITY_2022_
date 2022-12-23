using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    [SerializeField] protected GameObject _head;
    [SerializeField] protected int _LifePoint = 1;
    [SerializeField] protected int DelayValue = 2;
   



    protected bool Fire()
    {
        if {

        }
    }
   
    
    private void RotateHeadTo()
       {
            Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);
           //yield return obligatoire : durée fixe de 2s
            yield return new WaitForSeconds(DelayValue);

        }
    IEnumerator FireWithDelay()
    {

    }



    private void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(BulletSpawnPosition.transform.position,BulletSpawnPosition.transform.up,out hit))
        {
            Debug.DrawRay(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up * 20f);
            Fire();
        }
    }
    private void ApplyDamage(int damage)
    {
        _LifePoint = _LifePoint - damage;
        if(_LifePoint <= 0)
        {
            Destruction(gameObject);
        }
    }
    private void Destruction()
    {
        Destruction(gameObject);
    }
}
