using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Experimental.Rendering.LWRP;
public class LightManager : MonoBehaviour {

  // private GameObject instance;
  public static float lightPos;
  // Start is called before the first frame update
  void Start () {
    //   instance.this.GetComponent<Light2D>();
    lightPos = transform.position.y;
  }

  // Update is called once per frame
  void FixedUpdate () {
    // Debug.Log (ScoreKeeper.scoreValue);
    // if (ScoreKeeper.totalShapes > 10) {
    if (lightPos > -21000) {

      lightPos = lightPos - 3;
    }
      transform.position = new Vector2 (transform.position.x, lightPos);

    // } else {
    // transform.position = new Vector2 (transform.position.x, transform.position.y - 6);
    // transform.position = new Vector2 (transform.position.x, lightPos - 6);
    // }
  }
  void LateUpdate () {

  }
}