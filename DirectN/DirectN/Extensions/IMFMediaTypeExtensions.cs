﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    // we want to avoid PropVariant stuff
    public static class IMFMediaTypeExtensions
    {
        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> Enumerate(this ComObject<IMFMediaType> obj) => Enumerate(obj?.Object);
        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> Enumerate(this IMFMediaType obj)
        {
            if (obj == null)
                yield break;

            for (int i = 0; i < Count(obj); i++)
            {
                obj.GetItemByIndex((uint)i, out Guid guid, null).ThrowOnError();
                obj.GetItemType(guid, out var type).ThrowOnError();
                yield return new KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>(guid, type);
            }
        }

        public static KeyValuePair<Guid, object>[] ToValues(this ComObject<IMFMediaType> obj) => ToValues(obj?.Object);
        public static KeyValuePair<Guid, object>[] ToValues(this IMFMediaType obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            return Enumerate(obj).Select(kv => new KeyValuePair<Guid, object>(kv.Key, GetValue(obj, kv.Key))).ToArray();
        }

        public static int Count(this ComObject<IMFMediaType> obj) => Count(obj?.Object);
        public static int Count(this IMFMediaType obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetCount(out var value).ThrowOnError();
            return (int)value;
        }

        public static void Set(this ComObject<IMFMediaType> obj, Guid key, ComObject value) => obj?.Object.SetUnknown(key, value.Object).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, string value) => obj?.Object.SetString(key, value).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, double value) => obj?.Object.SetDouble(key, value).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, Guid value) => obj?.Object.SetGUID(key, value).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, long value) => obj?.Object.SetUINT64(key, (ulong)value).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, ulong value) => obj?.Object.SetUINT64(key, value).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, int value) => obj?.Object.SetUINT32(key, (uint)value).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, uint value) => obj?.Object.SetUINT32(key, value).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, bool value) => obj?.Object.SetUINT32(key, (uint)(value ? 1 : 0)).ThrowOnError();
        public static void Set(this ComObject<IMFMediaType> obj, Guid key, Enum value) => obj?.Object.SetUINT32(key, (uint)Convert.ChangeType(value, typeof(uint))).ThrowOnError();

        public static T Get<T>(this ComObject<IMFMediaType> obj, Guid key, T defaultValue = default(T), IFormatProvider provider = null) => Get(obj?.Object, key, defaultValue, provider);
        public static T Get<T>(this IMFMediaType obj, Guid key, T defaultValue = default(T), IFormatProvider provider = null)
        {
            if (!TryGet(obj, key, provider, out T value))
                return defaultValue;

            return value;
        }

        public static bool TryGet<T>(this ComObject<IMFMediaType> obj, Guid key, out T value) => TryGet(obj?.Object, key, null, out value);
        public static bool TryGet<T>(this ComObject<IMFMediaType> obj, Guid key, IFormatProvider provider, out T value) => TryGet(obj?.Object, key, provider, out value);
        public static bool TryGet<T>(this IMFMediaType obj, Guid key, out T value) => TryGet(obj, key, null, out value);
        public static bool TryGet<T>(this IMFMediaType obj, Guid key, IFormatProvider provider, out T value)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetItemType(key, out var type).IsError)
            {
                value = default(T);
                return false;
            }

            T item;
            switch (type)
            {
                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_BLOB:
                    if (typeof(T) == typeof(byte[]))
                    {
                        value = (T)(object)GetBlob(obj, key);
                        return true;
                    }

                    var bytes = GetBlob(obj, key);
                    if (!Conversions.TryChangeType(bytes, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_DOUBLE:
                    var dbl = GetDouble(obj, key);
                    if (!Conversions.TryChangeType(dbl, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_GUID:
                    var guid = GetGuid(obj, key);
                    if (!Conversions.TryChangeType(guid, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_STRING:
                    var s = GetString(obj, key);
                    if (!Conversions.TryChangeType(s, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT32:
                    var ui = GetUInt32(obj, key);
                    if (!Conversions.TryChangeType(ui, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT64:
                    var ul = GetUInt64(obj, key);
                    if (!Conversions.TryChangeType(ul, provider, out item))
                    {
                        value = default(T);
                        return false;
                    }

                    value = item;
                    return true;

                case _MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_IUNKNOWN:
                    var comType = ComObject.GetGenericComObjectComType(typeof(T));
                    if (comType == null)
                    {
                        value = (T)GetUnknown(obj, key, typeof(T).GUID);
                        return value != null;
                    }

                    var unk = GetUnknown(obj, key, comType.GUID);
                    if (unk == null)
                    {
                        value = default(T);
                        return false;
                    }

                    value = (T)(object)ComObject.WrapAsGeneric(comType, unk);
                    return true;

                default:
                    throw new NotSupportedException();
            }
        }

        public static object GetValue(this ComObject<IMFMediaType> obj, Guid key) => GetValue(obj.Object, key);
        public static object GetValue(this IMFMediaType obj, Guid key)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            var pv = new PropVariant();
            if (obj.GetItem(key, pv).IsError)
                return null;

            return pv.Value;
        }

        public static Guid GetGuid(this ComObject<IMFMediaType> obj, Guid key) => GetGuid(obj?.Object, key, Guid.Empty);
        public static Guid GetGuid(this ComObject<IMFMediaType> obj, Guid key, Guid defaultValue) => GetGuid(obj?.Object, key, defaultValue);
        public static Guid GetGuid(this IMFMediaType obj, Guid key) => GetGuid(obj, key, Guid.Empty);
        public static Guid GetGuid(this IMFMediaType obj, Guid key, Guid defaultValue)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetGUID(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static double GetDouble(this ComObject<IMFMediaType> obj, Guid key, double defaultValue = 0) => GetDouble(obj?.Object, key, defaultValue);
        public static double GetDouble(this IMFMediaType obj, Guid key, double defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetDouble(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static bool GetBoolean(this ComObject<IMFMediaType> obj, Guid key, bool defaultValue = false) => GetBoolean(obj?.Object, key, defaultValue);
        public static bool GetBoolean(this IMFMediaType obj, Guid key, bool defaultValue = false)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return value != 0;
        }

        public static int GetInt32(this ComObject<IMFMediaType> obj, Guid key, int defaultValue = 0) => GetInt32(obj?.Object, key, defaultValue);
        public static int GetInt32(this IMFMediaType obj, Guid key, int defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return (int)value;
        }

        public static uint GetUInt32(this ComObject<IMFMediaType> obj, Guid key, uint defaultValue = 0) => GetUInt32(obj?.Object, key, defaultValue);
        public static uint GetUInt32(this IMFMediaType obj, Guid key, uint defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT32(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static ulong GetUInt64(this ComObject<IMFMediaType> obj, Guid key, ulong defaultValue = 0) => GetUInt64(obj?.Object, key, defaultValue);
        public static ulong GetUInt64(this IMFMediaType obj, Guid key, ulong defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT64(key, out var value).IsError)
                return defaultValue;

            return value;
        }

        public static long GetInt64(this ComObject<IMFMediaType> obj, Guid key, long defaultValue = 0) => GetInt64(obj?.Object, key, defaultValue);
        public static long GetInt64(this IMFMediaType obj, Guid key, long defaultValue = 0)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUINT64(key, out var value).IsError)
                return defaultValue;

            return (long)value;
        }

        public static object GetUnknown(this ComObject<IMFMediaType> obj, Guid key, Guid interfaceId) => GetUnknown(obj?.Object, key, interfaceId);
        public static object GetUnknown(this IMFMediaType obj, Guid key, Guid interfaceId)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUnknown(key, interfaceId, out var value).IsError)
                return null;

            return value;
        }

        public static ComObject<T> GetUnknown<T>(this ComObject<IMFMediaType> obj, Guid key) => GetUnknown<T>(obj, key, typeof(T).GUID);
        public static ComObject<T> GetUnknown<T>(this ComObject<IMFMediaType> obj, Guid key, Guid interfaceId) => GetUnknown<T>(obj?.Object, key, interfaceId);
        public static ComObject<T> GetUnknown<T>(this IMFMediaType obj, Guid key) => GetUnknown<T>(obj, key, typeof(T).GUID);
        public static ComObject<T> GetUnknown<T>(this IMFMediaType obj, Guid key, Guid interfaceId)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetUnknown(key, interfaceId, out var value).IsError)
                return null;

            return new ComObject<T>((T)value);
        }

        public static byte[] GetBlob(this ComObject<IMFMediaType> obj, Guid key) => GetBlob(obj, key);
        public static byte[] GetBlob(this IMFMediaType obj, Guid key)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetBlobSize(key, out var size).IsError || size == 0)
                return null;

            var bytes = new byte[(int)size];
            obj.GetBlob(key, bytes, size, ref size).ThrowOnError();
            return bytes;
        }

        public static string GetString(this ComObject<IMFMediaType> obj, Guid key, string defaultValue = null) => GetString(obj?.Object, key, defaultValue);
        public static string GetString(this IMFMediaType obj, Guid key, string defaultValue = null)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetStringLength(key, out var length).IsError)
                return defaultValue;

            var s = new string('\0', (int)length);
            length++;
            obj.GetString(key, s, length, ref length).ThrowOnError();
            return s;
        }
    }
}
