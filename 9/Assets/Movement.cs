using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Mouse X") / 10;
        float my = Input.GetAxis("Mouse Y") / 10;
        transform.Translate(mX, my, 0);
    }
}
