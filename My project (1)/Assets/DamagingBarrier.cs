using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingBarrier : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Blocker")
        {
            (collision.gameObject.GetComponent<Blocker>()).substractHitPoints();
            Destroy(gameObject);
        }
    }
}
