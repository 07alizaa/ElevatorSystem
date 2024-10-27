using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal class EmergencyAlarm
    {
        private readonly SoundPlayer _player;
        private bool _isActive;

        public EmergencyAlarm(string soundFilePath)
        {
            _player = new SoundPlayer(soundFilePath);
        }

        public void Activate()
        {
            if (!_isActive)
            {
                _player.PlayLooping();
                _isActive = true;
            }
        }

        public void Deactivate()
        {
            if (_isActive)
            {
                _player.Stop();
                _isActive = false;
            }
        }

        public bool IsActive => _isActive;
    }
}
