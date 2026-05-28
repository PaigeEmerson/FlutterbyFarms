using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] Material tilledSoil;
    [SerializeField] Material grass;
    [SerializeField] Material deadDirt;

    [SerializeField] Health health;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeMaterial(GameObject slice)
    {
        if (slice.GetComponent<Renderer>().material = grass)
        {
            ToTilledSoil(slice);
        }
        else
        {
            ToGrass(slice);
        }
       
    }

    private void ToTilledSoil(GameObject slice)
    {
        slice.GetComponent<Renderer>().material = tilledSoil;
        slice.tag = "TilledPlot";
        //ChangeMaterial(slice, tilledSoil);
    }

    private void ToGrass(GameObject slice)
    {
        slice.GetComponent <Renderer>().material = grass;
        slice.tag = "Plot";
        //ChangeMaterial(slice, grass);
    }

    private void ToDeadDirt(GameObject slice)
    {
        slice.tag = "DeadPlot";
        slice.GetComponent<Renderer>().material = deadDirt;
        
    }






    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // This is the object you clicked on
                GameObject selectedObject = hit.collider.gameObject;
                if (selectedObject == this.gameObject)
                {
                    ChangeMaterial(this.gameObject);
                }
                
            }
        }

        if (!health.alive)
        {
            ToDeadDirt(this.gameObject);
        }
    }

}
