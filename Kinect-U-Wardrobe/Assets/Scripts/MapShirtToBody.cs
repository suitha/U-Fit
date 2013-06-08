using UnityEngine;
using System.Collections;

public class MapShirtToBody : MonoBehaviour {
	public GameObject shirt;
	public Vector3 shirtPosition;
	public SkeletonPointClassY skeletonPointClassY;
	public SkeletonController skeltonController;
	public static readonly float shirtZPosition = 2.3f;
	float newY = 0;
	
	// Use this for initialization
	void Start () {
		shirtPosition = shirt.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//cube.transform.position = new Vector3(cube.transform.position.x , skeletonPontClass.LeftShoulder/100, cube.transform.position.z);
		
		if(skeltonController.IsTracking)
		{
			newY = skeletonPointClassY.scaledNewY(skeletonPointClassY.LeftShoulder/1000);
			shirt.transform.position= new Vector3(shirtPosition.x, -0.8f + newY, shirtZPosition);
		}
	}
	
	void OnGUI()
	{
		
		GUILayout.BeginArea (new Rect (Screen.width/3 + 200, Screen.height/2 - 400, 500, 500));
		GUILayout.Box("Test Date" + System.DateTime.Now);
		GUILayout.EndArea();

	}
	

}