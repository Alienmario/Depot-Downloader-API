// This file is subject to the terms and conditions defined
// in file 'LICENSE', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;

#nullable enable

namespace DepotDownloader;

public class LoginCallbacks
{
    public Func<string, Task<string>>? SteamGuardCodeRequest;
    public Action? SteamAuthAppRequest;
    public Action<SteamLoginSuccess>? LoginSuccess;
    public Action<SteamLoginFailed>? LoginFailed;

    // Nested Structs
    public struct SteamLoginSuccess
    {
        public string Username;
        public uint Steam3ID;
    }
    public struct SteamLoginFailed
    {
        public EResult Result;
    }
}
