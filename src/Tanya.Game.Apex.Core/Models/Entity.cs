using System.Text.Json.Serialization;
using Hope.Core;
using Hope.Core.Extensions;
using Hope.Core.Types;
using Hope.Driver.Interfaces;
using Hope.Game.Apex.Core.Interfaces;

namespace Hope.Game.Apex.Core.Models
{
    public class Entity : IUpdatable
    {
        private readonly Access<ulong> _signifierName;

        #region Constructors

        public Entity(IDriver driver, IOffsets offsets, ulong address)
        {
            _signifierName = driver.Access(address + offsets.EntitySignifierName, UInt64Type.Instance, 60000);
        }

        #endregion

        #region Properties

        [JsonPropertyName("signifierName")]
        public ulong SignifierName
        {
            get => _signifierName.Get();
            set => _signifierName.Set(value);
        }

        #endregion

        #region Implementation of IUpdatable

        public void Update(DateTime frameTime)
        {
            _signifierName.Update(frameTime);
        }

        #endregion
    }
}