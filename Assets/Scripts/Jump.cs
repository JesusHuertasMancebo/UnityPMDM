using System.Collections; using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // For the Texdt class
using System; // For the String class
public class Jump : MonoBehaviour {
  public int jumpValue = 2;
  private Rigidbody rigidBody;
// The attribute to control the text
  public Text missatge;
// Start is called before the first frame update
  void Start() {
    rigidBody = GetComponent<Rigidbody>();
    ShowText("Ready to jump. Press space bar");
  }
  void Update () {
    if (Input.GetButtonDown("Jump") &&
    Mathf.Abs (rigidBody.velocity.y) < 0.01f) {
      ShowText("Jumping");
      rigidBody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
    }
  }
  void ShowText(String aux ) {
    missatge.text = aux;
  }
}
