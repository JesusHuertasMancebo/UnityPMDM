using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // For the Texdt class
using System; // For the String class
public class BouncingJump : MonoBehaviour {
// Jumping until stop
  public float initJumpValue = 5.0f; private float jumpValue;
  private Rigidbody rigidBody;
  private bool start = false;
// Start is called before the first frame update
  void Start() { rigidBody = GetComponent<Rigidbody>(); }
  void Update () {
    if (Input.GetButtonDown("Jump") ){
      start = true; jumpValue = initJumpValue;
    }
    if (start) { // After the first jump
// Jumping and arriving at ground
    if (Mathf.Abs (rigidBody.velocity.y) < 0.01f ) {
      jumpValue -= initJumpValue / 4; // 4 bouncings
      rigidBody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
    }
    if (jumpValue < 0.0f) start = false; // Stop bouncing
    }
  }
}
