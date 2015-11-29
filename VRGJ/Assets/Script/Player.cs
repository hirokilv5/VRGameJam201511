using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum JOB_NUMBER : int { OU, KINN, GINN, KEIMA, KOUSYA, HISYA, KAKU, HU, N_HU, N_HISYA, N_KAKU, NON = 99 };

    public GameObject[] Coma_Prehab;

    public struct Coma_Status
    {
        public int Now_Job; //最初のジョブ
        public int Old_Job;   //成をする前にNow_jobを保存する。

        public bool PlayerFlg;  //自分がプレイヤーか
        public bool EnemyFlg;   //自分がエネミーか
        public bool SelectFlg;  //視点で選択されているか
        public GameObject prehab_coma;  //プレハブを入れる
    }

    public Coma_Status[] HU_Coma = new Coma_Status[9];
    public Coma_Status[] KINN_Coma = new Coma_Status[2];
    public Coma_Status[] GINN_Coma = new Coma_Status[2];
    public Coma_Status[] KEIMA_Coma = new Coma_Status[2];
    public Coma_Status[] KOUSYA_Coma = new Coma_Status[2];
    public Coma_Status HISYA_Coma;
    public Coma_Status KAKU_Coma;
    public Coma_Status OU_Coma;

    public Coma_Status[] EN_HU_Coma = new Coma_Status[9];
    public Coma_Status[] EN_KINN_Coma = new Coma_Status[2];
    public Coma_Status[] EN_GINN_Coma = new Coma_Status[2];
    public Coma_Status[] EN_KEIMA_Coma = new Coma_Status[2];
    public Coma_Status[] EN_KOUSYA_Coma = new Coma_Status[2];
    public Coma_Status EN_HISYA_Coma;
    public Coma_Status EN_KAKU_Coma;
    public Coma_Status EN_OU_Coma;

	// Use this for initialization
	void Start () {
        for (int i = 0; i <= 8; i++)
        {
            //歩
            HU_Coma[i].PlayerFlg = true;
            HU_Coma[i].EnemyFlg = false;
            HU_Coma[i].SelectFlg = false;
            HU_Coma[i].Old_Job = (int)JOB_NUMBER.NON;
            HU_Coma[i].Now_Job = (int)JOB_NUMBER.HU;
            HU_Coma[i].prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[HU_Coma[i].Now_Job],
                    new Vector3(i * 1, 0, 6),
                    Quaternion.identity
                );
            //敵歩
            EN_HU_Coma[i].EnemyFlg = true;
            EN_HU_Coma[i].PlayerFlg = false;
            EN_HU_Coma[i].SelectFlg = false;
            EN_HU_Coma[i].Old_Job = (int)JOB_NUMBER.NON;
            EN_HU_Coma[i].Now_Job = (int)JOB_NUMBER.HU;
            EN_HU_Coma[i].prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[EN_HU_Coma[i].Now_Job],
                    new Vector3(i * 1, 0, 2),
                    Quaternion.identity
                );
        }
        for (int i = 0; i <= 1; i++)
        {
            //金
            KINN_Coma[i].PlayerFlg = true;
            KINN_Coma[i].Now_Job = (int)JOB_NUMBER.KINN;
            KINN_Coma[i].EnemyFlg = false;
            KINN_Coma[i].SelectFlg = false;
            KINN_Coma[i].Old_Job = (int)JOB_NUMBER.NON;
            //銀
            GINN_Coma[i].PlayerFlg = true;
            GINN_Coma[i].Now_Job = (int)JOB_NUMBER.GINN;
            GINN_Coma[i].EnemyFlg = false;
            GINN_Coma[i].SelectFlg = false;
            GINN_Coma[i].Old_Job = (int)JOB_NUMBER.NON;
            //桂馬
            KEIMA_Coma[i].PlayerFlg = true;
            KEIMA_Coma[i].Now_Job = (int)JOB_NUMBER.KEIMA;
            KEIMA_Coma[i].EnemyFlg = false;
            KEIMA_Coma[i].SelectFlg = false;
            KEIMA_Coma[i].Old_Job = (int)JOB_NUMBER.NON;
            //香車
            KOUSYA_Coma[i].PlayerFlg = true;
            KOUSYA_Coma[i].Now_Job = (int)JOB_NUMBER.KOUSYA;
            KOUSYA_Coma[i].EnemyFlg = false;
            KOUSYA_Coma[i].SelectFlg = false;
            KOUSYA_Coma[i].Old_Job = (int)JOB_NUMBER.NON;

            //敵金
            EN_KINN_Coma[i].EnemyFlg = true;
            EN_KINN_Coma[i].Now_Job = (int)JOB_NUMBER.KINN;
            EN_KINN_Coma[i].PlayerFlg = false;
            EN_KINN_Coma[i].SelectFlg = false;
            EN_KINN_Coma[i].Old_Job = (int)JOB_NUMBER.NON;

            //敵銀
            EN_GINN_Coma[i].EnemyFlg = true;
            EN_GINN_Coma[i].Now_Job = (int)JOB_NUMBER.GINN;
            EN_GINN_Coma[i].PlayerFlg = false;
            EN_GINN_Coma[i].SelectFlg = false;
            EN_GINN_Coma[i].Old_Job = (int)JOB_NUMBER.NON;
            //敵桂馬
            EN_KEIMA_Coma[i].EnemyFlg = true;
            EN_KEIMA_Coma[i].Now_Job = (int)JOB_NUMBER.KEIMA;
            EN_KEIMA_Coma[i].PlayerFlg = false;
            EN_KEIMA_Coma[i].SelectFlg = false;
            EN_KEIMA_Coma[i].Old_Job = (int)JOB_NUMBER.NON;
            //敵香車
            EN_KOUSYA_Coma[i].EnemyFlg = true;
            EN_KOUSYA_Coma[i].Now_Job = (int)JOB_NUMBER.KOUSYA;
            EN_KOUSYA_Coma[i].PlayerFlg = false;
            EN_KOUSYA_Coma[i].SelectFlg = false;
            EN_KOUSYA_Coma[i].Old_Job = (int)JOB_NUMBER.NON;

            if (i == 0)
            {
                KINN_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KINN_Coma[i].Now_Job], new Vector3(3, 0, 8), Quaternion.identity);
                GINN_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[GINN_Coma[i].Now_Job], new Vector3(2, 0, 8), Quaternion.identity);
                KEIMA_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KEIMA_Coma[i].Now_Job], new Vector3(1, 0, 8), Quaternion.identity);
                KOUSYA_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KOUSYA_Coma[i].Now_Job], new Vector3(0, 0, 8), Quaternion.identity);

                EN_KINN_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KINN_Coma[i].Now_Job], new Vector3(5, 0, 0), Quaternion.identity);
                EN_GINN_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[GINN_Coma[i].Now_Job], new Vector3(6, 0, 0), Quaternion.identity);
                EN_KEIMA_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KEIMA_Coma[i].Now_Job], new Vector3(7, 0, 0), Quaternion.identity);
                EN_KOUSYA_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KOUSYA_Coma[i].Now_Job], new Vector3(8, 0, 0), Quaternion.identity);

            }
            else if (i == 1)
            {
                KINN_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KINN_Coma[i].Now_Job], new Vector3(5, 0, 8), Quaternion.identity);
                GINN_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[GINN_Coma[i].Now_Job], new Vector3(6, 0, 8), Quaternion.identity);
                KEIMA_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KEIMA_Coma[i].Now_Job], new Vector3(7, 0, 8), Quaternion.identity);
                KOUSYA_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KOUSYA_Coma[i].Now_Job], new Vector3(8, 0, 8), Quaternion.identity);

                EN_KINN_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KINN_Coma[i].Now_Job], new Vector3(3, 0, 0), Quaternion.identity);
                EN_GINN_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[GINN_Coma[i].Now_Job], new Vector3(2, 0, 0), Quaternion.identity);
                EN_KEIMA_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KEIMA_Coma[i].Now_Job], new Vector3(1, 0, 0), Quaternion.identity);
                EN_KOUSYA_Coma[i].prehab_coma = (GameObject)Instantiate(Coma_Prehab[KOUSYA_Coma[i].Now_Job], new Vector3(0, 0, 0), Quaternion.identity);
            }

            //飛車
            HISYA_Coma.PlayerFlg = true;
            HISYA_Coma.EnemyFlg = false;
            HISYA_Coma.SelectFlg = false;
            HISYA_Coma.Old_Job = (int)JOB_NUMBER.NON;
            HISYA_Coma.Now_Job = (int)JOB_NUMBER.HISYA;
            HISYA_Coma.prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[HISYA_Coma.Now_Job],
                    new Vector3(7, 0, 7),
                    Quaternion.identity
                );
            //敵飛車
            EN_HISYA_Coma.EnemyFlg = true;
            EN_HISYA_Coma.PlayerFlg = false;
            EN_HISYA_Coma.SelectFlg = false;
            EN_HISYA_Coma.Old_Job = (int)JOB_NUMBER.NON;
            EN_HISYA_Coma.Now_Job = (int)JOB_NUMBER.HISYA;
            EN_HISYA_Coma.prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[EN_HISYA_Coma.Now_Job],
                    new Vector3(1, 0, 1),
                    Quaternion.identity
                );
            //角
            KAKU_Coma.PlayerFlg = true;
            KAKU_Coma.EnemyFlg = false;
            KAKU_Coma.SelectFlg = false;
            KAKU_Coma.Old_Job = (int)JOB_NUMBER.NON;
            KAKU_Coma.Now_Job = (int)JOB_NUMBER.KAKU;
            KAKU_Coma.prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[KAKU_Coma.Now_Job],
                    new Vector3(1, 0, 7),
                    Quaternion.identity
                );
            //敵角
            EN_KAKU_Coma.EnemyFlg = true;
            EN_KAKU_Coma.PlayerFlg = false;
            EN_KAKU_Coma.SelectFlg = false;
            EN_KAKU_Coma.Old_Job = (int)JOB_NUMBER.NON;
            EN_KAKU_Coma.Now_Job = (int)JOB_NUMBER.KAKU;
            EN_KAKU_Coma.prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[EN_KAKU_Coma.Now_Job],
                    new Vector3(7, 0, 1),
                    Quaternion.identity
                );
            //王
            OU_Coma.PlayerFlg = true;
            OU_Coma.EnemyFlg = false;
            OU_Coma.SelectFlg = false;
            OU_Coma.Old_Job = (int)JOB_NUMBER.NON;
            OU_Coma.Now_Job = (int)JOB_NUMBER.OU;
            OU_Coma.prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[OU_Coma.Now_Job],
                    new Vector3(4, 0, 8),
                    Quaternion.identity
                );
            //敵王
            EN_OU_Coma.EnemyFlg = true;
            EN_OU_Coma.PlayerFlg = false;
            EN_OU_Coma.SelectFlg = false;
            EN_OU_Coma.Old_Job = (int)JOB_NUMBER.NON;
            EN_OU_Coma.Now_Job = (int)JOB_NUMBER.OU;
            EN_OU_Coma.prehab_coma = (GameObject)Instantiate(
                    Coma_Prehab[EN_OU_Coma.Now_Job],
                    new Vector3(4, 0, 0),
                    Quaternion.identity
                );
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
