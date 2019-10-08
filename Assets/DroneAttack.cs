using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAttack : MonoBehaviour
{
    //フィールド
    public GameObject droneBullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BulletAttack()
    {
        Instantiate(droneBullet, gameObject.transform.position, gameObject.transform.rotation);
    }
}
