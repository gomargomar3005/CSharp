using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegues_03
{

    delegate void DelegateProgram();
    internal class CDPlayer
    {
        private CompactDisk _cd;

        private DelegateProgram _program;

        public CDPlayer()
        {
            
        }

        public void PutCD(CompactDisk cd)
        {
            _cd = cd;
        }

        public void Play()
        {
            if (_cd is null) Console.WriteLine("Pas de disque...");
            if (_program != null) _program();
            else
            {
                for (int i = 0; i < _cd.TimeTracks.Length; i++)
                {
                    int time = _cd.TimeTracks[i];
                    Console.WriteLine($"Je commence à lire la piste {i + 1} à {time} sec de lecture...");
                    Console.Beep(144, 200);
                }
            }
        }

        public void AddToProgram(int trackNb)
        {
            _program += GeneratePlay(trackNb);
        }

        private DelegateProgram GeneratePlay(int trackNb)
        {
            int timeTrack = _cd.TimeTracks[trackNb-1];
            return delegate () { 
                Console.WriteLine($"Je commence à lire la piste {trackNb} à {timeTrack} sec de lecture...");
                Console.Beep(144, 200);
            };
        }
    }
}
