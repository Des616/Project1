using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    

    public void EquipWeapon(GameObject weaponToEquip){
        PlayerManager.instance.EquipWeapon(weaponToEquip);
        UiManager.instance.UpdateStatValues();
        PlayerManager.instance.UpdateCharacterStats();


    }



}
