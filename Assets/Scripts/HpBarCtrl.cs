using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarCtrl : MonoBehaviour
{
    //Slider _slider;
    // Start is called before the first frame update
    void Start()
    {
        //_slider = GameObject.Find("Slider").GetComponent<Slider>();

        //float maxHp = 100f;
        //float nowHp = 100f;

        ////スライダーの最大値の設定
        //_slider.maxValue = maxHp;

        ////スライダーの現在値の設定
        //_slider.value = nowHp;
    }

    //public void TakeDamage(int amount)
    //{
    //    _slider -= amount;
    //    if (_slider <= 0)
    //    {
    //        _slider = 0;
    //        Debug.Log("Dead!");
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    _slider.value -= 10f;
        //}

        //_hp += 1.0f;
        //if(_hp>_slider.maxvalue)
        //{
        //    _hp = _slider.minvalue;
        //}
        //_slider.value = _hp;

    }
}
