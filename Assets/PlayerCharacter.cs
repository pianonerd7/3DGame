using UnityEngine;
using System.Collections;
using System.Text;

public class PlayerCharacter : MonoBehaviour {

    private int _health;
    private Camera cameraHold;
    private Vector3 position;
    private Vector3 screenPointPosition;

	void Start() {
		_health = 1;
        cameraHold = Camera.main;
        screenPointPosition = cameraHold.WorldToScreenPoint(position);
	}

	public void Hurt(int damage) {
		_health -= damage;
        Utility.HealthString = GetHealthString();
		Debug.Log("Health: " + _health);
	}

    private string GetHealthString()
    {
        StringBuilder builder = new StringBuilder();
        int health = _health;

        if (health > 0)
        {

            builder.Append("Healthbar \n");
            builder.Append("Health:" + health);

            while (health > 0)
            {
                builder.Append("*");
                health--;
            }
        }
        else
        {
            builder.Append("You have died!");
        }

        return builder.ToString();
    }

    public void OnGUI()
    {
        var screenPX = cameraHold.WorldToScreenPoint(position);
        GUI.contentColor = Color.black;


            GUI.Label(new Rect(screenPX.x, screenPointPosition.y, 100, 50), Utility.HealthString);
        
    }

    public void Update()
    {
        screenPointPosition.y += 1;
        screenPointPosition.x += 1;
    }
}
