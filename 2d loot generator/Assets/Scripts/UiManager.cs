using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
   public GameObject playerObject;
   public GameObject textBox;

   PlayerManager player;
    TextMeshProUGUI myStatsText;
    void Awake(){
        if(instance != null && instance != this){
            Destroy(this.gameObject);
        }
        else{
            instance = this;
        }
    }
   void Start(){
       player = playerObject.GetComponent<PlayerManager>();
       myStatsText = textBox.GetComponent<TextMeshProUGUI>();
       UpdateStatValues();
   }

   public void UpdateStatValues(){
        string myStats = "";
        myStats += "Hp: " + player.GetHealth() + "\n";
        myStats += "Dmg: " + player.GetDamage() + "\n";
        myStats += "Def: " + player.GetDefense() + "\n";
        myStatsText.text = myStats;
   }


}
