using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Master : MonoBehaviour {

	private Player player;
	// Target
	public Image image;
	public GameObject healthBar;

	// Parameters
	public float minValue = 0.0f;
	public float maxValue = 1.0f;
	public Color minColor = Color.red;
	public Color maxColor = Color.green;

	// The default image is the one in the gameObject
	void Start()
	{
		player = GetComponentInChildren<Player>();
		if (image == null)
		{
			image = GetComponent<Image>();
		}
	}

	// Health between [0.0f,1.0f] == (currentHealth / totalHealth)
	public void SetHealthVisual(float healthNormalized)
	{
		healthBar.transform.localScale = new Vector3(healthNormalized,
													 healthBar.transform.localScale.y,
													 healthBar.transform.localScale.z);
	}

	void Update()
	{
		SetHealthVisual(player.health / player.MAX_HEALTH);
		// Lerp color depending on the scale factor
		image.color = Color.Lerp(minColor,
								 maxColor,
								 Mathf.Lerp(minValue,
											maxValue,
											transform.localScale.x));
	}
}
