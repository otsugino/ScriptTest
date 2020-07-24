using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Test : MonoBehaviour {






	// Use this for initialization
	void Start () {

		//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
		int[] array = { 11, 22, 33, 44, 55 };

		//for文を使い、配列の各要素の値を順番に表示
		for (int i = 0; i < 5; i++)
        {
			Debug.Log(array[i]);
        }

		//for文を使い、配列の各要素の値を逆順に表示
		for (int i = 4; i >= 0; i--)
        {
			Debug.Log(array[i]);

        }
		


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
