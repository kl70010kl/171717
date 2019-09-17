using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityEquipment : MonoBehaviour
{
    public enum SecurityEquipmentState
    {
        Wait,
        Warning,
        Destroy,
    }

    SecurityEquipmentState state;

    // Start is called before the first frame update
    void Start()
    {
        state = SecurityEquipmentState.Wait;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
