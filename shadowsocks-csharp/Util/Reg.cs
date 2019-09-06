﻿namespace Shadowsocks.Util
{
    public static class Reg
    {
        public static bool SetUrlProtocol()
        {
            try
            {
                var path = Utils.GetExecutablePath();
                using var runKey = Utils.OpenRegKey(@"Software\Classes", true);
                using var ssr = runKey?.CreateSubKey(@"ssr");
                if (ssr != null)
                {
                    ssr.SetValue(null, @"URL:ShadowsocksR Link");
                    ssr.SetValue(@"URL Protocol", @"");
                    using var command = ssr.CreateSubKey(@"Shell\Open\Command");
                    if (command != null)
                    {
                        command.SetValue(null, $@"""{path}"" ""%1""");
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
