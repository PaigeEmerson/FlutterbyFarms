using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float MaxHealth;
    public bool alive;
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
    }

    public void DecrementHealth(int health)
    {
        if (alive)
        {
            MaxHealth -= health * Time.deltaTime;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (MaxHealth < 0)
        {
            alive = false;
        }
    }
}
