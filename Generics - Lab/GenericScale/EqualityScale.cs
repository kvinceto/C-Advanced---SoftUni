﻿using System;

namespace GenericScale
{
    public class EqualityScale<T> where T : IComparable
    {
        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            bool result = this.left.Equals(this.right);
            return result;
        }
    }
}
