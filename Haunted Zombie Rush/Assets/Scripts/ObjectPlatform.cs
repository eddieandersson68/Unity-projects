using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlatform : MonoBehaviour {

    [SerializeField] private float objectSpeed =1;
    [SerializeField] private float resetPosition = -24.9f;
    [SerializeField] private float startPosittion = 77.66f;
    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame
	protected virtual void Update () {
        if (!GameManager.instance.GameOver ) {
            transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime));

            if (transform.localPosition.x <= resetPosition) {
                Vector3 newPos = new Vector3(startPosittion, transform.position.y, transform.position.z);
                transform.position = newPos;
            } 
        
        }
    }
}
