using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{

    [Tooltip("Tiempo incial")]
    public float TiempoInicial;

    [Tooltip("Escala inicial del tiempo")]
    [Range(-10.0f, 10.0f)]
    public float EscalaDeTiempo = 1;

    private Text Tiempo;
    private float TiempoDelFrameConTimeScale = 0f;
    
    private float TiempoEnSegundos = 0f;
   private float  EscalaDeTiempoInicial;

    void Start()
    {
        EscalaDeTiempoInicial = EscalaDeTiempo;

        Tiempo = GetComponent<Text>();

        TiempoEnSegundos = TiempoInicial;

        ActualizarTimer(TiempoInicial);
    }

    private void ActualizarTimer(float tiempoInicial)
    {
        int minutos;
        int segundos ;
        string TiempoTexto;

        if (TiempoEnSegundos < 0) TiempoEnSegundos = 0;

        minutos = (int)TiempoEnSegundos / 60;
        segundos = (int)TiempoEnSegundos % 60;

        TiempoTexto = minutos.ToString("00") + ":" + segundos.ToString("00");

        Tiempo.text = TiempoTexto;
    }

    void Update()
    {
        TiempoDelFrameConTimeScale = Time.deltaTime * EscalaDeTiempo;
        TiempoEnSegundos += TiempoDelFrameConTimeScale;
        ActualizarTimer(TiempoEnSegundos);
    }
}
