using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip pickupSound;

    public PowerupEffect powerupEffect;
    //Zachary was the one who first did the actual pick up for the power up
    //Zach figured out that it would be really easy to destroy the game object on pickup
    //Victor was having a lot of trouble with that, so Zach took care of all of it
    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(pickupSound, 1);
        Destroy(gameObject);
        powerupEffect.Apply(collision.gameObject);
    }
}
