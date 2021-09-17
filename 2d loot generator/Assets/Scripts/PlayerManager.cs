using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    [Header("Character Name")]
    public string characterName = "DefaultDanny";
    [Header("Base Stats")]
    public float hp;
    public float dmg;
    public float def;
    private Stat Health, Damage, Defense;

    [Header("Equipments")]

    public GameObject weaponSlot;
    public GameObject helmetSlot;

    void Awake(){
        void Awake(){
        if(instance != null && instance != this){
            Destroy(this.gameObject);
        }
        else{
            instance = this;
        }
    }
        Health = new Stat(hp);
        Damage = new Stat(dmg);
        Defense = new Stat(def);
    }

    void Start(){
        UpdateCharacterStats();
    }

    

    public float GetHealth(){
        return Health.GetValue();
    }
    public float GetDamage(){
        return Damage.GetValue();
    }
    public float GetDefense(){
        return Defense.GetValue();
    }

    public void EquipWeapon(GameObject weaponToEquip){
        GameObject myWep = weaponSlot.transform.GetChild(0).gameObject;
        if(myWep != null){
            Destroy(myWep);
        }
        else{
        }
    }

    public void UpdateCharacterStats(){
        Damage.SetValue(weaponSlot.transform.GetChild(0).GetComponent<Equipment>().GetEquipDamge());
    }


   
}
