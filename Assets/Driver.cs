using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   [SerializeField] float steerSpeed = 0.5f;
   [SerializeField] float moveSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal");
        float driveAmount = Input.GetAxis("Vertical");
        float boostAmount = Input.GetAxis("Jump");
       

        if (boostAmount == 1) {
            boostAmount = 2;
        }
        else {boostAmount = 1;}

        transform.Translate(0,moveSpeed * driveAmount * Time.deltaTime * boostAmount,0);
      
        if (driveAmount != 0) {
        transform.Rotate(0,0,steerSpeed * -steerAmount *Time.deltaTime);
    }
    }
}
