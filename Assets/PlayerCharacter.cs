using UnityEngine;
using System.Collections;
using System.Text;

public class PlayerCharacter : MonoBehaviour
{

    private int _health;
    private Camera cameraHold;
    private Vector3 position;
    private Vector3 screenPointPosition;

    void Start()
    {
        _health = 5;
        cameraHold = Camera.main;
        screenPointPosition = cameraHold.WorldToScreenPoint(position);
    }

    public void Hurt(int damage)
    {
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
            Utility.IsDead = true;
        }

        return builder.ToString();
    }

    public void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(screenPointPosition.x, screenPointPosition.y, 100, 50), Utility.HealthString);
    }

    public void Update()
    {
        if (Utility.IsDead)
        {
            if (screenPointPosition.y + 50 > Screen.height)
            {
                Utility.YDown = true;
            }
            if (screenPointPosition.y < 0)
            {
                Utility.YDown = false;
            }
            if (screenPointPosition.x + 100 > Screen.width)
            {
                Utility.XDown = true;
            }
            if (screenPointPosition.x < 0)
            {
                Utility.XDown = false;
            }

            if (Utility.XDown)
            {
                screenPointPosition.x -= 1;
            }
            else
            {
                screenPointPosition.x += 1;
            }

            if (Utility.YDown)
            {
                screenPointPosition.y -= 1;
            }
            else
            {
                screenPointPosition.y += 1;
            }
        }
    }
}
