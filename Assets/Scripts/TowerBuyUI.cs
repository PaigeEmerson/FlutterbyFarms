using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuyUI : MonoBehaviour
{

    [SerializeField] Animator moveIn;
    [SerializeField] Animator moveOut;
    [SerializeField] GameObject waterTower;
    [SerializeField] GameObject defenseWater;

    Transform childTransform;
    // Start is called before the first frame update
    public void OnEnable()
    {
        moveIn.SetTrigger("SlideIN");

    }

    //public void OnDisable()
    //{
    //    moveOut.SetTrigger("SlideOut");
    //}

    //public void OnClose()
    //{
    //    moveOut.SetTrigger("SlideOut");
    //    Debug.Log("MoveOut Button");
        
    //}

    public void PlaceTower(GameObject tower)
    {
        Vector3 spawnPosition = transform.position;
        Quaternion spawnRotation = Quaternion.identity;

        Instantiate(tower, spawnPosition, spawnRotation);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
