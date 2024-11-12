// This file is subject to the terms and conditions defined
// in file 'LICENSE', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2.Authentication;

namespace DepotDownloader;

public class CallbackAuthenticator : IAuthenticator
{
    readonly LoginCallbacks _loginCallbacks;

    public Task<bool> AcceptDeviceConfirmationAsync()
    {
        _loginCallbacks?.SteamAuthAppRequest?.Invoke();
        return Task.FromResult(true);
    }

    public async Task<string> GetDeviceCodeAsync(bool previousCodeWasIncorrect)
    {
        return await _loginCallbacks?.SteamGuardCodeRequest?.Invoke(string.Empty);
    }

    public async Task<string> GetEmailCodeAsync(string email, bool previousCodeWasIncorrect)
    {
        return await _loginCallbacks?.SteamGuardCodeRequest?.Invoke(email);
    }

    public CallbackAuthenticator(LoginCallbacks loginCallbacks)
    {
        this._loginCallbacks = loginCallbacks;
    }
}
