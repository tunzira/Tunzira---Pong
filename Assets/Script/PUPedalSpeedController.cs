using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPedalSpeedController : MonoBehaviour
{
    public PowerUpManagerPaddle manager;
    public Collider2D ball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            manager.RemovePowerUp(gameObject);
        }
    }
}
