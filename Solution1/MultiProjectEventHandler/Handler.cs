using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MultiProjectEventHandler
{
    public class Handler
    {
        static Handler()
        {
            callbackList = new Dictionary<string, List<Action<dynamic>>>();
        }

        public static Dictionary<string, List<Action<dynamic>>> callbackList;

        public static void Add(string eventName, Action<dynamic> callback)
        {
            if (callbackList.ContainsKey(eventName))
            {
                callbackList[eventName].Add(callback);
            }
            else
            {
                callbackList.Add(eventName, new List<Action<dynamic>> { callback });
            }
        }

        public static void Fire(string eventName, dynamic payload)
        {
            try
            {
                List<Action<dynamic>> actions = callbackList[eventName];

                foreach (var item in actions)
                {
                    item(payload);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
