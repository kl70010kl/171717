﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDroneChange : MonoBehaviour
{
    private GameObject player;
    public GameObject drone;
    private MoveCharacterAction characterAction;
    private bool isPlayer;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        characterAction = player.GetComponent<MoveCharacterAction>();
        isPlayer = true;
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isPlayer = !isPlayer;
            if (isPlayer)
            {
                PlayerMove();
            }
            else if (isPlayer == false && flag == false)
            {
                DroneCreate();
                flag = true;
            }
            else if (isPlayer == false && flag == true)
            {
                DroneCreate2();
            }
        }
        

    }

    void DroneCreate()
    {
        drone.SetActive(true);
        drone.transform.position = player.transform.position + new Vector3(1, 0, 0);
        characterAction.SetPlayerState(MoveCharacterAction.PlayerState.DroneControl);
        
    }

    void DroneCreate2()
    {
        characterAction.SetPlayerState(MoveCharacterAction.PlayerState.DroneControl);
    }

    void PlayerMove()
    {
        characterAction.SetPlayerState(MoveCharacterAction.PlayerState.Active);
    }
}
