using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Facade
{
    class Microwave
    {
        private Drive _drive;
        private Power _power;
        private Notification _notification;
        public Microwave(Drive drive, Power power, Notification notification)
        {
            _drive = drive;
            _power = power;
            _notification = notification;
        }
        public void Defrost()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 1000;
            _drive.TurlRight();
            _drive.TurlRight();
            _power.MicrowavePower = 500;
            _drive.Stop();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _power.MicrowavePower = 200;
            _drive.Stop();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }
        public void Heating()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 100;
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.Stop();
            _power.MicrowavePower = 200;
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.Stop();
            _power.MicrowavePower = 300;
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.Stop();
            _power.MicrowavePower = 400;
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }
    }
}
