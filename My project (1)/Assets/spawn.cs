using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform spawnPoints;
    public GameObject target;
    bool isRunning = false;

    IEnumerator StartSpawning()
    {
        isRunning = true;
        GameObject tmp = Instantiate(target, spawnPoints);
        tmp.GetComponent<Transform>().position = spawnPoints.position + new Vector3(Random.Range(-10f, 10f), 1, 1); ;
        tmp.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -40);
        tmp.GetComponent<Transform>().localScale = spawnPoints.localScale + new Vector3(Random.Range(0.5f, 1.2f), Random.Range(0.5f, 1.2f), Random.Range(0.5f, 1.2f));
        yield return new WaitForSeconds(0.8f);
        Destroy(tmp, 3);
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
