using System;
using UnityEngine;
using System.Globalization;
using TMPro;

public class TimeText : MonoBehaviour
{
    private TextMeshPro time;

    private void Start()
    {
        time = GetComponent<TextMeshPro>();
    }


    private void Update()
    {
        DateTime dateToDisplay = DateTime.Now;

        time.text = dateToDisplay.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));

    }
}
