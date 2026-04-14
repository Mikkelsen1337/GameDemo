using System;
using System.Collections.Generic;

namespace GameFramework.Utils
{
    public class Logger
    {
        private static Logger? _instance;

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        private List<Action<string>> listeners;

        private Logger()
        {
            listeners = new List<Action<string>>();
        }

        public void AddListener(Action<string> listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(Action<string> listener)
        {
            listeners.Remove(listener);
        }

        public void Log(string message)
        {
            foreach (var listener in listeners)
            {
                listener(message);
            }
        }
    }
}