using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    [SerializeField] Material tilledSoil;
    [SerializeField] Material grass;
    [SerializeField] Material deadDirt;
    [SerializeField] Material selected;

    [SerializeField] Health health;

    [SerializeField] GameObject PlantBuyUI;

    private GameObject currentSelection;
    private GameObject previousSelection;
    public bool planted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && (hit.transform.tag == "Plot" || hit.transform.tag == "TilledPlot" || hit.transform.tag == "DeadPlot"))
            {
                // This is the object you clicked on
                GameObject selectedObject = hit.collider.gameObject;
                if (GameManagerScript.Instance.currentPlotSelection == null || GameManagerScript.Instance.currentPlotSelection != selectedObject)
                {
                    if (selectedObject.tag == "Plot" && !planted)
                    {
                        previousSelection = GameManagerScript.Instance.currentPlotSelection;
                        GameManagerScript.Instance.currentPlotSelection = selectedObject;
                        currentSelection = selectedObject;
                        if (currentSelection != previousSelection && !planted)
                        {
                            selectedObject.GetComponent<MeshRenderer>().material = selected;
                            if (previousSelection != null && selectedObject.tag != "TilledPlot")
                            {
                                Debug.Log(planted);
                                previousSelection.GetComponent<MeshRenderer>().material = grass;
                            }

                        }
                    }

                       
                }

                
                if (selectedObject == this.gameObject)
                {


                    if (!PlantBuyUI.activeInHierarchy)
                    {
                        PlantBuyUI.SetActive(true);
                        //ChangeMaterial(this.gameObject);
                    }
                }

            }
        }

    }
}
