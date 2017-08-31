using UnityEngine;
using System.Collections;

public class MainCharacterMove : MonoBehaviour {

	public GameObject character;
	UISprite uiSprite;
	Transform transform;
	// Use this for initialization
	void Start () {
		transform = character.GetComponent<Transform>();
		uiSprite = character.GetComponent<UISprite>();
		StartCoroutine(Move());
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	IEnumerator Move() {
		float direction = 1;
		while(true)
		{
			Vector3 vector3 = transform.position;
			if (vector3.x < -0.2f || vector3.x > 0.2f) {
				direction = direction * -1;
				if (direction == -1) {
					uiSprite.flip = UIBasicSprite.Flip.Horizontally;
				} else {
					uiSprite.flip = UIBasicSprite.Flip.Nothing;
				}
			}
			transform.position = new Vector3(vector3.x-(0.02f * direction), vector3.y, vector3.z);
			yield return new WaitForSeconds(0.2f);
		}
	}
}
