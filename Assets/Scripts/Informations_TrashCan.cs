using UnityEngine;
using TMPro; // Pour le texte joli

public class InfosPoubelle : MonoBehaviour
{
    public bool estOuverte = false; // Notre simulateur d'ESP32
    public TextMeshProUGUI texteEtat; // Ton texte à l'écran

    void Update()
    {
        // On met à jour le texte en fonction de la variable
        if (estOuverte) {
            texteEtat.text = "État : OUVERTE";
            texteEtat.color = Color.green;
        } else {
            texteEtat.text = "État : FERMÉE";
            texteEtat.color = Color.red;
        }
    }

    // Cette fonction simule l'arrivée d'un signal
    public void ChangerEtat() {
        estOuverte = !estOuverte;
    }
}