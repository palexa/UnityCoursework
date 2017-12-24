using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts;

namespace Assets.Scripts
{
    static class Izmer
    {
        public static bool AmperIsOn { get; set; }
        public static bool IzmerIsOn { get; set; }
        public static bool IsOn { get; set; }
        public static bool PITisOn { get; set; }
        public static float Temperature { get; set; }
        public static int Napryazhenie { get; set; }
        private const float f = 12;
        private const float d = 0.018f;//Наружный диаметр трубы 18мм
        private const float l = 0.847f;//Длина трубы 847mm
        private const float r = 7.4e-3f;
        private static float[] u = {0.8f,1,1.2f,1.4f};
        static Izmer()
        {
            
        }
        public static void Prib()
        {
            if (IsOn)
            {

            }
        }
        private static bool AllEnabled()
        {
            if (AmperIsOn && IzmerIsOn && IsOn && PITisOn)
                return true;
            else return false;
        }
    }
}
