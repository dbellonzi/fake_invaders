using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherScript : MonoBehaviour
{
    public float testSpeed;
    public float testStep;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * testSpeed);
        if(transform.position.x > 12 || transform.position.x < -12)
        {
            testSpeed = -testSpeed;
            transform.Translate(Vector3.down * testStep);
        }
    }

    public void LostChild()
    {
        testSpeed *= 1.1f;
    }
}
