using UnityEngine;
using System.Collections;

public class Foreground : MonoBehaviour {
	Player player;
	void Start()
	{
		player = GetComponentInChildren<Player>();
	}
	
	void Update()
	{
		
	}

	void checkFlags()
	{
		if (player.onFire)
		{
			player.health = player.health - 1;
		}
	}
}
