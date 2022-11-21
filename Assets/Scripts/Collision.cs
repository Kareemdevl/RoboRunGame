using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    Vector3 IntialPosition = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        IntialPosition = transform.position;
        //Debug.Log(IntialPosition);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("Obstical"))
        {
            transform.position = IntialPosition;
        }

        if (other.gameObject.CompareTag("Win"))
        {
            Debug.Log("You Win");
            Time.timeScale = 0;

        }
    }

}
