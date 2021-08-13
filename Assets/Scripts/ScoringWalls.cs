using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringWalls : MonoBehaviour
{
    public Canvas Hud;

    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Hud.gameObject.SendMessage("UpdateScore", transform.name, SendMessageOptions.RequireReceiver);
            collision.gameObject.SendMessage("ResetBall", 3, SendMessageOptions.RequireReceiver);
        }
    }
}
