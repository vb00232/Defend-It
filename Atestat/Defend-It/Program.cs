﻿using System;

namespace Defend_It
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var game = new Main())
            //    game.Run();
            Defend_It.Main.Instance.Run();

        }
    }
#endif
}
