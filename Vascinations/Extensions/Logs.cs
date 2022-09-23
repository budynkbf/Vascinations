using NLog;
using System;

//using System.Linq;

namespace Vascinations.Extensions
{
    public static class Logs
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void AddLogErrorGeneruj(string ex)
        {
            try
            {
#if DEBUG
                Logger.Error(ex);
#else
                Logger.Error(ex);
#endif
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void AddLogError(Exception ex)
        {
            try
            {
#if DEBUG
                Logger.Error(ex.ToString());
#else
                Logger.Error(ex);
#endif
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void AddLogError(string ex)
        {
            try
            {
#if DEBUG
                Logger.Error(ex.ToString());
#else
                Logger.Error(ex);
#endif
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void AddLogDebug(string msg)
        {
            try
            {
                Logger.Debug(msg);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void AddLogInfoMsg(string msg)
        {
            try
            {
#if DEBUG
                Logger.Info(msg);
#else
                Logger.Info(msg);
#endif
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void AddLogInfo(Exception ex)
        {
            try
            {
#if DEBUG
                Logger.Info(ex.ToString());
#else
                Logger.Info(ex);
#endif
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void AddLogInfo(string msg)
        {
            try
            {
#if DEBUG
                Logger.Info(msg);
#else
                Logger.Info(msg);
#endif
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void AddLogWarrning(Exception ex)
        {
            try
            {
#if DEBUG
                Logger.Warn(ex.ToString());
#else
                Logger.Warn(ex);
#endif
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void AddLogWarrning(string msg)
        {
            try
            {
                Logger.Warn(msg);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}