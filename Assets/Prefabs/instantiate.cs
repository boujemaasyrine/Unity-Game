using System.Collections;

using UnityEngine;

public class instantiate : MonoBehaviour
  
{
    public Rigidbody2D cartouche;
    public Transform FilsNavette;
    Rigidbody2D clone;
    // Start is called before the first frame update
    void Start()
    {
       // transform.rotation = Quaternion.identity;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           //Instantiate(cartouche, new Vector3(FilsNavette.position.x, FilsNavette.position.y, FilsNavette.position.z), Quaternion.identity);
          clone=  Instantiate(cartouche, new Vector3(FilsNavette.position.x, FilsNavette.position.y, FilsNavette.position.z), Quaternion.identity) as Rigidbody2D;
           clone.velocity = new Vector3(3000, 0, 0);
            //clone.AddForce(new Vector3(5000, 0, 0));
            Destroy(clone.gameObject, 10);
           // print(clone.position);

        }      
    }

   

}
