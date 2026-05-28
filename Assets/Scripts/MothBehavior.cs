using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothBehavior : MonoBehaviour
{
    public int mothDamage = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TilledPlot") || other.CompareTag("Barn"))
        {
            Health collidedHealth = other.gameObject.GetComponent<Health>();
            collidedHealth.DecrementHealth(mothDamage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
