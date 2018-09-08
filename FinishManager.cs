using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishManager : MonoBehaviour {


    //変数の宣言
    public GameObject finishButton;
    

    // Use this for initialization
    void Start() {
    }

    

    public void PushFinishButton()　　//退社ボタンを押したら時刻を取得、保存して次のシーンに移行
    {
        System.DateTime now = System.DateTime.Now;                   //現在時間の取得
        PlayerPrefs.SetString("FINISHTIME", now.ToBinary().ToString());　　//時間の保存 バイナリ化したあとstringに変換

        SceneManager.LoadScene("WorkTimeScene");         //次のシーンへ

    }





    // Update is called once per frame
    void Update () {
		
	}
}
