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

            case (int)Player.JOB_NUMBER.N_HU:   //成金
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
                    //ｋが0になるまでLightFlgをtrueにする
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
                    //ｋが0になるまでLightFlgをtrueにする
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
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //上
                    //ｋが0になるまでLightFlgをtrueにする
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
                    //左
                    //ｋが0になるまでLightFlgをtrueにする
                    for (int k = j; k >= 0; k--)
                    {
                        if (k - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[i, k - 1].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[i, k - 1].LightFlg = true;
                                if (stage.masu[i, k - 1].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //下
                    //ｋが8になるまでLightFlgをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k + 1, j].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, j].LightFlg = true;
                                if (stage.masu[k + 1, j].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //右
                    //ｋが8になるまでLightFlgをtrueにする
                    for (int k = j; k <= 8; k++)
                    {
                        if (k + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[i, k + 1].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[i, k + 1].LightFlg = true;
                                if (stage.masu[i, k + 1].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
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
                    //上
                    //ｋが8になるまでLightFlgをtrueにする
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
                    //左
                    //ｋが8になるまでLightFlgをtrueにする
                    for (int k = j; k <= 8; k++)
                    {
                        if (k + 1 <= 8)
                        {
                            //進みたい場所にエネミー(味方)がいたら抜ける
                            if (stage.masu[i, k + 1].EnemyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[i, k + 1].LightFlg = true;
                                if (stage.masu[i, k + 1].PartyFlg == true)  //プレイヤー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //下
                    //ｋが0になるまでLightFlgをtrueにする
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0)
                        {
                            //進みたい場所にエネミー(味方)がいたら抜ける
                            if (stage.masu[k - 1, j].EnemyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, j].LightFlg = true;
                                if (stage.masu[k - 1, j].PartyFlg == true)  //プレイヤー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //右
                    //ｋが0になるまでLightFlgをtrueにする
                    for (int k = j; k >= 0; k--)
                    {
                        if (k - 1 >= 0)
                        {
                            //進みたい場所にエネミー(味方)がいたら抜ける
                            if (stage.masu[i, k - 1].EnemyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[i, k - 1].LightFlg = true;
                                if (stage.masu[i, k - 1].PartyFlg == true)  //プレイヤー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                break;

            case (int)Player.JOB_NUMBER.KAKU:   //角
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //右上
                    //ｋが0、Tempolaliyが8になるまでLightFlgをtrueにする
                    int Tempolaliy = j;
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0 && Tempolaliy + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k - 1, Tempolaliy++].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, Tempolaliy].LightFlg = true;
                                if (stage.masu[k - 1, Tempolaliy].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy = j;
                    //左上
                    //ｋが0、Tempolaliyが0になるまでLightFlgをtrueにする
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0 && Tempolaliy - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k - 1, Tempolaliy--].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, Tempolaliy].LightFlg = true;
                                if (stage.masu[k - 1, Tempolaliy].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy = j;
                    //右下
                    //ｋが8、Tempolaliyが8になるまでLightFlgをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8 && Tempolaliy + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k + 1, Tempolaliy++].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, Tempolaliy].LightFlg = true;
                                if (stage.masu[k + 1, Tempolaliy].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy = j;
                    //左下
                    //ｋが8、Tempolaliyが0になるまでLightFlgをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8 && Tempolaliy - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k + 1, Tempolaliy--].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, Tempolaliy].LightFlg = true;
                                if (stage.masu[k + 1, Tempolaliy].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
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
                    //右上
                    //ｋが8、Tempolaliyが0になるまでLightFlgをtrueにする
                    int Tempolaliy = j;
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8 && Tempolaliy - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k + 1, Tempolaliy--].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, Tempolaliy].LightFlg = true;
                                if (stage.masu[k + 1, Tempolaliy].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy = j;
                    //左上
                    //ｋが8、Tempolaliyが8になるまでLightFlgをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8 && Tempolaliy + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k + 1, Tempolaliy++].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, Tempolaliy].LightFlg = true;
                                if (stage.masu[k + 1, Tempolaliy].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy = j;
                    //右下
                    //ｋが0、Tempolaliyが0になるまでLightFlgをtrueにする
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0 && Tempolaliy - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k - 1, Tempolaliy--].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, Tempolaliy].LightFlg = true;
                                if (stage.masu[k - 1, Tempolaliy].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy = j;
                    //左下
                    //ｋが0、Tempolaliyが8になるまでLightFlgをtrueにする
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0 && Tempolaliy + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k - 1, Tempolaliy++].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, Tempolaliy].LightFlg = true;
                                if (stage.masu[k - 1, Tempolaliy].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                break;

            case (int)Player.JOB_NUMBER.HU: //歩
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //一マス前がプレイヤー(味方)じゃなければLightFlgをtrueにする
                    if (i - 1 >= 0 && stage.masu[i - 1, j].PartyFlg == false)
                    {
                        stage.masu[i - 1, j].LightFlg = true;
                    }
                }
                //エネミー視点
                else if (stage.masu[i, j].EnemyFlg == true)
                {
                    //一マス前がエネミー(味方)じゃなければLightFlgをtrueにする
                    if (i + 1 <= 8 && stage.masu[i + 1, j].EnemyFlg == false)
                    {
                        stage.masu[i + 1, j].LightFlg = true;
                    }
                }
                break;

            case (int)Player.JOB_NUMBER.N_HISYA:    //成飛車
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //右上、真ん中上、左上
                    if (i - 1 >= 0)
                    {
                        if (j - 1 >= 0 && stage.masu[i - 1, j - 1].PartyFlg != true) stage.masu[i - 1, j - 1].LightFlg = true;  //左
                        if (j + 1 <= 8 && stage.masu[i - 1, j + 1].PartyFlg != true) stage.masu[i - 1, j + 1].LightFlg = true;  //右
                    }
                    //右下、真ん中下、左下
                    if (i + 1 <= 8)
                    {
                        if (j - 1 >= 0 && stage.masu[i + 1, j - 1].PartyFlg != true) stage.masu[i + 1, j - 1].LightFlg = true;  //左
                        if (j + 1 <= 8 && stage.masu[i + 1, j + 1].PartyFlg != true) stage.masu[i + 1, j + 1].LightFlg = true;  //右
                    }
                    //上
                    //ｋが0になるまでLightFlgをtrueにする
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
                    //左
                    //ｋが0になるまでLightFlgをtrueにする
                    for (int k = j; k >= 0; k--)
                    {
                        if (k - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[i, k - 1].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[i, k - 1].LightFlg = true;
                                if (stage.masu[i, k - 1].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //下
                    //ｋが8になるまでLightFlgをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k + 1, j].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, j].LightFlg = true;
                                if (stage.masu[k + 1, j].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //右
                    //ｋが8になるまでLightFlgをtrueにする
                    for (int k = j; k <= 8; k++)
                    {
                        if (k + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[i, k + 1].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[i, k + 1].LightFlg = true;
                                if (stage.masu[i, k + 1].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
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
                    //右上、真ん中上、左上
                    if (i + 1 <= 8)
                    {
                        if (j - 1 >= 0 && stage.masu[i + 1, j - 1].PartyFlg != true) stage.masu[i + 1, j - 1].LightFlg = true;  //右
                        if (j + 1 <= 8 && stage.masu[i + 1, j + 1].PartyFlg != true) stage.masu[i + 1, j + 1].LightFlg = true;  //左
                    }
                    //右下、真ん中下、左下
                    if (i - 1 >= 0)
                    {
                        if (j - 1 >= 0 && stage.masu[i - 1, j - 1].PartyFlg != true) stage.masu[i - 1, j - 1].LightFlg = true;  //右
                        if (j + 1 <= 8 && stage.masu[i - 1, j + 1].PartyFlg != true) stage.masu[i - 1, j + 1].LightFlg = true;  //左
                    }
                    //上
                    //ｋが8になるまでLightFlgをtrueにする
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
                    //左
                    //ｋが8になるまでLightFlgをtrueにする
                    for (int k = j; k <= 8; k++)
                    {
                        if (k + 1 <= 8)
                        {
                            //進みたい場所にエネミー(味方)がいたら抜ける
                            if (stage.masu[i, k + 1].EnemyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[i, k + 1].LightFlg = true;
                                if (stage.masu[i, k + 1].PartyFlg == true)  //プレイヤー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //下
                    //ｋが0になるまでLightFlgをtrueにする
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0)
                        {
                            //進みたい場所にエネミー(味方)がいたら抜ける
                            if (stage.masu[k - 1, j].EnemyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, j].LightFlg = true;
                                if (stage.masu[k - 1, j].PartyFlg == true)  //プレイヤー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    //右
                    //ｋが0になるまでLightFlgをtrueにする
                    for (int k = j; k >= 0; k--)
                    {
                        if (k - 1 >= 0)
                        {
                            //進みたい場所にエネミー(味方)がいたら抜ける
                            if (stage.masu[i, k - 1].EnemyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[i, k - 1].LightFlg = true;
                                if (stage.masu[i, k - 1].PartyFlg == true)  //プレイヤー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                break;

            case 10: //成角
                //プレイヤー視点
                if (stage.masu[i, j].PartyFlg == true)
                {
                    //上
                    if (i - 1 >= 0 && stage.masu[i - 1, j].PartyFlg != true)    stage.masu[i - 1, j].LightFlg = true;
                    }
                    //下
                    if (i + 1 <= 8 && stage.masu[i + 1, j].PartyFlg != true)    stage.masu[i - 1, j].LightFlg = true;
                    }
                    //左
                    if (j - 1 >= 0 && stage.masu[i, j - 1].PartyFlg != true)    stage.masu[i, j - 1].LightFlg = true;
                    //右
                    if (j + 1 <= 8 && stage.masu[i, j + 1].PartyFlg != true)    stage.masu[i, j + 1].LightFlg = true;

                    //右上
                    //ｋが0、Tempolaliy_sabが8になるまでLightFlgをtrueにする
                    int Tempolaliy_sab = j;
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0 && Tempolaliy_sab + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k - 1, Tempolaliy_sab++].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, Tempolaliy_sab].LightFlg = true;
                                if (stage.masu[k - 1, Tempolaliy_sab].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy_sab = j;
                    //左上
                    //ｋが0、Tempolaliy_sabが0になるまでLightFlgをtrueにする
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 >= 0 && Tempolaliy_sab - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k - 1, Tempolaliy_sab--].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k - 1, Tempolaliy_sab].LightFlg = true;
                                if (stage.masu[k - 1, Tempolaliy_sab].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy_sab = j;
                    //右下
                    //ｋが8、Tempolaliy_sabが8になるまでLightFlgをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8 && Tempolaliy_sab + 1 <= 8)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k + 1, Tempolaliy_sab++].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, Tempolaliy_sab].LightFlg = true;
                                if (stage.masu[k + 1, Tempolaliy_sab].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
                                {
                                    break;
                                }
                            }
                        }
                    }
                    Tempolaliy_sab = j;
                    //左下
                    //ｋが8、Tempolaliy_sabが0になるまでLightFlgをtrueにする
                    for (int k = i; k <= 8; k++)
                    {
                        if (k + 1 <= 8 && Tempolaliy_sab - 1 >= 0)
                        {
                            //進みたい場所にプレイヤー(味方)がいたら抜ける
                            if (stage.masu[k + 1, Tempolaliy_sab--].PartyFlg == true)
                            {
                                break;
                            }
                            else
                            {
                                stage.masu[k + 1, Tempolaliy_sab].LightFlg = true;
                                if (stage.masu[k + 1, Tempolaliy_sab].EnemyFlg == true)  //エネミー(敵)がいたら抜ける
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
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
