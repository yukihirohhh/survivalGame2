using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    // �A�C�e���̖��O��ݒ肷�邽�߂̕ϐ�
    public string ItemName;

    // �A�C�e���̖��O���擾���郁�\�b�h
    public string GetItemName()
    {
        return ItemName;
    }
}