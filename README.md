Inaudible Audio Streamer

This project is a Windows application that plays a continuous, inaudible audio stream to keep SONOS speakers active. 
By playing a high-frequency, low-volume signal, the application prevents speakers from entering a power-saving mode, 
ensuring they stay ready for immediate audio output.

Features
Outputs a constant, high-frequency sine wave (inaudible to human ears)
Runs in the background to prevent speaker idle mode
Configurable to run on system startup for continuous operation

Prerequisites
.NET 6 or later installed on your machine.

Installation
Clone this repository to your local machine:
git clone https://github.com/turbobeest/sonos-trick.git

Open the project in Visual Studio Code or your preferred .NET-compatible IDE.
Install the required dependencies by running:
dotnet restore

Usage
Build and Run the Application: In the project directory, run the following command to build and execute the program:
dotnet run -c Release

Run on Startup:
After building, you can copy the .exe file from bin/Release/net6.0 to a permanent 
location (e.g., C:\Program Files\InaudibleAudioStreamer).

Create a shortcut to the executable in the Windows Startup folder:
Press Win + R, type shell:startup, and press Enter.

Copy the shortcut into the Startup folder so the application runs automatically on boot.


Customization
Frequency and Volume: You can adjust the frequency and volume in the Program.cs file if you notice any 
artifacts or need to further optimize for inaudibility. By default, it plays at 20,000 Hz with a low volume.

Technical Details
The application is built with C# and uses the NAudio library for handling audio playback.
The program generates a sine wave at a frequency above 20,000 Hz (the typical upper limit of 
human hearing) with a low gain to remain unobtrusive.

Contributing
Feel free to fork this repository and submit pull requests for improvements, bug fixes, or new features. Contributions are always welcome!
