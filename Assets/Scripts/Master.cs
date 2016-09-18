using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Master : MonoBehaviour
{

	private int cactusKillCount;
	private int enemyKillCount;

	private Player player;
	private Text hp, cact, enemy, floatInstructions;
	// Target
	public Image image;
	public GameObject healthBar;

	// Parameters
	public float minValue = 0.0f;
	public float maxValue = 1.0f;
	public Color minColor = Color.red;
	public Color maxColor = Color.green;

	// The default image is the one in the gameObject
	void Start ()
	{
		player = GetComponentInChildren<Player> ();
		Text[] texts = GetComponentsInChildren<Text>();
		foreach (Text text in texts)
		{
			if (text.name.Equals("HP"))
			{
				hp = text;
			}
			else if (text.name.Equals("Cact"))
			{
				cact = text;
			}
			else if (text.name.Equals("Enemy"))
			{
				enemy = text;
			}
			else if (text.name.Equals("Instruction"))
			{
				floatInstructions = text;
			}
		}
		if (image == null) {
			image = GetComponent<Image> ();
		}

		Destroy(floatInstructions, 8.0f);
	}

	// Health between [0.0f,1.0f] == (currentHealth / totalHealth)
	public void SetHealthVisual (float healthNormalized)
	{
		healthBar.transform.localScale = new Vector3 (healthNormalized,
			healthBar.transform.localScale.y,
			healthBar.transform.localScale.z);
	}

	void FixedUpdate ()
	{
		cactusKillCount = Cactus.killed;
		enemyKillCount = Enemy.killed;

		hp.text = "HP: " + player.health;
		cact.text = "Cacti killed: " + cactusKillCount + " D:";
		enemy.text = "Enemies killed: " + enemyKillCount + " :)";
		//SetHealthVisual(player.health / player.MAX_HEALTH);
		// Lerp color depending on the scale factor
		/*
		image.color = Color.Lerp(minColor,
								 maxColor,
								 Mathf.Lerp(minValue,
											maxValue,
											transform.localScale.x));
		*/
	}
}
