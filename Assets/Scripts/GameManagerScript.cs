using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] GameObject TowerBuyUI;

    
    public static GameManagerScript Instance { get; private set; }

    public GameObject selectedButton;
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // Deletes duplicate if you go back to the original scene
        }

        TowerBuyUI.SetActive(false);
    }


   
    // Update is called once per frame
    void Update()
    {
       
    }


}
