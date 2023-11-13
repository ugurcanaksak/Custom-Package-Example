using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public TMP_Text PlayerName;
    void Start()
    {
        PlayerName.text=Player.Instance.PlayerName();
    }



}
