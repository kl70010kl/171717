using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("aa");
        var hit = collision.gameObject;
        var health = hit.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(10);
        }
    }
}
