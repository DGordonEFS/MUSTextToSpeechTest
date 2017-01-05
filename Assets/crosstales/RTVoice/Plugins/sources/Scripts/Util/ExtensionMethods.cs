using UnityEngine;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Crosstales.RTVoice.Util
{
    /// <summary>Various extension methods.</summary>
    public static class ExtensionMethods
    {
        private static readonly System.Random rd = new System.Random();

        /// <summary>
        /// Extension method for strings.
        /// Case insensitive contains.
        /// </summary>
        /// <param name="str">String-instance.</param>
        /// <param name="toCheck">String to check.</param>
        /// <param name="comp">StringComparison-method (default: StringComparison.OrdinalIgnoreCase, optional)</param>
        /// <returns>True if the string contains the given string.</returns>
        public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
        {
            if (str == null)
                throw new ArgumentNullException("str");

            if (toCheck == null)
                throw new ArgumentNullException("toCheck");

            return str.IndexOf(toCheck, comp) >= 0;
        }

        /// <summary>
        /// Extension method for strings.
        /// Contains any given string.
        /// </summary>
        /// <param name="str">String-instance.</param>
        /// <param name="searchTerms">Search terms separated by the given split-character.</param>
        /// <param name="splitChar">Split-character (default: ' ', optional)</param>
        /// <returns>True if the string contains any parts of the given string.</returns>
        public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
        {
            if (str == null)
                throw new ArgumentNullException("str");

            if (string.IsNullOrEmpty(searchTerms))
            {
                return true;
            }

            char[] split = new char[] { splitChar };

            return searchTerms.Split(split, StringSplitOptions.RemoveEmptyEntries).Any(searchTerm => str.CTContains(searchTerm));
        }

        /// <summary>
        /// Extension method for strings.
        /// Contains all given strings.
        /// </summary>
        /// <param name="str">String-instance.</param>
        /// <param name="searchTerms">Search terms separated by the given split-character.</param>
        /// <param name="splitChar">Split-character (default: ' ', optional)</param>
        /// <returns>True if the string contains all parts of the given string.</returns>
        public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
        {
            if (str == null)
                throw new ArgumentNullException("str");

            if (string.IsNullOrEmpty(searchTerms))
            {
                return true;
            }

            char[] split = new char[] { splitChar };

            return searchTerms.Split(split, StringSplitOptions.RemoveEmptyEntries).All(searchTerm => str.CTContains(searchTerm));
        }

        /// <summary>
        /// Extension method for Lists.
        /// Shuffles a List.
        /// </summary>
        /// <param name="list">List-instance to shuffle.</param>
        public static void CTShuffle<T>(this IList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            int n = list.Count;

            while (n > 1)
            {
                int k = rd.Next(n--);
                T temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
        }

        /// <summary>
        /// Extension method for Arrays.
        /// Shuffles an Array.
        /// </summary>
        /// <param name="array">Array-instance to shuffle.</param>
        public static void CTShuffle<T>(this T[] array)
        {
            if (array == null || array.Length <= 0)
                throw new ArgumentNullException("array");

            int n = array.Length;
            while (n > 1)
            {
                int k = rd.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        /// <summary>
        /// Extension method for Arrays.
        /// Dumps an array to a string.
        /// </summary>
        /// <param name="array">Array-instance to dump.</param>
        /// <returns>String with lines for all array entries.</returns>
        public static string CTDump<T>(this T[] array)
        {
            if (array == null || array.Length <= 0)
                throw new ArgumentNullException("array");

            StringBuilder sb = new StringBuilder();

            foreach (T element in array)
            {
                if (0 < sb.Length)
                {
                    sb.Append(Environment.NewLine);
                }
                sb.Append(element.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Extension method for Lists.
        /// Dumps a list to a string.
        /// </summary>
        /// <param name="list">List-instance to dump.</param>
        /// <returns>String with lines for all list entries.</returns>
        public static string CTDump<T>(this List<T> list)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            StringBuilder sb = new StringBuilder();

            foreach (T element in list)
            {
                if (0 < sb.Length)
                {
                    sb.Append(Environment.NewLine);
                }
                sb.Append(element.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Extension method for MonoBehaviour.
        /// Invoke with a real method name instead of a string.
        /// </summary>
        /// <param name="mb">MonoBehaviour-instance.</param>
        /// <param name="methodName">Mehod as Action.</param>
        /// <param name="time">Delay time of the invoke in seconds.</param>
        public static void CTInvoke(this MonoBehaviour mb, Action methodName, float time)
        {
            if (mb == null)
                throw new ArgumentNullException("mb");

            if (methodName == null)
                throw new ArgumentNullException("methodName");


            mb.Invoke(methodName.Method.Name, time);
        }

        /// <summary>
        /// Extension method for MonoBehaviour.
        /// InvokeRepeating with a real method name instead of a string.
        /// </summary>
        /// <param name="mb">MonoBehaviour-instance.</param>
        /// <param name="methodName">Mehod as Action.</param>
        /// <param name="time">Delay time of the invoke in seconds.</param>
        /// <param name="repeatRate">Repeat-time of the invoke in seconds.</param>
        public static void CTInvokeRepeating(this MonoBehaviour mb, Action methodName, float time, float repeatRate)
        {
            if (mb == null)
                throw new ArgumentNullException("mb");

            if (methodName == null)
                throw new ArgumentNullException("methodName");


            mb.InvokeRepeating(methodName.Method.Name, time, repeatRate);
        }

        /// <summary>
        /// Extension method for MonoBehaviour.
        /// IsInvoking with a real method name instead of a string.
        /// </summary>
        /// <param name="mb">MonoBehaviour-instance.</param>
        /// <param name="methodName">Mehod as Action.</param>
        /// <returns>True if the given method invoke is pending.</returns>
        public static bool CTIsInvoking(this MonoBehaviour mb, Action methodName)
        {
            if (mb == null)
                throw new ArgumentNullException("mb");

            if (methodName == null)
                throw new ArgumentNullException("methodName");


            return mb.IsInvoking(methodName.Method.Name);
        }
    }
}
// Copyright 2016 www.crosstales.com