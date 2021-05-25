using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public DiceBlock redDiceBlock;
    public DiceBlock blueDiceBlock;
    public DiceBlock greenDiceBlock;
    public GameObject menuPanel;

    private void Update()
    {
        if(redDiceBlock.score == redDiceBlock.maxBlocks && blueDiceBlock.score == blueDiceBlock.maxBlocks
            && greenDiceBlock.score == greenDiceBlock.maxBlocks)
        {
            Time.timeScale = 0f;
            menuPanel.SetActive(true);

        }
    }



}
