
# Vorbereitung

<p align="center"><img src="images/logo_devspace.png" width=100/></p>

Um vor Ort Nerven, Zeit und Bandbreite zu sparen, teste bitte deine Dockerumgebung.
Lade dazu bitte die benötigten Images und das Git-Repo herunter.

1) Git-Repo <a href="https://github.com/fpommerening/DevOpenSpace2017.git">DevOpenSpace2017</a> klonen 

2) Docker-Console öffnen und

    a) Docker for Windows: Powershell starten

    b) Docker-Toolbox: Eingabeaufforderung cmd starten und Verbindung herstellen (Siehe <a href="https://docs.docker.com/toolbox/toolbox_install_windows/#step-3-verify-your-installation" target="_blank">Docs</a>)

3) Images herunterladen
    a) manuell
    
        docker pull mongo:3.4.9-jessie
        docker pull microsoft/dotnet:2.0.0-sdk-jessie
        docker pull microsoft/aspnetcore:2.0-jessie
        docker pull node:8.6.0-alpine
        docker pull functions/gateway:0.6.5
        docker pull functions/prometheus:latest
        docker pull functions/alertmanager:latest
    
    b) per Docker-Compose (im geklonten Projektordner)

        docker-compose -f prepare-compose.yml pull
    
