using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
public Image playerCard;
public Image cpuCard;

public TextMeshProUGUI playerText;
public TextMeshProUGUI cpuText;

public int playerScore;
public int cpuScore;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnDealButtonPressed(){
    	int left = Random.Range(2, 15);
    	int right = Random.Range(2, 15);

    	playerCard.sprite = Instantiate(Resources.Load<Sprite>("card" + left));
    	cpuCard.sprite = Instantiate(Resources.Load<Sprite>("card" + right));
	
    	if(left > right){
    	   playerScore = playerScore + 1;
	   playerText.text = "Player: " + playerScore;
	   
	}
	else if (right > left){
                cpuScore = cpuScore + 1;
        cpuText.text = "Cpu: " + cpuScore;
           
	}

    }
}
