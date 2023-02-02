using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject target;
    bool isRunning = false;

    IEnumerator StartSpawning()
    {
        isRunning = true;
        Instantiate(target, spawnPoints[Random.Range(0, spawnPoints.Length)]);
        yield return new WaitForSeconds(4.0f);
        isRunning = false;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isRunning)
            StartCoroutine(StartSpawning());
    }
}
