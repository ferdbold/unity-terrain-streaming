using UnityEngine;
using System.Collections.Generic;

public class TerrainStreamer : MonoBehaviour {

	[Tooltip("The terrain prefab to tile")]
	[SerializeField]
	private Terrain _terrain;

	[Header("Streaming Properties")]
	[SerializeField]
	private float _outerconeLimit = 40f;

	[SerializeField]
	private float _innerRingLimit = 10f;

	[SerializeField]
	private float _coneRadius = 45f;
	
	private Camera _camera;
	private List<List<Terrain>> _terrainMatrix = new List<List<Terrain>>();
	
	void Awake () {
		_camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
