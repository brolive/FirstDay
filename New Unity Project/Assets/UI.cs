using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
	public Image healthBar;
	public Text scoreText;
	public Button button;

public float health = 100;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	healthBar.fillAmount = health/100;
	if(healthBar.fillAmount < 0.25f)
		healthBar.color = Color.red;
        
    }

	public void DoAThing()
	{
		Debug.Log("DID THE THING");
		health -= 10;
		scoreText.text = "health: " + health;
	}
}
