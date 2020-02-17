using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour {
//public Text message;
// Use this for initialization
  public float speed = 2f;
  private Rigidbody rigidBody; // 1.- The private variable
  private GameObject porta;
  private bool obertTancat = false;
// Use this for initialization
  void Start () {
// 2.- Accessing to the RigidBody component of the object: Only on time!
  rigidBody = GetComponent<Rigidbody>();
  porta = GameObject.FindWithTag("Porta");
//Debug.Log("Starting the game -------------------");
  }
// Update is called once per frame
  void Update () {
// 3.- Using rigidBody every time. Pay attention to the mass of the object!
  rigidBody.AddForce(new Vector3 (Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")));
  }
    void OnCollisionEnter(Collision other) {
      if (other.gameObject.tag == "OpenDoor" && obertTancat == false) {
        // Opening the door
        obertTancat = true;
        porta.transform.Rotate(0, -90, 0);
        porta.SendMessage("Play"); // Play the sound
        //ShowText("Door open");
      }else if (other.gameObject.tag == "CloseDoor" && obertTancat == true) {
        // Close the door
        obertTancat = false;
        porta.transform.Rotate(0, 90, 0);
        porta.SendMessage("Play");
        //ShowText("Door open");
      }

    }

}
