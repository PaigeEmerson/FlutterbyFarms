using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerPlacementOnClick : MonoBehaviour, ISelectHandler
{
    [SerializeField] GameObject tower;
    [SerializeField] GameObject TowerBuyUI;
    

    // Start is called before the first frame update
    public void OnSelect(BaseEventData eventData)
    {
        TowerBuyUI.SetActive(true);
        GameManagerScript.Instance.selectedButton = this.gameObject;
        Debug.Log("Selected Button: " + GameManagerScript.Instance.selectedButton);
    }

    public void OnDeslect(BaseEventData eventData)
    {
        TowerBuyUI.SetActive(false);
        Debug.Log("Deselected Button");
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
