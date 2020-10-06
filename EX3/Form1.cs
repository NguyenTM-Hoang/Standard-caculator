using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form1 : Form
    {
        bool check = true; // kiếm tra trên màn hình có phép tính trước đó hay ko
        string sign="";
        double value1, value2;
        double kq=0 ;
        double kqmul = 1;
        string sig;
        string specialsign="";
        public Form1()
        {
            InitializeComponent();
            result.Text = "0";

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
        #region numberbutton       
        private void seven_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "7";
            else
            {
                result.Text = "7";
                check = true;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "0";
            else
            {
                result.Text = "0";
                check = true;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {

            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "1";
            else
            {
                result.Text = "1";
                check = true;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "2";
            else
            {
                result.Text = "2";
                check = true;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "3";
            else
            {
                result.Text = "3";
                check = true;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "4";
            else
            {
                result.Text = "4";
                check = true;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "5";
            else
            {
                result.Text = "5";
                check = true;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "6";
            else
            {
                result.Text = "6";
                check = true;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "8";
            else
            {
                result.Text = "8";
                check = true;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += "9";
            else
            {
                result.Text = "9";
                check = true;
            }
        }
        #endregion

        bool checksign =true;//kiểm tra phép tính dồn

        #region sign
        private void add_Click(object sender, EventArgs e)
        {
            if(checksign==true &&check==true)
            {
                converse(result.Text, ref value1);
                if (specialsign=="xcany")
                {
                    result.Text= (Math.Pow(x, (double)1 / value1)).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                else if(specialsign=="xmuy")
                {
                    result.Text = (Math.Pow(y, value1)).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                else if (specialsign == "mod")
                {
                    result.Text = (a % value1).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }

                if (sign == "") kq = value1;
                else
                if (sign == "-") kq -= value1;
                else if (sign == "x")
                {
                    
                    if (sig == "-")
                        kq = kq - value1 * kqmul;
                    else if (sig == "+" || sig == "") kq += value1 * kqmul;
                    else if (sig == "/") kq /= value1 * kqmul;
                    kqmul = 1;
                }
                else if (sign == ":")
                {
                    if (sig == "-")
                        kq = kq -  kqmul/value1;
                    else if (sig == "+" || sig == "") kq += kqmul/value1;
                    else if (sig == "/") kq /= kqmul/value1;
                    kqmul = 1;

                }
                else kq += value1;
                if (specialsign == "") calcu.Text += result.Text + "+";
                else
                {
                    if (specialsign == "xcany")
                        calcu.Text += value2.ToString() + ")+";
                    else if (specialsign == "xmuy"|| specialsign=="mod")
                        calcu.Text += value2.ToString() + "+";
                    else
                        calcu.Text += "+";
                    specialsign = "";
                }
              result.Text = kq.ToString();
                check = false;
                sign = "+";
            }
            else
            {
                checksign = true;
                sign = "+";
                converse(result.Text, ref value1);
                //kq += value1;
                calcu.Text = result.Text + "+";
                result.Text = "";
                check = false;
            }
            
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            
            if (checksign == true&&check==true)
            {
                converse(result.Text, ref value1);
                if (specialsign == "xcany")
                {
                    result.Text = (Math.Pow(x, (double)1 / value1)).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                else 
                if(specialsign=="xmuy")
                {
                    result.Text = (Math.Pow(y, value1)).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                else if(specialsign=="mod")
                {
                    result.Text = (a % value1).ToString();
                    value2 = value1;
                    converse(result.Text, ref value1);
                }
                if (sign == "") kq = value1;
                else
                if (sign == "-") kq -= value1;
                else if (sign == "x")
                    {
                        if (sig == "-")
                            kq = kq - value1 * kqmul;
                        else if (sig == "+" || sig == "") kq += value1 * kqmul;
                        else if (sig == "/") kq /= value1 * kqmul;
                        kqmul = 1;
                    }
                else if (sign == ":")
                {
                    if (sig == "-")
                        kq = kq - kqmul / value1;
                    else if (sig == "+" || sig == "") kq += kqmul / value1;
                    else if (sig == "/") kq /= kqmul / value1;
                    kqmul = 1;
                }
                else kq += value1;
                sign = "-";
                if (specialsign == "") calcu.Text += result.Text + "-";
                else
                {
                    if (specialsign == "xcany")
                    {
                        calcu.Text += value2.ToString() + ")-";
                        specialsign = "";
                    }
                    else
                    if (specialsign == "xmuy"||specialsign=="mod")
                    {
                        calcu.Text += value2.ToString() + "-";
                        specialsign = "";
                    }

                    else
                    {
                        calcu.Text += "-";
                        specialsign = "";
                    }
                }
               
                result.Text = kq.ToString();
                sign = "-";
                check = false;
                
            }
            else// trường hợp đã nhấn nút '=' , tiếp tục lấy kết quả để nhân tiếp nhưng xóa màn hình
            {
                checksign = true;
                sign = "-";
                converse(result.Text, ref value1);
                //kq += value1;
                calcu.Text = result.Text + "-";
                result.Text = "";
                check = false;
            }
        
        }
        
        private void multi_Click(object sender, EventArgs e)
        {
            if (checksign == true && check == true)
            {
                converse(result.Text, ref value1);
                if (sign == "")
                {
                    kqmul = value1;
                    sig = sign;
                }
                else
                if (sign == "-" || sign == "+")
                {
                    sig = sign;
                    kqmul *= value1;
                }
                else if (sign == ":")
                {
                    kqmul = kqmul / value1;
                }
                else kqmul *= value1;

                result.Text = kqmul.ToString();
                if (specialsign == "")
                    calcu.Text += value1.ToString() + "x";
                else if (specialsign == "xcany")
                {
                    if (sign == ":")
                        kqmul =kqmul* value1/ Math.Pow(x, (double)1 / value1);
                    else
                        kqmul =kqmul/value1* Math.Pow(x, (double)1 / value1);
                    calcu.Text += value1.ToString() + ")" + "x";                  
                    result.Text = kqmul.ToString();
                }
                else if (specialsign == "xmuy")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / Math.Pow(y, value1);
                    else
                        kqmul = kqmul / value1 * Math.Pow(y, value1);
                    calcu.Text += value1.ToString() + "x";
                    result.Text = kqmul.ToString();
                }
                else if (specialsign == "mod")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / (a % value1);
                    else
                        kqmul = kqmul / value1 * (a % value1);
                    calcu.Text += value1.ToString() + "x";
                    result.Text = kqmul.ToString();
                }
                else 
                {
                    calcu.Text += "x";
                }
                specialsign = "";
                sign = "x";
                check = false;
            }
            else
            {
                checksign = true;
                sign = "x";
                converse(result.Text, ref value1);
                calcu.Text = result.Text + "x";
                result.Text = "";
                check = false;
            }       
        }
        private void devide_Click(object sender, EventArgs e)
        {
            if (checksign == true&& check==true)
            {
                converse(result.Text, ref value1);
                if (sign == "")
                {
                    kqmul = value1;                  
                    sig = sign;
                }
                else
                if (sign == "-" || sign == "+")
                {
                    sig = sign;
                    kqmul = value1;
                }
                else if (sign == ":")
                {
                    kqmul = kqmul / value1;
                    
                }
                else
                {
                    kqmul *= value1;
                   
                }
                result.Text = kqmul.ToString();
                if (specialsign == "")
                    calcu.Text += value1.ToString() + "÷";
                else if (specialsign == "xcany")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / Math.Pow(x, (double)1 / value1);
                    else
                        kqmul = kqmul / value1 * Math.Pow(x, (double)1 / value1);
                    calcu.Text += value1.ToString() + ")" + "÷";                   
                    result.Text = kqmul.ToString();
                }
                else if(specialsign=="xmuy")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / Math.Pow(y, value1);
                    else
                        kqmul = kqmul / value1 * Math.Pow(y, value1);
                    calcu.Text += value1.ToString()  + "÷";
                    result.Text = kqmul.ToString();
                }
                else if(specialsign=="mod")
                {
                    if (sign == ":")
                        kqmul = kqmul * value1 / (a % value1);
                    else
                        kqmul = kqmul / value1 *(a%value1);
                    calcu.Text += value1.ToString() + "÷";
                    result.Text = kqmul.ToString();
                }
                else            
                    calcu.Text += "÷";
                specialsign = "";
                sign = ":";
                check = false;
            }
            else
            {
                checksign = true;
                sign = "÷";
                converse(result.Text, ref value1);
                calcu.Text = result.Text + "÷";
                result.Text = "";
                check = false;
            }
           
        }

        void converse (string s, ref double value)
        {
          try
            {
                value = double.Parse(s);               
            }
           catch(Exception)
            {
                MessageBox.Show("your number is not valid");
               
            }
           
        }
        // dấu "="
        private void equal_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case "+":
                    if(checksign)
                    { 
                        converse(result.Text, ref value2);
                        if (specialsign == "xcany")
                        {
                            calcu.Text += value2.ToString() + ")";
                            value2 = Math.Pow(x, (double)1 / value2);
                        }
                        else if(specialsign=="xmuy")
                        {
                            calcu.Text += value2.ToString() ;
                            value2 = Math.Pow(y,value2);
                        }
                        else if (specialsign == "mod")
                        {
                            calcu.Text += value2.ToString();
                            value2 =a%value2;
                        }
                        else if(specialsign=="")
                        calcu.Text += value2.ToString();                       
                        result.Text = (kq + value2).ToString();
                        kq += value2;
                        checksign = false;
                    }
                    else// phép tính dồn
                    {
                        converse(result.Text, ref value1);
                        calcu.Text = value1.ToString() + sign + value2.ToString();
                        kq += value2;
                        result.Text = (value1 + value2).ToString();
                        
                    }
                    specialsign = "";
                    check = false;
                    break;
                    
                case "-":
                    if (checksign)
                    {
                        converse(result.Text, ref value2);
                        if (specialsign == "xcany")
                        {
                            calcu.Text += value2.ToString() + ")";
                            value2 = Math.Pow(x, (double)1 / value2);
                        }
                        else if (specialsign == "xmuy")
                        {
                            calcu.Text += value2.ToString();
                            value2 = Math.Pow(y, value2);
                        }
                        else if (specialsign == "mod")
                        {
                            calcu.Text += value2.ToString();
                            value2 = a % value2;
                        }
                        else if (specialsign == "")
                            calcu.Text += value2.ToString();
                        result.Text = (kq - value2).ToString();
                        kq -= value2;
                        checksign = false;
                    }
                    else
                    {
                        converse(result.Text, ref value1);
                        calcu.Text = value1.ToString() + sign + value2.ToString();
                        kq -= value2;
                        result.Text = (value1 - value2).ToString();

                    }
                    specialsign = "";
                    check = false;
                    break;
                case "x":
                    
                    if (checksign)// phép 2 số
                    {
                        converse(result.Text, ref value2);
                       
                        if(specialsign=="")
                            calcu.Text += value2.ToString();
                        else
                        {
                            calcu.Text += value2.ToString();
                            if (specialsign == "xcany")
                            {
                                calcu.Text += ")";
                                value2 = Math.Pow(x, (double)1 / value2);
                            }
                            else if (specialsign == "xmuy")
                            {
                                value2 = Math.Pow(y, value2);
                            }
                            else if (specialsign == "mod")
                            {

                                value2 = a % value2;
                            }
                           
                        }
                       
                        specialsign = "";
                        if (sig == "+"|| sig=="")
                            kq += kqmul * value2;
                        else if (sig == "-")
                            kq -= kqmul * value2;
                        result.Text = kq.ToString();
                        kqmul = 1;
                        checksign = false;
                    }
                    else// phép tính dồn
                    {
                        converse(result.Text, ref value1);
                        calcu.Text = value1.ToString() + sign + value2.ToString();
                        kq *= value2;
                        result.Text = (value1 * value2).ToString();

                    }
                    check = false;
                    break;
                case ":":
                    converse(result.Text, ref value1);
                    
                    if (value1 != 0)
                    {
                        if (checksign)// phép 2 số
                        {
                            value2 = value1;//dùng cho phép chia dồn để giữ số chia;
                            if (specialsign == "")
                                calcu.Text += value1.ToString();
                            else
                            {
                                calcu.Text += value1.ToString();
                                if (specialsign == "xcany")
                                {
                                    calcu.Text += ")";
                                    value1 = Math.Pow(x, (double)1 / value1);
                                }
                                else if (specialsign == "xmuy")
                                    value1 = Math.Pow(y, value1);
                                else if (specialsign == "mod")
                                    value2 = a % value2;
                            }
   
                            if (sig == "+" || sig == "")
                                kq += kqmul / value1;
                            else if (sig == "-")
                                kq -= kqmul / value1;
                            result.Text = kq.ToString();
                            kqmul = 1;
                            specialsign = "";
                            checksign = false;
                        }
                        else// phép tính dồn
                        {                           
                            calcu.Text = value1.ToString() + sign + value2.ToString();
                            kq /= value2;
                            result.Text = kq.ToString();
                        }                       
                    }
                    else
                        result.Text = "Math error";
                    check = false;
                    break;
                case "":
                    if (specialsign == "xcany")
                    {
                        converse(result.Text, ref value1);
                        calcu.Text += result.Text + ")";
                        result.Text= (Math.Pow(x, (double)1 / value1)).ToString();
                        specialsign = "";
                    }
                    else
                         if (specialsign == "xmuy")
                         {
                                converse(result.Text, ref value1);
                                calcu.Text += result.Text;
                                result.Text = (Math.Pow(y, value1)).ToString();
                                specialsign = "";
                         }
                    else if (specialsign == "mod")
                    {
                        converse(result.Text, ref value1);
                        calcu.Text += result.Text;
                        result.Text = (a%value1).ToString();
                        specialsign = "";
                    }
                    else
                    calcu.Text = result.Text;
                    check = false;
                    break;
                default:
                    break;
            }
        }
        #endregion
        private void delete_Click(object sender, EventArgs e)
        {
            if(checksign==true)
            {
                int l = result.Text.Length;
                if (l > 1)
                {
                    string t = result.Text;
                    t = t.Remove(l - 1);
                    result.Text = t;
                }
                else if (l <= 1) result.Text = "0";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref value1);
            calcu.Text += "ln(" + result.Text + ")";
            if (value1 == 0)
            {
                result.Text = "Input Invalid";
                disablebut(false);
                // check = false;
            }
            else
                result.Text = Math.Log(value1).ToString();
            specialsign = "log";
        }

        bool can = true;
        #region phép căn bậc 2
        private void button1_Click(object sender, EventArgs e)
        {       
            converse(result.Text,ref value1);
           if(value1<0)
            {
                can = false;
                result.Text = "Invalid input";
                disablebut(can);
            }
            else
            {
                if (sign == "")
                    calcu.Text = "√(" + result.Text + ")";
                else
                    calcu.Text += "√(" + result.Text + ")";
                result.Text = Math.Sqrt(value1).ToString();
                specialsign = "can";
                check = true ;
               // checksign = true;
            }           
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            specialsign = "canba";

            converse(result.Text, ref value1);
            if (sign == "") calcu.Text = "∛(" + result.Text + ")";
            else calcu.Text += "∛(" + result.Text + ")";
            result.Text = (Math.Pow(value1, (double)1 / 3)).ToString();
            check = true;

        }
        double x;
        //xcany
        private void button3_Click(object sender, EventArgs e)
        {
            specialsign = "xcany";
            converse(result.Text, ref x);
            if (sign == "") calcu.Text = "(" + x.ToString() + "√";
            else calcu.Text+= "(" + x.ToString() + "can";
            result.Text = "0";
            check = false;
        }

        private void pi_Click(object sender, EventArgs e)
        {
           
            result.Text = (Math.PI).ToString();
            if (result.Text == "0") result.Text = "";   
       }

        double gt(double n)
        {
            double t = 1;
            for (double i = 1; i <= n; i++)
                t *= i;
            return t;
        }
        //giai thừa
        private void giaithua_Click(object sender, EventArgs e)
        {
            converse(result.Text,ref value1);
            if (value1 != (int)value1) result.Text = "Invalid number!";
            calcu.Text += value1.ToString() + "!";
            result.Text = gt(value1).ToString();
            specialsign = "can";
        }
        //binh phuong
        private void button26_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref value1);
           
            calcu.Text += value1.ToString() + "^2";
            result.Text =Math.Pow(value1,2).ToString();
            specialsign = "binhphuong";
        }
        //lap phuong
        private void button21_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref value1);
            calcu.Text += value1.ToString() + "^3";
            result.Text = Math.Pow(value1, 3).ToString();
            specialsign = "lapphuong";
        }
        //xmuy
        double y;
        private void button16_Click(object sender, EventArgs e)
        {
            specialsign = "xmuy";
            converse(result.Text, ref y);
           calcu.Text += y.ToString() + "^";
            result.Text = "0";
            check = false;
        }

        private void doc_Click(object sender, EventArgs e)
        {
            //if (result.Text == "0") result.Text = "";
            if (check)
                result.Text += ".";
            else
            {
                result.Text = "0.";
                check = true;
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            converse(result.Text,ref value1);
            calcu.Text += "sin(" + value1.ToString() + ")";
            value1 = value1 / 180 * Math.PI;
            if (value1 % (Math.PI) == 0)
                result.Text = "0";
            else
            result.Text = Math.Sin(value1).ToString();
            specialsign = "sin";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            converse(result.Text,ref value1);
            calcu.Text += "cos(" + value1.ToString() + ")";
   
            value1 =((double)value1 /180)* Math.PI;
            if (value1 % (Math.PI / 2) == 0&& value1%(Math.PI)!=0) result.Text = "0";
            else
            result.Text =Math.Cos(value1).ToString();
            specialsign = "cos";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref value1);
            calcu.Text += "tan(" + value1.ToString() + ")";

            value1 = ((double)value1 / 180) * Math.PI;
            if (value1 % (Math.PI / 2) == 0 && value1 % (Math.PI) != 0)
            {
                result.Text = "Math error";
                check = false;
            }
            else
                result.Text = Math.Tan(value1).ToString();
            specialsign = "tan";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref value1);
            calcu.Text += "cot(" + value1.ToString() + ")";

            value1 = ((double)value1 / 180) * Math.PI;
            if (value1 % (Math.PI) == 0)
            {
                result.Text = "Math error";
                check = false;
            }
            else
                result.Text =(1/Math.Tan(value1)).ToString();
            specialsign = "cot";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            converse(result.Text,ref value1);
            calcu.Text += "|" + result.Text + "|";
            result.Text = Math.Abs(value1).ToString();
            specialsign = "tuyetdoi";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref value1);
          
            calcu.Text += "1/" + result.Text;
            if (value1 == 0)
            {
                result.Text = "Cannot devide by zero";
                disablebut(false);
                check = false;
            }
            else
                result.Text = (1 / value1).ToString();
            specialsign = "1/x";
        }

        private void log_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref value1);
            calcu.Text += "log(" + result.Text + ")";
            if (value1 == 0)
            {
                result.Text = "Input Invalid";
                disablebut(false);
                // check = false;
            }
            else
                result.Text = Math.Log10(value1).ToString();
            specialsign = "log10";
        }
        void disablebut(bool can)
        {
            button1.Enabled = subtract.Enabled = can;
            button16.Enabled = can;
            button2.Enabled = can;
            button34.Enabled = can;
            button33.Enabled = can;
            button32.Enabled = can;
            button3.Enabled = can;
            button28.Enabled = can;
            button27.Enabled = can;
            button26.Enabled = can;
            button21.Enabled = can;
            button16.Enabled = can;
            button2.Enabled = can;
            devide.Enabled = can;
            multi.Enabled = can;
            add.Enabled = can;
           modbut.Enabled = giaithua.Enabled = log.Enabled = doc.Enabled = equal.Enabled = pi.Enabled = can;
            button6.Enabled = can;
            sin.Enabled = can;
        }

        double a;
        //mod
        private void modbut_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref a);
            calcu.Text += a.ToString()+"mod";
            check = false;
            specialsign = "mod";
        }
        double mtong=0;
        private void Mcong_Click(object sender, EventArgs e)
        {
            converse(result.Text,ref value1);
            mtong += value1;
            check = false;
            calcu.Text = "";
        }

        private void MC_Click(object sender, EventArgs e)
        {
            mtong = 0;           
        }

        private void MR_Click(object sender, EventArgs e)
        {
            result.Text = mtong.ToString();
            calcu.Text = "";
        }

        private void Mtru_Click(object sender, EventArgs e)
        {
            converse(result.Text, ref value1);
            mtong -= value1;
            check = false;
            calcu.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (can == false)
            {
                can = true;
                result.Text = "0";
                calcu.Text = "";
                disablebut(can);
                checksign = true;
                sign = "";
                kq = 0;
                kqmul = 1;
                check = true;
                specialsign = "";
            }
            else
            {
                sign = "";
                specialsign = "";
                checksign = true;
                kq = 0;
                kqmul = 1;
                result.Text = "0";
                calcu.Text = "";
                check = true;
            }          
        }        
    }
}
