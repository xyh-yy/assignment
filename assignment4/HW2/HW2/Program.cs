namespace HW2
{
    public class AlarmClock
    {
        // 委托
        public delegate void TickHandler();
        public delegate void AlarmHandler();

        //事件
        public event TickHandler Tick;     // 嘀嗒事件
        public event AlarmHandler Alarm;   // 响铃事件

        //时间
        private int hour, minute, second;
        private int alarmHour, alarmMinute ,alarmSecond;

        //定义响铃时间
        public AlarmClock(int alarmHour, int alarmMinute,int alarmSecond)
        {
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
            this.alarmSecond = alarmSecond;
        }

        // 每秒钟走一格，模拟时间的流逝
        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000); // 每秒走一次
                second++;

                if (second == 60)
                {
                    second = 0;
                    minute++;
                }

                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                }

                if (hour == 24)
                {
                    hour = 0;
                }

                // 触发Tick事件
                OnTick();

                // 检查是否触发Alarm事件
                if (hour == alarmHour && minute == alarmMinute && second == alarmSecond)
                {
                    OnAlarm();
                    break;
                }
            }
        }

        // 触发Tick事件的方法
        protected virtual void OnTick()
        {
            Tick?.Invoke();
        }

        // 触发Alarm事件的方法
        protected virtual void OnAlarm()
        {
            Alarm?.Invoke();
        }
    }

    public class AlarmClockSubscriber
    {
        public void HandleTick()
        {
            Console.WriteLine("Tick");
        }

        public void HandleAlarm()
        {
            Console.WriteLine("Alarm!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmClock clock = new AlarmClock(0, 0, 5);
            AlarmClockSubscriber subscriber = new AlarmClockSubscriber();

            clock.Tick += subscriber.HandleTick;
            clock.Alarm += subscriber.HandleAlarm;

            clock.Start();
        }
    }
}
