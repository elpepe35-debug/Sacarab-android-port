using System;
using System.IO;
using System.Linq;

namespace Scarab.Util;

public static class PathUtil
{
    public static string GetHollowKnightPath()
    {
        // Estas son las rutas donde se instalan los ports de Android
        string[] androidPaths = {
            "/sdcard/Android/data/com.TeamCherry.HollowKnight/files",
            "/storage/emulated/0/Android/data/com.TeamCherry.HollowKnight/files",
            "/sdcard/HollowKnight/files"
        };

        foreach (var root in androidPaths)
        {
            if (Directory.Exists(root)) return root;
        }

        // Si no lo encuentra, devuelve la ruta por defecto
        return "/sdcard/Android/data/com.TeamCherry.HollowKnight/files";
    }

    public static string GetModPath()
    {
        return Path.Combine(GetHollowKnightPath(), "hollow_knight_Data", "Managed", "Mods");
    }
}
