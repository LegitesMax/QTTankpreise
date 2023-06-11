﻿//@CodeCopy
//MdStart
namespace QTTankpreise.Logic.Models
{
    using QTTankpreise.Logic.Contracts;
    using System.Collections;
    public abstract partial class ModelObject : IIdentifyable
    {
        protected Entities.EntityObject? _source;

        internal virtual Entities.EntityObject Source
        {
            get => _source!;
            set => _source = value;
        }
        /// <summary>
        /// ID of the entity (primary key)
        /// </summary>
        public virtual IdType Id
        {
            get => Source?.Id ?? default(IdType);
            set
            {
                if (Source != null)
                {
                    Source.Id = value;
                }
            }
        }

        /// <summary>
        /// Determines whether two object instances are equal
        /// </summary>
        /// <param name="obj1">The object to compare with the second object.</param>
        /// <param name="obj2">The object to compare with the first object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        protected static bool IsEqualsWith(object? obj1, object? obj2)
        {
            bool result = false;

            if (obj1 == null && obj2 == null)
            {
                result = true;
            }
            else if (obj1 != null && obj2 != null)
            {
                if (obj1 is IEnumerable objEnum1
                    && obj2 is IEnumerable objEnum2)
                {
                    var enumerable1 = objEnum1.Cast<object>().ToList();
                    var enumerable2 = objEnum2.Cast<object>().ToList();

                    result = enumerable1.SequenceEqual(enumerable2);
                }
                else
                {
                    result = obj1.Equals(obj2);
                }
            }
            return result;
        }
        protected virtual int GetHashCode(List<object?> items)
        {
            items.Add(Id);
            return this.CalculateHashCode(items);
        }
    }
}
//MdEnd
