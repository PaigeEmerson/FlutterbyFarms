using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] Material tilledSoil;
    [SerializeField] Material grass;

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
        //ChangeMaterial(slice, tilledSoil);
    }

    private void ToGrass(GameObject slice)
    {
        slice.GetComponent <Renderer>().material = grass;
        //ChangeMaterial(slice, grass);
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

                
            }
        }
    }

}
