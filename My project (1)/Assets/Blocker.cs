using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker : MonoBehaviour
{
    int HitPoints;
    public Material critical;
    public Material medium;
    // Start is called before the first frame update
    void Start()
    {
        HitPoints = 3;
    }

    public int GetHitPoints()
    {
        return HitPoints;
    }

    public void substractHitPoints()
    {
        HitPoints--;
        if (HitPoints == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material = medium;
        }
        if (HitPoints == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material = critical;
        }
        if (HitPoints == 0)
            Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
