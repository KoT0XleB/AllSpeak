using System;
using Qurre;
using Qurre.API.Events;

namespace AllSpeak
{
    public class AllSpeak : Plugin
    {
        public override string Developer => "KoToXleB#4663";
        public override string Name => "AllSpeak";
        public override Version Version => new Version(2, 0, 0);
        public override int Priority => int.MinValue;
        public override void Enable()
        {
            Qurre.Events.Voice.PressPrimaryChat += PressedQ;
            Qurre.Events.Voice.PressAltChat += PressedV;
        }
        public override void Disable()
        {
            Qurre.Events.Voice.PressPrimaryChat -= PressedQ;
            Qurre.Events.Voice.PressAltChat -= PressedV;
        }
        public static void PressedQ(PressPrimaryChatEvent ev)
        {
            ev.Player.Dissonance.MimicAs939 = false;
        }
        public static void PressedV(PressAltChatEvent ev)
        {
            ev.Player.Dissonance.MimicAs939 = true;
        }
    }
}
