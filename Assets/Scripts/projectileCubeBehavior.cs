using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileCubeBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         Destroy(gameObject, 4f );
        //gameObject.GetComponent<Rigidbody>().isKinematic() = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.y < 0 ) {
            Destroy( this.gameObject );
        }

        // movement
        Vector3 targetPos= GameObject.Find("Player").transform.position;
        Vector3 thisPos= gameObject.transform.position;

        Vector3 deltaPos= (targetPos-thisPos);
        Vector3 yForce= Vector3.down*5;

        gameObject.GetComponent<Rigidbody>().AddForce(deltaPos);
        gameObject.GetComponent<Rigidbody>().AddForce(deltaPos);
        gameObject.GetComponent<Rigidbody>().AddForce(yForce);



        // limit speed
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(gameObject.GetComponent<Rigidbody>().velocity , 45);
        gameObject.GetComponent<Rigidbody>().AddForce(yForce);

    }
}
