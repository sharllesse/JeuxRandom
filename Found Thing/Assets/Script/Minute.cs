using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minute : MonoBehaviour
{
    public float Seconds = 0f;
    public float Minutes = 0f;
    public float Heures = 0f;
    public UnityEngine.UI.Text TextLogAmount;

    private void Start()
    {
        TextLogAmount = GameObject.Find ("Minutes").GetComponent<UnityEngine.UI.Text>();
    }

    private void Update()
    {
        TextLogAmount.text = Minutes.ToString();
        Seconds += Time.deltaTime;

        if (Seconds >= 60f)
        {
            Seconds = 0;
            Minutes++;
        }

        if (Minutes >= 60f)
        {
            Minutes = 0;
            Heures++;
        }
    }
}
