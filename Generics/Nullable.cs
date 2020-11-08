namespace Generics
{
    // Example of a constraint to a value type
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                // "Unboxing" the value, which is currently type object
                return (T)_value;
            }
            
            // in case it is null, we need to find the default value for that tipe.
            // we can do this with the default operator.
            return default(T);
        }
    }
}
