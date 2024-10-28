using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace InaudibleAudioStreamer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Frequency above the typical human hearing range (20 kHz)
            const double frequency = 19999.9;
            const int sampleRate = 44100;
            const float volume = 0.1f; // Low volume to prevent any possible artifacts

            var signalGenerator = new SignalGenerator(sampleRate, 1)
            {
                Gain = volume,
                Frequency = frequency,
                Type = SignalGeneratorType.Sin
            };

            using (var waveOut = new WaveOutEvent())
            {
                waveOut.Init(signalGenerator);
                waveOut.Play();

                Console.WriteLine("Inaudible audio stream is now playing. Press Ctrl+C to exit.");

                // Keep the application running
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
