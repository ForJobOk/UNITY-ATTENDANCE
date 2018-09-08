using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishTimeText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string datetimeString = PlayerPrefs.GetString("FINISHTIME");   //時間の読み出し
        System.DateTime datetime = System.DateTime.FromBinary(System.Convert.ToInt64(datetimeString));  //読み出した時間をキャスト
        GetComponent<Text>().text = datetime.ToString();     //テキストに入れるため再度キャスト？

    }

    // Update is called once per frame
    void Update () {
		
	}
}
