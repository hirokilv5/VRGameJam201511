using UnityEngine;
using System.Collections;

public class Job_Move : MonoBehaviour {
    public Stage stage;

    void Job_Move_Control(int i, int j, int status) {
        switch (status)
        {
            case (int)Player.JOB_NUMBER.OU: //王
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //右上、真ん中上、左上
                    if (i - 1 >= 0)
                    {
                        if (j - 1 >= 0 && stage.masu[i - 1, j - 1].PartyFlg != true) stage.masu[i - 1, j - 1].LightFlg = true;  //左
                        if (j + 1 <= 8 && stage.masu[i - 1, j + 1].PartyFlg != true) stage.masu[i - 1, j + 1].LightFlg = true;  //右
                        if (stage.masu[i - 1, j].PartyFlg != true) stage.masu[i - 1, j].LightFlg = true;  //真ん中
                    }
                    //右下、真ん中下、左下
                    if (i + 1 <= 8)
                    {
                        if (j - 1 >= 0 && stage.masu[i + 1, j - 1].PartyFlg != true) stage.masu[i + 1, j - 1].LightFlg = true;  //左
                        if (j + 1 <= 8 && stage.masu[i + 1, j + 1].PartyFlg != true) stage.masu[i + 1, j + 1].LightFlg = true;  //右
                        if (stage.masu[i + 1, j].PartyFlg != true) stage.masu[i - 1, j].LightFlg = true;  //真ん中
                    }
                    //真ん中左
                    if (j - 1 >= 0 && stage.masu[i, j - 1].PartyFlg != true) stage.masu[i, j - 1].LightFlg = true;
                    //真ん中右
                    if (j + 1 <= 8 && stage.masu[i, j + 1].PartyFlg != true) stage.masu[i, j + 1].LightFlg = true;
                }
                //エネミー視点
                else if (stage.masu[i, j].EnemyFlg == true)
                {
                    //右上、真ん中上、左上
                    if (i + 1 <= 8)
                    {
                        if (j - 1 >= 0 && stage.masu[i + 1, j - 1].PartyFlg != true) stage.masu[i + 1, j - 1].LightFlg = true;  //右
                        if (j + 1 <= 8 && stage.masu[i + 1, j + 1].PartyFlg != true) stage.masu[i + 1, j + 1].LightFlg = true;  //左
                        if (stage.masu[i + 1, j].PartyFlg != true) stage.masu[i + 1, j].LightFlg = true;  //真ん中上
                    }
                    //右下、真ん中下、左下
                    if (i - 1 >= 0)
                    {
                        if (j - 1 >= 0 && stage.masu[i - 1, j - 1].PartyFlg != true) stage.masu[i - 1, j - 1].LightFlg = true;  //右
                        if (j + 1 <= 8 && stage.masu[i - 1, j + 1].PartyFlg != true) stage.masu[i - 1, j + 1].LightFlg = true;  //左
                        if (stage.masu[i - 1, j].PartyFlg != true) stage.masu[i - 1, j].LightFlg = true;  //真ん中下
                    }
                    //真ん中左
                    if (j + 1 <= 8 && stage.masu[i, j + 1].PartyFlg != true) stage.masu[i, j + 1].LightFlg = true;
                    //真ん中右
                    if (j - 1 >= 0 && stage.masu[i, j - 1].PartyFlg != true) stage.masu[i, j - 1].LightFlg = true;
                }
                break;

            case (int)Player.JOB_NUMBER.KINN:   //金
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //右上、真ん中上、左上
                    if (i - 1 >= 0)
                    {
                        if (j - 1 >= 0 && stage.masu[i - 1, j - 1].PartyFlg != true) stage.masu[i - 1, j - 1].LightFlg = true;  //左
                        if (j + 1 <= 8 && stage.masu[i - 1, j + 1].PartyFlg != true) stage.masu[i - 1, j + 1].LightFlg = true;  //右
                        if (stage.masu[i - 1, j].PartyFlg != true) stage.masu[i - 1, j].LightFlg = true;  //真ん中
                    }
                    //真ん中下
                    if (i + 1 <= 8)
                    {
                        if (stage.masu[i + 1, j].PartyFlg != true) stage.masu[i - 1, j].LightFlg = true;
                    }
                    //真ん中左
                    if (j - 1 >= 0 && stage.masu[i, j - 1].PartyFlg != true) stage.masu[i, j - 1].LightFlg = true;
                    //真ん中右
                    if (j + 1 <= 8 && stage.masu[i, j + 1].PartyFlg != true) stage.masu[i, j + 1].LightFlg = true;
                }
                //エネミー視点
                else if (stage.masu[i, j].EnemyFlg == true)
                {
                    //右上、真ん中上、左上
                    if (i + 1 <= 8)
                    {
                        if (j - 1 >= 0 && stage.masu[i + 1, j - 1].PartyFlg != true) stage.masu[i + 1, j - 1].LightFlg = true;  //右
                        if (j + 1 <= 8 && stage.masu[i + 1, j + 1].PartyFlg != true) stage.masu[i + 1, j + 1].LightFlg = true;  //左
                        if (stage.masu[i + 1, j].PartyFlg != true) stage.masu[i + 1, j].LightFlg = true;  //真ん中上
                    }
                    //真ん中下
                    if (i - 1 >= 0)
                    {
                        if (stage.masu[i - 1, j].PartyFlg != true) stage.masu[i - 1, j].LightFlg = true;
                    }
                    //真ん中左
                    if (j - 1 >= 0 && stage.masu[i, j - 1].PartyFlg != true) stage.masu[i, j - 1].LightFlg = true;
                    //真ん中右
                    if (j + 1 <= 8 && stage.masu[i, j + 1].PartyFlg != true) stage.masu[i, j + 1].LightFlg = true;
                }
                break;

