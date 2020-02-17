using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
// To follow an object keeping an offset distance
  public GameObject target; // The object to follow
  private Vector3 offset; // The distance
  void Start () {
    offset = transform.position - target.transform.position;
  }
  void LateUpdate() {
    // To move the camera AFTER the sphere
    // keeping always the same distance (offset)
    transform.position = target.transform.position + offset;
  }
}
