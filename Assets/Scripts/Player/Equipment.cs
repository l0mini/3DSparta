using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class Equipment : MonoBehaviour
{
    public Equipment curEquip;

    private PlayerCondition condition;
    private PlayerController controller;

    private void Start()
    {
        condition = CharacterManager.Instance.Player.condition;
        condition = CharacterManager.Instance.Player.condition;
    }

    public void EquipNew(ItemData item)
    {
        UnEquip();
        
    }

    public void UnEquip()
    {
        if(curEquip != null)
        {
            curEquip = null;    
        }
    }
}
