using UnityEngine;
using System.Collections;

public class Stage : MonoBehaviour {

	public struct Stage_T{
		public bool LightFlg;
		public bool EnemyFlg;
		public bool PartyFlg;

		public GameObject Board;
	}

	public Stage_T[,] masu = new Stage_T[9,9];

	public GameObject[,] Board = new GameObject[9,9];
	//public GameObject[] array = new GameObject[3];
	public GameObject prefab;


	void Start () {
	for (int i = 0;i < 9;i++)
	{
		for (int j = 0;j < 9;j++)
		{
			masu[i,j].LightFlg = false;
			masu[i,j].EnemyFlg = false;
			masu[i,j].PartyFlg = false;
			
			masu[i,j].Board = (GameObject)Instantiate(
				prefab,
				new Vector3(j*1,0,i*1),
				Quaternion.identity
			);

			ParticleSystem[] particles = masu[i,j].Board.GetComponentsInChildren<ParticleSystem>();
			for (int k = 0;k < particles.Length;k++)
			{
				particles[k].Stop();
			}
		}
	}
	}

	void Update () {
	
	}

	// 光る処理。光らせるオブジェクトとON/OFFを引数に動作する
	/*********************
	* エフェクトの種類
	* 0:決定
	* 3:選択
	* 9:オーラ
	***********************/
	public void Lighting(GameObject masu,bool setting, bool scope = false,bool aura = false)
	{
		ParticleSystem[] particles = masu.GetComponentsInChildren<ParticleSystem>();
		// 決定
		if (setting){
			particles[0].Play();
		} else {
			particles[0].Stop();
		}
		// 選択範囲
		if (scope){
			particles[9].Play();
		} else {
			particles[9].Stop();
		}
		// スーバーサイヤ人
		if (aura){
			particles[3].Play();
		} else {
			particles[3].Stop();
		}
	}


}
