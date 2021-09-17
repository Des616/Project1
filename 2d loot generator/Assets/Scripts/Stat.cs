using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    protected float baseValue; //shouldnt be changed once set
    public float currentValue;
    public Stat(float bValue){
        baseValue = bValue;
        currentValue = bValue;
    }
    
    public void AddValue(float num){
        currentValue += num;
    }

    public void SubValue(float num){
        currentValue -= num;
    }

    public void SetValue(float newValue){
        currentValue = newValue;
    }

    public void ResetValue(){
        currentValue = baseValue;
    }

    public float GetValue(){
        return currentValue;
    }
    public float GetBaseValue(){
        return baseValue;
    }

}
