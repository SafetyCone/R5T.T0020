using System;


namespace R5T.T0020
{
    /// <summary>
    /// Marks a class as being an operation. Not inherited.
    /// Also allows specifying that a class is *not* an operation. (Useful for decorating extraneous types that also happen to be in the canonical operations directory.)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class OperationMarkerAttribute : Attribute
    {
        private readonly bool zIsServiceDefinition;
        public bool IsServiceDefinition
        {
            get
            {
                return this.zIsServiceDefinition;
            }
        }


        public OperationMarkerAttribute(
            bool isServiceDefinition = true)
        {
            this.zIsServiceDefinition = isServiceDefinition;
        }
    }
}
