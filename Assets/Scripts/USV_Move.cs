using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USV_Move : MonoBehaviour
{
    private float speed = 10f;

    private Vector3 currPos;


    // Start is called before the first frame update
    void Start()
    {
        currPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(transform.up * (-speed) * Time.deltaTime, Space.World);
    
    }
}
