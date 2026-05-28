using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] GameObject TowerBuyUI;

    public bool gameRun;
    public bool isDay;

    public int timePassed;

    
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

    private void Start()
    {
        gameRun = true;
    }

    private void IncrementTime()
    {
        timePassed++;
    }
   
    // Update is called once per frame
    void Update()
    {
       if (gameRun)
        {
            IncrementTime();
        }
    }


}
