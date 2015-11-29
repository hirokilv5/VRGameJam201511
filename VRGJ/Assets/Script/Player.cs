using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum JOB_NUMBER : int { OU, KINN, GINN, KEIMA, KOUSYA, HISYA, KAKU, HU, N_HU, N_HISYA, N_KAKU, NON = 99 };

    public GameObject[] Coma_Prehab;

    public struct Coma_Status
    {
        public int Now_Job;
        public int Old_Job;

        public bool PlayerFlg;
        public bool EnemyFlg;
        public bool SelectFlg;
        public GameObject prehab_coma;
    }
    public Coma_Status[] HU_Coma = new Coma_Status[9];
    public Coma_Status[] KINN_Coma = new Coma_Status[2];
    public Coma_Status[] GINN_Coma = new Coma_Status[2];
    public Coma_Status[] KEIMA_Coma = new Coma_Status[2];
    public Coma_Status[] KOUSYA_Coma = new Coma_Status[2];
    public Coma_Status HISYA_Coma;
    public Coma_Status KAKU_Coma;
    public Coma_Status OU_Coma;

	// Use this for initialization
	void Start () {
        for (int i = 0; i <= 8; i++)
        {
            HU_Coma[i].prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[(int)JOB_NUMBER.HU],
                    new Vector3(i * 1, 0, 6),
                    Quaternion.identity
                );
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
