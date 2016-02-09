using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy;
	
	void Update() {
		while (Utility.NumEnemy < Utility.TargetEnemy) {
			_enemy = Instantiate(enemyPrefab) as GameObject;
			_enemy.transform.position = new Vector3(0, 1, 0);
			float angle = Random.Range(0, 360);
			_enemy.transform.Rotate(0, angle, 0);

            Utility.AddNumEnemy();

            Debug.Log("expected en: " + Utility.TargetEnemy + " , actual en: " + Utility.NumEnemy);
		}
	}
}
