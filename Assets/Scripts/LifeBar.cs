using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void ChangeMaxLife(float maxLife)
    {
        slider.maxValue = maxLife;
    }

    public void ChangeCurLife(float lifeQty)
    {
        slider.value = lifeQty;
    }

    public void InitializeLifeBar(float lifeQty)
    {
        ChangeMaxLife(lifeQty);
        ChangeCurLife(lifeQty);
    }
}
