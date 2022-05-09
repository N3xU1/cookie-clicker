using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
 void Update()
 {
  // 50*
  transform.Rotate (0,0,50*Time.deltaTime);
 }
}
