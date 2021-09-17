using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    public float baseValue;
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

}
