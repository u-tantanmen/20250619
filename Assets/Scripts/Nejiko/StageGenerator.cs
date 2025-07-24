using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    //ターゲットキャラクターの保持用変数
    public Transform character;
    //ステージのPrefabを配列で管理する変数
    public GameObject[] stageChip;
    //Sceneに実体化させたステージのPrefabを管理する配列
    public List<GameObject> generateStageList = new List<GameObject>();
    //ステージ数をカウントするインデックス
    public int preInstance = 5;
    //
    public int currentChipIndex;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクターの現在位置から現在のステージチップのインデックスを計算
        int characterPositionIndex = (int)(character.position.z / 30f);

        //次のステージチップに入ったらステージの最新処理を行う
        if (characterPositionIndex + preInstance > currentChipIndex)
        {
            //指定のステージチップを作成
            for (int i = currentChipIndex + 1; i <= preInstance; i++)
            {
                GameObject stageObject = Instantiate (stageChip[0]);
                stageObject.transform.position = new Vector3(0,0,i * 30f);
                //生成したステージチップを管理リストに追加
                generateStageList.Add(stageObject);
            }
        }
    }
}
