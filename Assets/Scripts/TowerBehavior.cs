using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehavior : MonoBehaviour
{
    [SerializeField] GameObject bullet;


    public Transform target;
    public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moth"))
        {
            target = (Transform)other.transform;
            Transform topTransform = transform.Find("top");


            Vector3 direction = target.position - topTransform.position;

            // Create the rotation we want to reach
            Quaternion targetRotation = Quaternion.LookRotation(direction);



            // Smoothly rotate towards that target rotation
            topTransform.rotation = Quaternion.Slerp(topTransform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            //Instantiate(bullet(other.gameObject));
        }
    }
}
