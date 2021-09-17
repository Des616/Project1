using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
   public float speed = 10.0f;

    void Start(){
        speed = speed / 20;
    }
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * speed;
        
        float yMovement = Input.GetAxis("Vertical") * speed;
        if(Mathf.Abs(xMovement) >= 0.03 || Mathf.Abs(yMovement) > 0.03){
            transform.Translate(xMovement,yMovement,0);
            
        }
        
    }
}
