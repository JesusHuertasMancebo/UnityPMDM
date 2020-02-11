using System.Collections; using System.Collections.Generic; using UnityEngine;
using UnityEngine.UI; // For the Texdt class
using System; // For the String class
public class StartStop : MonoBehaviour {
private Rigidbody rigidBody; private bool firstBackSpace = true;
public int jumpValue = 2; public Text missatge; public float forceValue = 1;
void Start() {
rigidBody = GetComponent<Rigidbody>();
ShowText("Ready to jump and move. Press space bar and arrow keys");
}
private void FixedUpdate() {
if (Input.GetButtonDown("Jump")) { // Backspace key
if (firstBackSpace) { // Stop movement
forceValue = 0; rigidBody.drag = 10; firstBackSpace = false;
ShowText("Stop movement"); print("Force value = " + forceValue);
}
else {// Start movement
forceValue = 1; rigidBody.drag = 0; firstBackSpace = true ;
ShowText("Start movement"); print("Force value = " + forceValue);
}
}
// Applying forces to our rígid body
rigidBody.AddForce(new Vector3 (Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical"))*forceValue);
}
void ShowText(String aux ) { missatge.text = aux; }
}
