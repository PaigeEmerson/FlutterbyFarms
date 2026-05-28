using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LETTHEREBELIGHT : MonoBehaviour
{
    Vector3 rot = Vector3.zero;
    private float degPerTime;
   
    // Start is called before the first frame update
    void Start()
    {
        degPerTime = 360 / GameManagerScript.Instance.dayLength;
        //Debug.Log(degPerTime);
    }

    // Update is called once per frame
    void Update()
    {
        rot.x = degPerTime * Time.deltaTime;
        transform.Rotate(rot, Space.World);
    }
}
