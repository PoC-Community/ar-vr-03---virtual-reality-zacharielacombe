using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject target;

    IEnumerator StartSpawning()
    {
        Instantiate(target, spawnPoints[Random.Range(0, spawnPoints.Length - 1)]);
        yield return new WaitForSeconds(4);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(StartSpawning());
    }
}
