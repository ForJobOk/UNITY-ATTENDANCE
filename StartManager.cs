using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

    

    // Use this for initialization
    void Start () {
		
	}

    public void PushStartButton()  //出社ボタンを押したら時刻を取得、保存して次のシーンに移行
    {
        System.DateTime now = System.DateTime.Now;                   //現在時間の取得
        PlayerPrefs.SetString("STARTTIME", now.ToBinary().ToString());　　//時間の保存
        SceneManager.LoadScene("FinishScene");　　　　　　　　　　　 //シーンの移動
    }



    // Update is called once per frame
    void Update () {
		
	}
}
