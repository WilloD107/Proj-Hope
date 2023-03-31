﻿namespace Hope.Core.Interfaces
{
    public interface IType<T>
    {
        #region Methods

        T Get(byte[] buffer);

        void Set(byte[] buffer, T value);

        int Size();

        #endregion
    }
}