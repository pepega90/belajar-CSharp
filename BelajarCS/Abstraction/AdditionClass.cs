using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCS.Abstraction
{
    /* abstract modifier, pada dasarnya berprilaku layaknya template
     * jadi dia bisa memiliki property atau method yang nantinya bisa kita gunakan dengan cara
     * meng-override method dan property tersebut. ketika kita membuat class abstract
     * property dan method di dalamnya juga harus abstract
     */
    abstract class AdditionClass
    {
        /* object, dimana kita bisa memberikan tipe data yang generic.
         * yang nantinya kelas turunan bisa menentukan tipe data yang diinginkan
         */
        abstract public object Total { get; }
        // protected, adalah ketika kita hannya ingin memberikan akses method atau pun property 
        // kepada kelas turunan
        abstract protected object AddTwoValues(object Value1, object Value2);
    }
}
