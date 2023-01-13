using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventScript : MonoBehaviour
{
    [SerializeField] private AudioClip _soundAieTurret;

    private void EventFunctionSound()
    {
       ;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.clip = _soundAieTurret;
        Debug.Log("started");
    }

    //inscription
    private void OnEnable()
    {
        ActorController.AieEvent += EventFunctionSound;
        Debug.Log("play");
    }
    //désinscription
    private void OnDisable()
    {
        ActorController.AieEvent -= EventFunctionSound;
        Debug.Log("stop");
    }
}
