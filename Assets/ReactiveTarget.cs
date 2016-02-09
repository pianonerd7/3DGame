using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {

    public GameObject _tombstone;
    public GameObject _enemyPrefab;
    private GameObject _enemy;

	public void ReactToHit() {
		WanderingAI behavior = GetComponent<WanderingAI>();
		if (behavior != null) {
			behavior.SetAlive(false);
		}
		StartCoroutine(Die());
	}

	private IEnumerator Die() {

		this.transform.Rotate(90, 0, 0);

		yield return new WaitForSeconds(1.0f);

        Instantiate(_tombstone, new Vector3(this.transform.position.x, 2, this.transform.position.z), _tombstone.transform.rotation);
        Utility.AddTargetEnemy();

        Destroy(this.gameObject);
	}
}
