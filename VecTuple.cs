using UnityEngine;

namespace TorqueGames.Bones.Utilities
{
    public struct VecTuple
    {
        private float x;
        private float y;
        private float z;

        private VecTuple(float x, float y)
        {
            this.x = x;
            this.y = y;
            z = 0;
        }

        private VecTuple(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector2(VecTuple vecTuple)
        {
            return new Vector2(vecTuple.x, vecTuple.y);
        }

        public static implicit operator VecTuple(Vector2 tuple)
        {
            return new VecTuple(tuple.x, tuple.y);
        }

        public static implicit operator Vector2Int(VecTuple vecTuple)
        {
            return new Vector2Int((int) vecTuple.x, (int) vecTuple.y);
        }

        public static implicit operator VecTuple(Vector2Int tuple)
        {
            return new VecTuple(tuple.x, tuple.y);
        }

        public static implicit operator (float x, float y)(VecTuple vecTuple)
        {
            return (vecTuple.x, vecTuple.y);
        }

        public static implicit operator VecTuple((float x, float y) tuple)
        {
            return new VecTuple(tuple.x, tuple.y);
        }

        public static implicit operator (int x, int y)(VecTuple vecTuple)
        {
            return ((int x, int y)) (vecTuple.x, vecTuple.y);
        }

        public static implicit operator VecTuple((int x, int y) tuple)
        {
            return new VecTuple(tuple.x, tuple.y);
        }

        public static implicit operator Vector3(VecTuple vecTuple)
        {
            return new Vector3(vecTuple.x, vecTuple.y, vecTuple.z);
        }

        public static implicit operator VecTuple(Vector3 vecTuple)
        {
            return new VecTuple(vecTuple.x, vecTuple.y, vecTuple.z);
        }

        public static implicit operator Vector3Int(VecTuple vecTuple)
        {
            return new Vector3Int((int) vecTuple.x, (int) vecTuple.y, (int) vecTuple.z);
        }

        public static implicit operator VecTuple(Vector3Int vecTuple)
        {
            return new VecTuple(vecTuple.x, vecTuple.y, vecTuple.z);
        }

        public static implicit operator (float x, float y, float z)(VecTuple vecTuple)
        {
            return (vecTuple.x, vecTuple.y, vecTuple.z);
        }

        public static implicit operator VecTuple((float x, float y, float z) tuple)
        {
            return new VecTuple(tuple.x, tuple.y, tuple.z);
        }

        public static implicit operator (int x, int y, int z)(VecTuple vecTuple)
        {
            return ((int, int, int)) (vecTuple.x, vecTuple.y, vecTuple.z);
        }

        public static implicit operator VecTuple((int x, int y, int z) tuple)
        {
            return new VecTuple(tuple.x, tuple.y, tuple.z);
        }
    }
}
