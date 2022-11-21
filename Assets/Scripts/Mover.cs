using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    

    [SerializeField] float speed = 3f;

    /*
    [SerializeField] int WholeNumber = 0;
    [SerializeField] float fraction = 1.5f;
    [SerializeField] string mytext = "This is a new string";
    [SerializeField] bool Mybool = true;
    */
    // Start is called before the first frame update

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //if (WholeNumber <=1000);
        //{
        //WholeNumber = WholeNumber + 1;
        //Debug.Log(WholeNumber);
        //}
        transform.position = transform.position + new Vector3(0f, 0f, 1f) * Time.deltaTime * speed;
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalMovement, 0, verticalMovement);
        transform.position = transform.position + movementDirection * speed * Time.deltaTime;
       //Debug.Log(movementDirection);


    }

}
