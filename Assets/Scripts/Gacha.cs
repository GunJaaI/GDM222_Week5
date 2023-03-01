using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public struct GachaItem {
    public int Amount;
    public GameObject Instance;
}

public class Gacha : MonoBehaviour {
    [SerializeField]
    private List<GachaItem> GachaItemsList;
}
