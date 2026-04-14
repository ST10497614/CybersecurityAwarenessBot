using System.Media;

namespace CyberSecurityAwarenessBot.Services
{
    public static class AudioPlayer
    {
        public static void PlayGreeting(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("[Audio file not found. Continuing without voice greeting.]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Could not play audio: {ex.Message}]");
            }
        }

        public static void PlayNotification(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.Play();
                }
                else
                {
                    Console.WriteLine("[Notification audio file not found. Skipping.]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Could not play notification audio: {ex.Message}]");
            }
        }

        public static void PlayFarewell(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("[Farewell audio file not found. Continuing without voice farewell.]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Could not play farewell audio: {ex.Message}]");
            }
        }
    }
}