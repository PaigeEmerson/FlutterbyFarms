using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField] float bulletSpeed;
    private GameObject targetObject;
    [SerializeField] int bulletDamage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
        if (targetObject != null)
        {
            transform.position += -Vector3.forward * bulletSpeed * Time.deltaTime;

            transform.LookAt(targetObject.transform);
            //Vector3 targPosition = targetObject.transform.position;
            //Vector3 currentPos = transform.position;

            //float tmpX = Mathf.MoveTowards(targPosition.x, currentPos.x,   Time.deltaTime/10000000);
            //float tmpZ = Mathf.MoveTowards(targPosition.z, currentPos.z,   Time.deltaTime/10000000);

            //transform.position = new Vector3(tmpX, transform.position.y, tmpZ);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Moth"))
        {
            Health mothHealth= other.GetComponent<Health>();
            mothHealth.DecrementHealth(bulletDamage);
        }
    }

    public void SetTarget(GameObject target)
    {
        targetObject = target;
    }
}
