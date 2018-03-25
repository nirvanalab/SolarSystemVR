using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour {
    public Transform OrbitPivot;
    public float OrbitSpeed;
    public float RotationSpeed;
    public float DistanceFromStar;
    public float PlanetRadius;

	// Use this for initialization
	void Start () {
        Vector2 randomPosition = Random.insideUnitCircle;
        transform.position = new Vector3(randomPosition.x, 0f, randomPosition.y) * DistanceFromStar;
        transform.localScale = Vector3.one * PlanetRadius;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(OrbitPivot.position, Vector3.up, Time.deltaTime * OrbitSpeed);
        this.transform.Rotate(Vector3.up, Time.deltaTime * RotationSpeed);
	}
}
