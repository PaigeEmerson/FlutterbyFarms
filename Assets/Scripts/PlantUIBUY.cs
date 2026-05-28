using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantUIBUY : MonoBehaviour
{
    [SerializeField] Animator moveIn;
    [SerializeField] Animator moveOut;

    [SerializeField] Material dirt;
    [SerializeField] GroundManager manager;
    public void OnEnable()
    {
        moveIn.SetTrigger("SlideInPlantUI");

    }

    public void PlantCrops(GameObject slice)
    {
        manager.ChangeMaterial(slice);
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