            case (int)Player.JOB_NUMBER.GINN:   //銀
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //右上、真ん中上、左上
                    if (i - 1 >= 0)
                    {
                        if (j - 1 >= 0 && stage.masu[i - 1, j - 1].PartyFlg != true) stage.masu[i - 1, j - 1].LightFlg = true;  //左
                        if (j + 1 <= 8 && stage.masu[i - 1, j + 1].PartyFlg != true) stage.masu[i - 1, j + 1].LightFlg = true;  //右
                        if (stage.masu[i - 1, j].PartyFlg != true) stage.masu[i - 1, j].LightFlg = true;  //真ん中
                    }
                    //真ん中下
                    if (i + 1 <= 8)
                    {
                        if (stage.masu[i + 1, j].PartyFlg != true) stage.masu[i + 1, j].LightFlg = true;
                    }
                }
                //エネミー視点
                else if (stage.masu[i, j].EnemyFlg == true)
                {
                    //右上、真ん中上、左上
                    if (i + 1 <= 8)
                    {
                        if (j - 1 >= 0 && stage.masu[i + 1, j - 1].PartyFlg != true) stage.masu[i + 1, j - 1].LightFlg = true;  //右
                        if (j + 1 <= 8 && stage.masu[i + 1, j + 1].PartyFlg != true) stage.masu[i + 1, j + 1].LightFlg = true;  //左
                        if (stage.masu[i + 1, j].PartyFlg != true) stage.masu[i + 1, j].LightFlg = true;  //真ん中上
                    }
                    //真ん中下
                    if (i - 1 >= 0)
                    {
                        if (stage.masu[i - 1, j].PartyFlg != true) stage.masu[i - 1, j].LightFlg = true;
                    }
                }
                break;

            case (int)Player.JOB_NUMBER.KEIMA:  //桂馬
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    if (i - 2 >= 0)
                    {
                        if (j - 1 >= 0 && stage.masu[i - 2, j - 1].PartyFlg != true) stage.masu[i - 2, j - 1].LightFlg = true;  //左
                        if (j + 1 <= 8 && stage.masu[i - 2, j + 1].PartyFlg != true) stage.masu[i - 2, j + 1].LightFlg = true;  //右
                    }
                }
                //エネミー視点
                else if (stage.masu[i, j].EnemyFlg == true)
                {
                    if (i + 2 <= 8)
                    {
                        if (j - 1 >= 0 && stage.masu[i + 2, j - 1].PartyFlg != true) stage.masu[i + 2, j - 1].LightFlg = true;  //右
                        if (j + 1 <= 8 && stage.masu[i + 2, j + 1].PartyFlg != true) stage.masu[i + 2, j + 1].LightFlg = true;  //左
                    }
                }
                break;

            case (int)Player.JOB_NUMBER.KOUSYA: //香車
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //ｋが0になるまでライトをtrueにする
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k - 1, j].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, j].LightFlg = true;
                                if (stage.masu[k - 1, j].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                //エネミー視点
                else if (stage.masu[i, j].EnemyFlg == true)
                {
                    //ｋが0になるまでライトをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8)
                        {
                            //進みたい場所にエネミー(味方)がいたら抜ける
                            if (stage.masu[k + 1, j].EnemyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, j].LightFlg = true;
                                if (stage.masu[k + 1, j].PartyFlg == true)  //プレイヤー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                break;

            case (int)Player.JOB_NUMBER.HISYA:  //飛車
          /*      //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //ｋが0になるまでライトをtrueにする
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            //上
                            if (stage.masu[k - 1, j].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, j].LightFlg = true;
                                if (stage.masu[k - 1, j].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                //エネミー視点
                else if (stage.masu[i, j].EnemyFlg == true)
                {
                    //ｋが0になるまでライトをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8)
                        {
                            //進みたい場所にエネミー(味方)がいたら抜ける
                            if (stage.masu[k + 1, j].EnemyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, j].LkghtFlg = true;
                                if (stage.masu[k + 1, j].PartyFlg == true)  //プレイヤー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
           */
                break;

            case (int)Player.JOB_NUMBER.KAKU:
                break;

            case (int)Player.JOB_NUMBER.HU:
                if (stage.masu[i, j].PartyFlg == true)
                {
                    if (i - 1 >= 0 && stage.masu[i - 1, j].PartyFlg == false)
                    {
                        stage.masu[i - 1, j].LightFlg = true;
                    }
                }
                else if (stage.masu[i, j].EnemyFlg == true)
                {
                    if (i + 1 <= 8 && stage.masu[i + 1, j].EnemyFlg == false)
                    {
                        stage.masu[i + 1, j].LightFlg = true;
                    }
                }
                break;
                
            case (int)Player.JOB_NUMBER.N_HU:
                break;

            case (int)Player.JOB_NUMBER.N_HISYA:
                break;

            case (int)Player.JOB_NUMBER.N_KAKU:
                break;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
