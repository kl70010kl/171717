using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DroneController : MonoBehaviour
{
    public float speed = 3.0f;
    Rigidbody2D rd;
    public GameObject block;
    private int blockCreateCount;
    public GameObject camera;
    private GameObject player;
    private MoveCharacterAction characterAction;

    private enum DroneState
    {
        Following,
        Support,
        Attack,
    }

    private DroneState state;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        //blockCreateCount = 0;
        blockCreateCount = Block.blockCount;
        state = DroneState.Following;
        player = GameObject.FindGameObjectWithTag("Player");
        characterAction = player.GetComponent<MoveCharacterAction>();
    }

    // Update is called once per frame
    void Update()
    {
        blockCreateCount = Block.blockCount;
        if (blockCreateCount <= 2)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Instantiate(block, transform.position + new Vector3(0, -0.16f, 0), transform.rotation);
                blockCreateCount++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            StateChangeZ();
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            StateChangeX();
        }

        switch (state)
        {
            case DroneState.Following:
                FollowingUpdate();
                break;
            case DroneState.Attack:
                break;
            case DroneState.Support:
                break;
        }

        print(state);
    }

    private void FixedUpdate()
    {
        float droneCameraPos = this.transform.position.x - camera.transform.position.x;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.RightArrow) && droneCameraPos == 0)
        {
            h = 1;

        }
        else if (Input.GetKey(KeyCode.LeftArrow) && droneCameraPos == 0)
        {
            h = -1;
        }
        else
        {
            h = 0;
        }

        if (Input.GetKey(KeyCode.UpArrow) && droneCameraPos == 0)
        {
            v = 1;
        }

        else if (Input.GetKey(KeyCode.DownArrow) && droneCameraPos == 0)
        {
            v = -1;
        }
        else
        {
            v = 0;
        }



        rd.velocity = new Vector3(h * speed, v * speed, 0);
    }

    private void StateChangeZ()
    {

        if (state == DroneState.Following)
        {
            state = DroneState.Attack;
        }
        else if (state == DroneState.Attack)
        {
            state = DroneState.Support;
        }
        else if (state == DroneState.Support)
        {
            state = DroneState.Following;
        }

    }

    private void StateChangeX()
    {
        if (state == DroneState.Following)
        {
            state = DroneState.Support;
        }
        else if (state == DroneState.Support)
        {
            state = DroneState.Attack;
        }
        else if (state == DroneState.Attack)
        {
            state = DroneState.Following;
        }
    }

    private void FollowingUpdate()
    {
        if (characterAction.gunDirection == MoveCharacterAction.GunDirection.Right)
        {
            transform.position = player.transform.position - new Vector3(0.32f, -0.32f, 0);
        }
        else if (characterAction.gunDirection == MoveCharacterAction.GunDirection.Left)
        {
            transform.position = player.transform.position - new Vector3(-0.32f, -0.32f, 0);
        }
    }

    private void AttackUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {

        }
    }
}
