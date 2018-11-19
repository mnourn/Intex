using System;

namespace MathLibrary
{
    public class Nodes
    {
        private Node Head { get; set; }
        public Nodes()
        {
            Head = new Node();
        }
        public Node GetHead()
        {
            return Head;
        }
        /// <summary>
        /// Add integer number to Nodes number
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Add(UInt64 value)
        {
            if (value > 0)
            {
                if (Head == null)
                {
                    Node last = Head = new Node() { Value = (byte)(value % 100) };
                    value /= 100;
                    while (value > 0)
                    {
                        Node tmp = new Node() { Value = (byte)(value % 100) };
                        value /= 100;
                        last.Next = tmp;
                        last = tmp;
                    }
                }
                else
                {
                    Node last = Head;
                    while (value > 0)
                    {
                        byte add = (byte)(value % 100);
                        byte remain = (byte)((last.Value + add) / 100);
                        last.Value = (byte)((last.Value + add) % 100);
                        value /= 100;
                        value = value + remain;
                        if (value > 0)
                        {
                            if (last.Next == null)
                            {
                                Node tmp = new Node();
                                last.Next = tmp;
                                last = tmp;
                            }
                            else
                            {
                                last = last.Next;
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Multiply value with list of Nodes
        /// </summary>
        /// <param name="value">Value to be multiplied</param>
        /// <returns>List of Nodes</returns>
        public Nodes Multiply(UInt32 value)
        {
            Nodes result = new Nodes();
            if (Head != null)
            {
                if (value != 0)
                {
                    result.Head = new Node();
                    int index = 0;
                    while (value > 0)
                    {
                        Node lastSource = Head;
                        Node lastDestination = result.Head;
                        byte val = (byte)(value % 100);
                        for (int i = 0; i < index && lastDestination != null; i++)
                        {
                            lastDestination = lastDestination.Next;
                        }
                        int newVal = 0;
                        while (lastSource != null)
                        {
                            newVal += val * lastSource.Value;
                            byte add = (byte)(newVal % 100);
                            byte remain = (byte)((lastDestination.Value + add) / 100);
                            lastDestination.Value = (byte)((lastDestination.Value + add) % 100);
                            newVal /= 100;
                            newVal += remain;
                            lastSource = lastSource.Next;
                            if (lastDestination.Next == null && (lastSource != null || newVal > 0))
                            {
                                Node tmp = new Node();
                                lastDestination.Next = tmp;
                            }
                            lastDestination = lastDestination.Next;
                        }
                        if (newVal > 0)
                        {
                            lastDestination.Value = (byte)newVal;
                        }
                        value /= 100;
                        index++;
                    }
                }
                else
                {
                    result.Head = new Node();
                }
            }
            return result;
        }
        /// <summary>
        /// Calculate factorial number for parameter "value"
        /// </summary>
        /// <param name="value"></param>
        /// <returns>List of Nodes</returns>
        public Nodes Factorial(UInt32 value)
        {
            Nodes result = new Nodes();
            result.Head = new Node() { Value = 1 };
            for (UInt32 i = 2; i <= value; i++)
            {
                result = result.Multiply(i);
            }
            GC.Collect();
            return result;
        }
        /// <summary>
        /// Represent list of linked numbers as string 
        /// </summary>
        /// <returns>string</returns>
        public string GetValue()
        {
            string result = string.Empty;
            Node tmp = Head;
            while (tmp != null)
            {
                result = (tmp.Value > 10 || tmp.Next == null ? tmp.Value.ToString() : "0" + tmp.Value) + result;
                tmp = tmp.Next;
            }
            return result;
        }
    }
}
