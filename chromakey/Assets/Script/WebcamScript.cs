using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebcamScript : MonoBehaviour
{
  int width = 1920;
  int height = 1080;
  int fps = 30;
  WebCamTexture webcamTexture;

  void Start () {
    WebCamDevice[] devices = WebCamTexture.devices;
    webcamTexture = new WebCamTexture(devices[0].name, this.width, this.height, this.fps);
    GetComponent<Renderer> ().material.mainTexture = webcamTexture;
    webcamTexture.Play();

    GameObject obj = GameObject.Find("Camera");
    Vector3 scale = obj.transform.localScale;
    scale.x = -scale.x;
    obj.transform.localScale = scale;
  }
}
