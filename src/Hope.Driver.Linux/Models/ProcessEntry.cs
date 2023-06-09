using System.Text.Json.Serialization;

namespace Hope.Driver.Linux.Models
{
    public class ProcessEntry
    {
        #region Constructors

        public ProcessEntry(IEnumerable<string> args, string command, int pid)
        {
            Args = args;
            Command = command;
            Pid = pid;
        }

        #endregion

        #region Properties

        [JsonPropertyName("args")]
        public IEnumerable<string> Args { get; }

        [JsonPropertyName("command")]
        public string Command { get; }

        [JsonPropertyName("pid")]
        public int Pid { get; }

        #endregion
    }
}