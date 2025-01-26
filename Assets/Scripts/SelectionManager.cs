using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    // �C���^���N�g�\�ȃI�u�W�F�N�g�̏���\������UI
    public GameObject interaction_Info_UI;

    // UI�ɕ\������e�L�X�g
    Text interaction_text;

    // Raycast���͂��ő勗��
    public float interactionDistance = 5f;

    private void Start()
    {
        // UI��Text�R���|�[�l���g���擾
        interaction_text = interaction_Info_UI.GetComponent<Text>();
    }

    void Update()
    {
        // �}�E�X�̈ʒu����Ray�𔭎�
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Raycast�𔭎˂��A�w�肵���������Ńq�b�g�����I�u�W�F�N�g���擾
        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            // �q�b�g�����I�u�W�F�N�g��Transform���擾
            var selectionTransform = hit.transform;

            // �q�b�g�����I�u�W�F�N�g��InteractableObject�R���|�[�l���g�������Ă��邩�m�F
            if (selectionTransform.GetComponent<InteractableObject>())
            {
                // �I�u�W�F�N�g�̖��O��UI�ɕ\��
                interaction_text.text = selectionTransform.GetComponent<InteractableObject>().GetItemName();
                interaction_Info_UI.SetActive(true);

                // �}�E�X�̍��N���b�N�������ꂽ���ǂ������m�F
                if (Input.GetMouseButtonDown(0))
                {
                    // �q�b�g�����I�u�W�F�N�g�̃^�O�� "item" ���ǂ������m�F
                    if (selectionTransform.CompareTag("item"))
                    {
                        // �f�o�b�O���O�� "Item added" �ƕ\��
                        Debug.Log("Item added");

                        // �q�b�g�����I�u�W�F�N�g��j��
                        Destroy(selectionTransform.gameObject);
                    }
                }
            }
            else
            {
                // InteractableObject�R���|�[�l���g���Ȃ��ꍇ�AUI���\���ɂ���
                interaction_Info_UI.SetActive(false);
            }
        }
        else
        {
            // Raycast�������q�b�g���Ȃ������ꍇ�AUI���\���ɂ���
            interaction_Info_UI.SetActive(false);
        }
    }
}