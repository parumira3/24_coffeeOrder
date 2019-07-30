using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_coffeeOrder
{
    public partial class frmCoffee : Form
    {
        public delegate int delCoffeeComplete(string strResult, int iTime); // 델리게이트에 타입에 함수이름을 적었고
        public event delCoffeeComplete eventdelCoffeeComplete; //이벤트에 델리리게이트타입을 맞췃다고 보면 됨
        //public event EventHandler

        //이벤트 넘겨줄땐 델리게이트를 사용한다

        public frmCoffee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fCoffeeCheck()
        {
            int i = 0;
            while(i > 10)
            {
                i++;
                Thread.Sleep(1000);

            }

            eventdelCoffeeComplete("완료", 1000);
        }
    }
}
