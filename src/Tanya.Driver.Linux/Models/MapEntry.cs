using System.Text.Json.Serialization;
using Hope.Driver.Linux.Enums;

namespace Hope.Driver.Linux.Models
{
    public class MapEntry
    {
        #region Constructors

        public MapEntry(ushort devMajor, ushort devMinor, ulong end, ulong inode, ulong offset, string pathname, PermissionType perms, ulong start)
        {
            DevMajor = devMajor;
            DevMinor = devMinor;
            End = end;
            Inode = inode;
            Offset = offset;
            Pathname = pathname;
            Perms = perms;
            Start = start;
        }

        #endregion

        #region Properties

        [JsonPropertyName("devMajor")]
        public ushort DevMajor { get; }

        [JsonPropertyName("devMinor")]
        public ushort DevMinor { get; }

        [JsonPropertyName("end")]
        public ulong End { get; }

        [JsonPropertyName("inode")]
        public ulong Inode { get; }

        [JsonPropertyName("offset")]
        public ulong Offset { get; }

        [JsonPropertyName("pathname")]
        public string Pathname { get; }

        [JsonPropertyName("perms")]
        public PermissionType Perms { get; }

        [JsonPropertyName("start")]
        public ulong Start { get; }

        #endregion
    }
}