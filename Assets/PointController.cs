using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{

    //ポイント
    int points = 0;

    //ポイントを表示するテキスト
    GameObject pointText;

    // Use this for initialization
    void Start()
    {
        //シーン中のPointTextオブジェクトを取得
        pointText = GameObject.Find("PointText");

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        //タグに応じたポイントを追加
        if (other.gameObject.tag == "SmallStarTag")
        {
            points += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            points += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            points += 15;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            points += 25;
        }

        //pointTextに現在の点数を表示
        pointText.GetComponent<Text>().text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }


}