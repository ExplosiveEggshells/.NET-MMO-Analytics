/*
 * NAME:    UtilLib.cs
 * AUTHORS: Jake Rogers (z1826513), John Erwin (z1856469)
 * 
 * This static class contains a few methods that are universially
 * useful throughout the rest of the project.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersErwin_Assign3
{
    public static class UtilLib
    {
        /*
         * Adds an array of objects to the referenced comboBox. The array of objects should
         * probably be an Enum, although it would defintely work with strings and some
         * other types as well.
         */
        public static void AddToComboBox<T>(T[] objArray, ref ComboBox comboBox)
        {
            foreach (T obj in objArray)
            {
                comboBox.Items.Add(obj);
            }
        }
    }
}
