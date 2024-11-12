// This file is subject to the terms and conditions defined
// in file 'LICENSE', which is part of this source code package.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepotDownloader;

#nullable enable

/// <summary>
/// Contains callbacks for download methods.
/// </summary>
public sealed class DownloadCallbacks
{
    // Callbacks
    public Action<SteamDepotDownloadProgress>? DepotDownloadProgress;
    public Action<SteamDepotDownloadComplete>? DepotDownloadComplete;


    // Nested Structs
    public struct SteamDepotDownloadProgress
    {
        public float Percentage;
        public string FilePath;
        public ulong DepotSize;
        public ulong DownloadedSize;
    }
    public struct SteamDepotDownloadComplete
    {
        public uint AppID;
        public uint DepotID;
        public int TotalDepots;
        public int DepotIndex;
    }
}
