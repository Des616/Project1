using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public string Name;
    public string ItemDescription;
    private Stat EquipDamage;
    private Stat EquipHealth;
    private Stat EquipDef;

    public Color myColor;

    public float dmg;
    public float hp;
    public float def;

    void Awake(){
        EquipDamage = new Stat(dmg);
        EquipHealth = new Stat(hp);
        EquipDef = new Stat(def);
    }

    public float GetEquipDamge(){
        return EquipDamage.GetValue();
    }

    

    
    


}
