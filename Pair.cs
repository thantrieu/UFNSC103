namespace L103Exercises1
{
    internal class Pair<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

        public Pair() { }

        public Pair(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
