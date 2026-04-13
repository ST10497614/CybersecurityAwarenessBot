Cybersecurity Awareness Bot

A C# console chatbot that teaches basic cybersecurity concepts such as password safety, phishing, safe browsing, malware, scams, and suspicious links.
 Overview

This project is a beginner-friendly educational bot built with .NET. It introduces users to important cyber safety topics through simple, text-based interaction in the console.

At startup, the Chatbot:
- Displays a themed console header
- Plays a greeting audio file (Assets/Greetings.wav) when available
- Asks for the user's name
- Provides cybersecurity guidance based on user prompts
Features it has
- Interactive chatbot conversation in the terminal
- Named user profile for personalized responses
- Predefined cybersecurity topic responses
- Styled console output for bot, errors, and success messages
- Optional WAV greeting playback using System.Media.SoundPlayer

Project Structure
- Program.cs - Application entry point and startup flow
- Model/UserProfile.cs - Basic user model
- Services/ChatBotServices.cs - Prompt matching and response routing
- Services/ResponseServices.cs - Cybersecurity response content
- Services/AudioPlayer.cs - Greeting audio playback helper
- UI/ConsoleUI.cs - Console output styling and typing effect

REFERENCES
W3School.1996-2026.https://www.w3schools.com/cs/index.php
