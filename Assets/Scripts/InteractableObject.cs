using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    // アイテムの名前を設定するための変数
    public string ItemName;

    // アイテムの名前を取得するメソッド
    public string GetItemName()
    {
        return ItemName;
    }
}