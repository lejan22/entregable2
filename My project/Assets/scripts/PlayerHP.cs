using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private bool isGameOver;
[SerializeField] private int playerHP = 150;
[SerializeField] public int damage = 60;


 
    
// Start is called before the first frame update
    void Start()
    {
       Debug.Log(playerHP - damage);
 
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP <= 0)
        {
            Debug.Log("Te has quedado sin vida...GAMEOVER");
        }else if (playerHP < 30)
        {
            Debug.Log("¡¡¡Tienes poca vida!!!");
        }
        else
        {
            Debug.Log("Vas bien de vida: tienes {playerHP} puntos de vida");
        }
        if (isGameOver = true)
        {
            Debug.Log("GAME OVER");
        }

    }


}
