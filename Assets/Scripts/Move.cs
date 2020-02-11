using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
  public float speed = 2f;
  public float forceValue = 5f;
  //public Text message;

  private Rigidbody rigidBody; // 1.- The private variable
  // Use this for initialization
  void Start () {
    // 2.- Accessing to the RigidBody component of the object: Only on time!
    rigidBody = GetComponent<Rigidbody>();

    // Showing a text into the console
    //debug.Log("Starting the game ------------" + message);

  }
  // Update is called once per frame
  void Update () {
    // 3.- Using rigidBody every time. Pay attention to the mass of the object!
  rigidBody.AddForce(new Vector3 (Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")));
  }
}
