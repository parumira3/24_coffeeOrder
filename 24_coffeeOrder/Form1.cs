using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_coffeeOrder
{
    public partial class Form1 : Form
    {
        int _iTotalPrice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdoDow1.Checked)
            {
                fDow(1);
            }
            else if (rdoDow2.Checked)
            {
                fDow(2);
            }
        }

        #region Function

        /// <summary>
        /// 0 : 선택안함, 1 : 오리지널, 2 : 씬
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>        
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우는 오리지널 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 씬을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else 
            {
                //iPrice = 11000;
                strOrder =  "도우를 선택하지 않았습니다.";
            }

            lboxOrder.Items.Add(strOrder);
            return _iTotalPrice += iPrice;


        }

        #endregion

    }
}
