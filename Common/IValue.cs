using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    /* interface (by default interface is abstract), adalah keseluruhan class abstract. interface bisa memiliki method dan property
     * tetapi tidak bisa memiliki field (variabel). by default method dan property dari interface
     * akan abstract, jadi kita tidak perlu memberikan keyword abstract lagi. dan kita juga tidak bisa
     * memberikan access modifier ke method dan property tersebut, by default semua member dari interface
     * adalah public, dan ketika kita meng-inherit interface, dan ingin menggunakan salah satu dari member
     * kita tidak perlu menggunakan keyword override. kita bisa meng-inherit dari banyak interface dan gunakan tanda koma
     * untuk membedakan
     */
    public interface IValue<T>
    {
        T Value1 { get; set; }
    }
}
