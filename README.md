# Projet Smart Trash Scans :

### ** Qu'est-ce que c'est ? **
- Système intelligent de gestion des déchets pour une ville avec monitoring en Réalité Augmentée. 
- Infrastructure IoT (Arduino) détectant l'état des poubelles (Pleine/Vide/Renversée) via des capteurs sensoriels. 
- Interface Unity AR affichant le statut en temps réel et le trajet d'optimisation du camion de collecte.

---
## **1 -> Initialisation Unity VR**
Pour que l'application puisse communiquer avec le matériel du téléphone et gérer la réalité augmentée sans crash, plusieurs réglages spécifiques sont nécessaires dans les Project Settings.

### A. Gestion des Plugins XR
Allez dans XR Plug-in Management et cochez Google ARCore dans l'onglet Android.

Sous l'onglet Google ARCore, passez le paramètre Depth sur Optional. Cela permet à l'application de démarrer même si le capteur de profondeur met du temps à s'initialiser, évitant les erreurs NOT_FOUND au lancement.

### B. Configuration de la Caméra AR
Sur l'objet Main Camera de votre scène, vérifiez les composants suivants :

AR Camera Manager : Gère le flux vidéo réel du téléphone.

AR Camera Background : Permet d'afficher ce flux en arrière-plan de vos objets 3D.

AR Pose Driver : Crucial pour que les objets virtuels (comme les poubelles) restent fixés au sol quand vous déplacez le téléphone.

---

## **2 -> Optimisation et déploiement Android**
Le passage par le moteur IL2CPP est obligatoire pour les performances de l'AR et la compatibilité 64 bits.

### A. Réglages du Player (Player Settings)
Dans Player > Other Settings, configurez les paramètres suivants pour éviter les erreurs de type LOW_MEMORY :

Scripting Backend : Sélectionnez IL2CPP. Cela compile le code C# en code machine plus performant.

Target Architectures : Décochez ARMv7 et cochez impérativement ARM64. Les téléphones modernes exigent cette architecture pour allouer suffisamment de mémoire vive aux calculs AR.

### B. Build et Installation
Ouvrez la fenêtre Build Profiles.

Assurez-vous que votre scène AR est la seule cochée ou placée en index 0 pour qu'elle se lance au démarrage.

Connectez votre téléphone en mode Débogage USB et cliquez sur Build and Run.

