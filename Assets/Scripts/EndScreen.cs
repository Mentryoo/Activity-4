using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public void Initialize(string winnerName) {
        if (winnerName == null) {
            text.text = "Winner Winner Chicken Adobo";
        } else {
            text.text = "You Lose " + winnerName + " Won";
        }
    }
}
