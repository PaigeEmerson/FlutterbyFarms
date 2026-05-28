using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    void LateUpdate()
    {
        // Option A: Matches camera's rotation exactly (better for flat look)
        transform.rotation = Camera.main.transform.rotation;

        // Option B: Points specifically at the camera (can cause "tilt" if camera is above/below)
        // transform.LookAt(Camera.main.transform.position, Vector3.up);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
