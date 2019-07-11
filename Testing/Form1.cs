using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /////   四位流水号
            /////   

            //string var_str = string.Empty;
            //string str = string.Empty;
            //for (int i = 0; i < 10000; i++)
            //{
            //    if (i < 10)
            //    {
            //         var_str = "000"+i.ToString();      
            //    }
            //    if (i < 100 && i > 10)
            //    {
            //         var_str = "00" + i.ToString();
            //    }
            //    if(i >100 &&i<1000)
            //    {
            //        var_str = "0" + i.ToString();
            //    }
            //    if(i>1000&&i<10000)
            //    {
            //        var_str =  i.ToString();
            //    }
            //    //   年月日
            //    string str_YY = DateTime.Now.ToString("yyyy");
            //    string str_MM = DateTime.Now.ToString("mm");
            //    string str_DD = DateTime.Now.ToString("dd");
            //     str += str_YY + str_MM + str_DD +var_str+'\n'; 
            //}


            // this.richTextBox1.Text = str;

            int[] arr = new[] { 11, 121, 1231, 3123, 12312, 312, 3, 123, 12, 3, 2131, 23, 1, 32123, 3123 };

          int []rsult = SelectionSort(arr);
            for (int i = 0; i < rsult.Length; i++)
            {
                this.richTextBox1.Text += rsult[i].ToString()+",  ";

            }
           
            
        }

        /// <summary>
        /// 冒泡
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int[] Sort(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1 - i;j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tmp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                    
                }
            }
            return array;
        }


        /// <summary>
        /// 每次循环时，找到最小的，保存最小的下标，循环一次交换依次下标，每次都是未排序最小的，依次类推
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private int[] SelectionSort(int[] arr)
        {
            int length = arr.Length;
            int minIndex = 0;
            for (int i = 0; i < length; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                var tmp = arr[i];
                arr[minIndex] = arr[i];
                arr[i] = tmp;
            }
            return arr;
        }
    }
}
