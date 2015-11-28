using UnityEngine;
using System.Collections;

public class Stage : MonoBehaviour {

	public struct Stage_T{
		public bool  LightFlg;
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
		ScopeDecide(masu[3,0].Board,masu[3,0].EnemyFlg,masu[3,0].PartyFlg);
		ScopeDecide(masu[3,1].Board,masu[3,1].EnemyFlg,masu[3,1].PartyFlg);
		ScopeDecide(masu[3,2].Board,masu[3,2].EnemyFlg,masu[3,2].PartyFlg);

	
	}

	// 光る処理。光らせるオブジェクトとON/OFFを引数に動作する
	public void Lighting(GameObject masu,bool set)
	{
        Debug.Log("hoge");
		//ParticleSystem particlesystem = masu.GetComponentInChildren<ParticleSystem>();
		ParticleSystem[] particles = masu.GetComponentsInChildren<ParticleSystem>();
		if (set)
		{
			particles[0].Play();
		} else {
			particles[0].Stop();
		}
	}

	// いける範囲の色を変える
	public void ScopeDecide(GameObject masu,bool enemy,bool party)
	{
		Renderer renderer = masu.GetComponent<Renderer>();
		renderer.material.color = new Color(0,0.8f,0.3f);

	}


}
