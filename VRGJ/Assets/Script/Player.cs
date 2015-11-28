using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum JOB_NUMBER : int { OU, KINN, GINN, KEIMA, KOUSYA, HISYA, KAKU, HU, N_HU, N_HISYA, N_KAKU, NON = 99 };

    public struct Coma
    {
        public bool SelectFlg;
        public bool EnemyFlg;
        public bool PartyFlg;

        public int OldJob;
        public int Job;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
