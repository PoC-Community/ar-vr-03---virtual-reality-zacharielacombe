using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;


public class Fire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform SpawnPoint;
    public float BulletSpeed;
    // Start is called before the first frame update
    void FireBullet(ActivateEventArgs arg)
    {
        GameObject tmp = Instantiate(Bullet, SpawnPoint);
        tmp.GetComponent<Rigidbody>().velocity = new Vector3(BulletSpeed, 0, 0);
        Destroy(tmp, 1);
    }
    void Start()
    {
        XRGrabInteractable interactable = gameObject.GetComponent(typeof(XRGrabInteractable)) as XRGrabInteractable;
        interactable.activated.AddListener(FireBullet);
    }
    // Update is called once per frame
    void Update()
    {
    }

}
