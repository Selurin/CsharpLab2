using System;

internal class Time
{
    private int seconds;

    public Time()
    {
        this.seconds = 0;
    }

    public Time(int seconds)
    {
        if (seconds < 0)
        {
            Console.WriteLine("Ошибка: время не может быть отрицательным");
            this.seconds = 0;
        }
        else
        {
            this.seconds = seconds % 86400;
        }
    }

    public Time(int hours, int minutes, int seconds)
    {
        if (hours < 0 || minutes < 0 || seconds < 0)
        {
            Console.WriteLine("Ошибка: время не может быть отрицательным");
            this.seconds = 0;
        }
        else
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            this.seconds = totalSeconds % 86400;
        }
    }

    public int Seconds
    {
        get { return this.seconds; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Ошибка: время не может быть отрицательным");
            }
            else
            {
                this.seconds = value % 86400;
            }
        }
    }

    public override string ToString()
    {
        int hours = this.seconds / 3600;
        int minutes = (this.seconds % 3600) / 60;
        int secs = this.seconds % 60;

        string result = hours.ToString() + ":" + minutes.ToString() + ":" + secs.ToString();
        return result;
    }
}
