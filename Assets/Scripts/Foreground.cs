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
}
