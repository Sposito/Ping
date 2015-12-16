using UnityEngine;
using System.Collections;

public class GameBuilder : MonoBehaviour {

	GameObject mainCamera;
	GameObject directionalLight;
	GameObject leftPad;
	GameObject rightPad;
	GameObject ball;
	GameObject floor;

	void Start () {
		
		Material blackMat = new Material (Shader.Find("Standard"));
		blackMat.color = HexColor.ToColor ("444455");

		mainCamera = new GameObject ("Main Camera", typeof(Camera), typeof(GUILayer), typeof(AudioListener));
		mainCamera.transform.position = new Vector3 (0f, 25f);
		mainCamera.transform.rotation = Quaternion.Euler (Vector3.right * 90);
		var cam = mainCamera.GetComponent<Camera> ();
		cam.fieldOfView = 50f;
		cam.depth = -1;

		directionalLight = new GameObject ("Directional Light", typeof(Light));
		directionalLight.transform.rotation = Quaternion.Euler (50f, 330f, 0f);
		var sun = directionalLight.GetComponent<Light> ();
		sun.type = LightType.Directional;
		sun.color = HexColor.ToColor ("FFF4D6");
		sun.transform.rotation = Quaternion.Euler (50f, 330f, 0f);
		sun.shadows = LightShadows.Soft;

		leftPad = GameObject.CreatePrimitive (PrimitiveType.Cube);
		leftPad.transform.position = Vector3.left * 14;
		leftPad.transform.localScale = new Vector3 (1f, 1f, 5f);
		leftPad.GetComponent<MeshRenderer> ().material = blackMat;

		rightPad = GameObject.CreatePrimitive (PrimitiveType.Cube);
		rightPad.transform.position = Vector3.right * 14;
		rightPad.transform.localScale = new Vector3 (1f, 1f, 5f);
		rightPad.GetComponent<MeshRenderer> ().material = blackMat;

		ball = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		ball.GetComponent<MeshRenderer> ().material = blackMat;

		floor = GameObject.CreatePrimitive (PrimitiveType.Quad);
		floor.transform.position = Vector3.down * 0.5f;
		floor.transform.rotation = Quaternion.Euler(Vector3.right * 90);
		floor.transform.localScale = Vector3.one * 32;






	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
