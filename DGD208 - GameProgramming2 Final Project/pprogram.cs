﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class pprogram
{
    public static async Task Main()
    {
        Game game = new Game();
        await game.GameLoop();
    }
}
