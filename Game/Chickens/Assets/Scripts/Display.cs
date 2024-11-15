using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Display : Observer
{
    public County _key;
    public TextMeshProUGUI _coolText;
    int ChickCount;

    private void Start()
    {

    }

    public override void Notify(Subject subject)
    {
        ChickCount++;
        _coolText.text = "Chickens: " + ChickCount;
    }
}
