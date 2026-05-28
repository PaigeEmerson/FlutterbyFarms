using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceTower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject tower;
    //public Transform CurrentButtonTransform;

    public void PlaceTowerObject(GameObject tower)
    {
        GameObject selectedObj = GameManagerScript.Instance.selectedButton;
        Transform CurrentButtonTransform = selectedObj.transform;
        CurrentButtonTransform.localScale = Vector3.one;
        //CurrentButtonTransform.rotation = new Quaternion(90f, 0f, 0f, 0f);


        Instantiate(tower, CurrentButtonTransform.position, Quaternion.identity);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
