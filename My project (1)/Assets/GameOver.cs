using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text text;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Spawn")
        {
            Destroy(collision.gameObject);
            text.text = "You Lose";
        }
    }
}
