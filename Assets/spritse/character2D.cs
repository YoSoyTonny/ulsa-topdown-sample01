using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character2D : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;
    //float moveSpeed {get, set};
   void Update()
   {
      transform.Translate(Axis * moveSpeed * Time.deltaTime); 
   }

   Vector2 Axis 
   {
      get  => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
   }

}
