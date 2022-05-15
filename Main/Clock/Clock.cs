using System.Threading;

namespace Main {
    public static class Clock {

        public static int Minutes { get; set; }
        public static int Hours { get; set; }
        public static int Days { get; set; }

        public static void Start() {

            TimerCallback timerCallback = new TimerCallback(Time);
            Timer timer = new Timer(timerCallback, null, 0, 900);
            
        }

        private static void Time(object obj) {
            Minutes++;
            if(Minutes == 60) { Minutes = 0; Hours++; if(Hours >= 24) { Hours = 0; Days++; } }
        }

        public static string PrintTime() { return string.Format(Hours + ":" + Minutes); }

    }
}