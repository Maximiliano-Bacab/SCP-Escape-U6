using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour

{
    [SerializeField] private float Health;
    [SerializeField] private float mxmLife;
    [SerializeField] private LifeBar lifeBar;

    void Start()
    {
        Health = mxmLife;
        lifeBar.InitializeLifeBar(Health);
    }

    public void RecibirDanio(int cantidad)
    {
        Health -= cantidad;
        lifeBar.ChangeCurLife(Health);
        if (Health <= 0)
        {
            // Si la salud llega a cero, el jugador puede morir aquí
            // Por ejemplo, puedes cargar una escena de Game Over o reiniciar el nivel
            Debug.Log("¡El jugador ha muerto!");
        }
    }
}
