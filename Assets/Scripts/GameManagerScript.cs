using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] GameObject TowerBuyUI;
    [SerializeField] GameObject PlantUI;

    public bool gameRun;
    public bool isDay;

    public float timePassed;
    public int daysPassed;
    public float dayLength;

    [SerializeField] Material tilledSoil;


    public static GameManagerScript Instance { get; private set; }

    public GameObject selectedButton;

    public GameObject currentPlotSelection;
    
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
        PlantUI.SetActive(false);
    }

    private void Start()
    {
        gameRun = true;
        isDay = false;
    }

    private void IncrementTime()
    {
        timePassed = timePassed + Time.deltaTime;
        daysPassed = (int)(timePassed / dayLength) ;
    }
   
    // Update is called once per frame
    void Update()
    {
       if (gameRun)
        {
            IncrementTime();
        }

       if (timePassed % dayLength > (dayLength / 2))
        {
            isDay = false;
        }
        else
        {
            isDay = true;
        }
    }

    public void Plant()
    {
        currentPlotSelection.tag = "TilledPlot";
        currentPlotSelection.GetComponent<MeshRenderer>().material = tilledSoil;
        currentPlotSelection.GetComponent<GroundTile>().planted = true;
    }
    


}
