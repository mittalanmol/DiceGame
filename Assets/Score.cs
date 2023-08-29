using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoretext;
    // Update is called once per frame
    
    void Update()
    {
        scoretext.text = (player.position.z + 46f).ToString("0");
    }
     //Added 46F as the z position is starting from -46. So to make it zero we are adding 46.
}
