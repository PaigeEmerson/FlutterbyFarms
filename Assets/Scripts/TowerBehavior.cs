using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class TowerBehavior : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject BulletSpawn;
    [SerializeField] GameObject towerTop;

    private ArrayList bugList;


    public Transform target;
    public float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 tmp = new Vector3(target.position.x, towerTop.transform.position.x, target.position.z);

            towerTop.transform.LookAt(tmp);

        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Moth"))
        {
            target = (Transform)other.transform;
            //Transform topTransform = towerTop.transform;

            bugList.Add(target);

            //Vector3 direction = target.position - topTransform.position;

            //// Create the rotation we want to reach
            //Quaternion targetRotation = Quaternion.LookRotation(direction);



            //// Smoothly rotate towards that target rotation
            ////topTransform.rotation = Quaternion.Slerp(topTransform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            //topTransform.up = direction.normalized;
            //Instantiate(bullet(other.gameObject));


            Shoot(other.gameObject);
            Debug.Log("Shooting Bug");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Moth"))
        {
            target = (Transform)other.transform;
            bugList.Remove(target);
        }
    }

    public void RemoveTarget(Transform item)
    {
         bugList.Remove(item);
    }


    private void Shoot(GameObject BulletTarget)
    {
        Transform bulletSpawnTransform = BulletSpawn.transform;

        GameObject bullt = Instantiate(bullet, bulletSpawnTransform);

        BulletBehavior proj = bullt.GetComponent<BulletBehavior>();

        proj.SetTarget(BulletTarget);
        //get location of where cannon is
        //instantiate a bullet there
        //set target of projectile


    }
}
