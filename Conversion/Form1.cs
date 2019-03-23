using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            cbox_input.SelectedIndex = 0;
            cbox_output.SelectedIndex = 3;
            this.AcceptButton = btn_transform; //回车键查询
        }

        private void btn_transform_Click(object sender, EventArgs e)
        {
            try
            {
                Action(); //调用Action方法进行转换操作
            }
            catch(Exception ex)
            {
                MessageBox.Show(//如果出现异常则提示错误信息
                    ex.Message + "请重新输入", "出错！");
            }
        }
        private void Action()
        {
            if(cbox_input.SelectedIndex != 3)
            {
                long test_value; //定义长整型变量
                if(long.TryParse(txt_input.Text,out test_value)) //判断数值是否输入正确
                {
                    if(cbox_input.SelectedIndex == 0)
                    {
                        switch(cbox_output.SelectedIndex)
                        {
                            case 0: //将十进制转换为十进制
                                txt_output.Text = txt_input.Text;
                                break;
                            case 1: //将十进制转换为二进制
                                txt_output.Text = new Transform().DecToBin(long.Parse(txt_input.Text));
                                break;
                            case 2: //将十进制转为八进制
                                txt_output.Text = new Transform().DecToOct(long.Parse(txt_input.Text));
                                break;
                            case 3: // 将十进制转为十六进制
                                txt_output.Text = "0x" + new Transform().DecToHex(long.Parse(txt_input.Text));
                                break;
                        }
                    }
                    else
                    {
                        if(cbox_input.SelectedIndex == 1)
                        {
                            switch (cbox_output.SelectedIndex)
                            {
                                case 0: //二进制转换为十进制
                                    txt_output.Text = new Transform().BinToDec(long.Parse(txt_input.Text));
                                    break;
                                case 1: //二进制转换为二进制
                                    txt_output.Text = txt_input.Text;
                                    break;
                                case 2: //二进制转换为八进制
                                    txt_output.Text = new Transform().BinToOct(long.Parse(txt_input.Text));
                                    break;
                                case 3: //二进制转换为十六进制
                                    txt_output.Text = "0x" + new Transform().BinToHex(long.Parse(txt_input.Text));
                                    break;

                            }
                        }
                        else
                        {
                            if (cbox_input.SelectedIndex == 2)
                            {
                                switch (cbox_output.SelectedIndex)
                                {
                                    case 0: //八进制转换为十进制
                                        txt_output.Text = new Transform().OctToDec(long.Parse(txt_input.Text));
                                        break;
                                    case 1: //八进制转换为二进制
                                        txt_output.Text = new Transform().OctToBin(long.Parse(txt_input.Text));
                                        break;
                                    case 2: //八进制转换为八进制
                                        txt_output.Text = txt_input.Text;
                                        break;
                                    case 3: //八进制转换为十六进制
                                        txt_output.Text = "0x" + new Transform().OctToHex(long.Parse(txt_input.Text));
                                        break;

                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确数值！", "提示!");
                }
            }
            else
            {
                switch (cbox_output.SelectedIndex)
                {
                    case 0://十六进制转化为十进制
                        txt_output.Text = new Transform().HexToDec(txt_input.Text);
                        break;
                    case 1://十六进制转化为二进制
                        txt_output.Text = new Transform().HexToBin(txt_input.Text);
                        break;
                    case 2://十六进制转化为八进制
                        txt_output.Text =  new Transform().HexToOct(txt_input.Text);
                        break;
                    case 3: //十六进制转化为十六进制
                        txt_output.Text = "0x" + txt_input.Text;
                        break;
                }                
            }
        }
        
    }
}
