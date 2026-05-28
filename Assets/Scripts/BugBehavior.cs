using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BugBehavior : MonoBehaviour
{
    public Vector3 target;
    [SerializeField] float speed;

    private GameObject moth;
    private GameObject butterfly;

    [SerializeField] Health health;
    // Start is called before the first frame update
    void Start()
    {
        Transform mothTransform = transform.Find("Moth");

        if (mothTransform != null)
        {
            moth = mothTransform.gameObject;
        }

        Transform butterflyTransform = transform.Find("Butterfly");
        if (butterflyTransform != null) 
        {
            butterfly = butterflyTransform.gameObject;
        }
        moth.gameObject.SetActive(false);
        butterfly.SetActive(false);

    }
    private void OnTriggerStay(Collider collision)
    {
        //Debug.Log(collision.tag);
        if (!GameManagerScript.Instance.isDay)
        {
            //switch (collision.tag)
            //{
            //    case string n when n == "Tilled Plot":
            //        Vector3 position1 = collision.transform.position;
            //        target = position1;
            //        Debug.Log("Bug moving to Plot");
            //        break;
            //    case string n when n == "Barn":
            //        Vector3 position = collision.transform.position;
            //        target = position;
            //        Debug.Log("Bug moving to Barn");
            //        break;
            //    default:
            //        //target = RandomPosition();
            //        //Debug.Log("Bug to Random Pos");
            //        break;
            //}

            if (collision.CompareTag("Barn"))
            {
                target = collision.transform.position;
            }
            if (collision.CompareTag("Barn") && collision.CompareTag("TilledPlot"))
            {

            }
            else if (collision.CompareTag("TilledPlot"))
            {
                target = collision.transform.position;
            }
            else if (collision == null)
            {
                target = RandomPosition();
            }
            else
            {
                //nada
            }
        }
        else
        {
            target = RandomPositionFly();
            //Debug.Log("Flyin");
        }
    }


    private Vector3 RandomPositionFly()
    {
        int binaryInt = UnityEngine.Random.Range(0, 2);
        int tmpx;
        if (binaryInt == 0) { tmpx = -1; } else {tmpx  = 1; }

        int binaryInt2 = UnityEngine.Random.Range(0, 2);
        int tmpz;
        if (binaryInt == 0) { tmpz = -1; } else { tmpz = 1; }


        Vector3 tmp = new Vector3(Random.Range(100f, 150f) * tmpx, transform.position.y, Random.Range(100, 150) * tmpz);
        return tmp;
    }

    private Vector3 RandomPosition()
    {
        Vector3 tmp = new Vector3(Random.Range(-150f, 150f), transform.position.y, Random.Range(-150f, 150f));
        return tmp;
    }

    // Update is called once per frame
    void Update()
    {
        float TmpX = Mathf.MoveTowards(transform.position.x, target.x, speed * Time.deltaTime);
        float TmpZ = Mathf.MoveTowards(transform.position.z, target.z, speed * Time.deltaTime);

        transform.position = new Vector3(TmpX, transform.position.y, TmpZ);

        if (GameManagerScript.Instance.isDay)
        {
            moth.SetActive(false);
            butterfly.SetActive(true);
        }
        else
        {
            moth.SetActive(true);
            butterfly.SetActive(false);
        }

        if (!health.alive)
        {
            Destroy(gameObject);
        }
    }
}
