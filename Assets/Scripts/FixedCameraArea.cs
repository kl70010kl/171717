using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCameraArea : MonoBehaviour
{
    //フィールド
    GameObject area; //警戒範囲
    private float switchTimer; //OnOff切り替えタイマー
    private bool cameraSwitch; //カメラのOnOffスイッチ

    private float warningDigree;
    public GameObject warnngSliderCtr;
    private WarnigUI warnigUI;
    private bool isCollision;


    // Start is called before the first frame update
    void Start()
    {
        area = transform.GetChild(0).gameObject;
        cameraSwitch = true;
        isCollision = false;
        warningDigree = 25f;
        warnigUI = warnngSliderCtr.GetComponent<WarnigUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isCollision == false)
        {
            if (collision.tag == "Player")
            {
                if (cameraSwitch == true)
                {
                    MoveCharacterAction moveCharacterAction = collision.GetComponent<MoveCharacterAction>();
                    if (moveCharacterAction.GetPlayerState() != MoveCharacterAction.PlayerState.Stealth)
                    {
                        warnigUI.GetWarningDgree(warningDigree);
                        isCollision = true;
                    }
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isCollision == true)
            {
                isCollision = false;
            }
        }
    }

    public void CameraSwichChange(bool switchOnOff)
    {
        cameraSwitch = switchOnOff;
        area.SetActive(false);
    }
}
