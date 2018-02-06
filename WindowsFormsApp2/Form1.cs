﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        //Первый расчет
        public double T, n, nu_sinh, U,
               n_rem_per, n_pod, n_zub;
        public double Tvuh, Tpotr, nu_obsh, Upriv, Ured, U1_2, P_z1, P_z2, P_vuh, n_z1, n_z2,
            n_vuh, T_z1, T_z2, T_vuh, P_sh1, P_sh2, n_sh1, n_sh2, T_sh1, T_sh2;
        public double N_vhod, power;
        public string select;
        //Второй расчет
        public double Kap = 9750;
        public double t1, t2, t3;
        public double P1, P2, P3;
        public string metal_for_gear, metal_for_wheel;
        public double Kh_alpha, Kh_betta, Kh_v;
        public double H1, H2;
        public double k, σn_limb, Nh_o1, Nh_e1, Kh_l, σ_H1, σn_limb2, Nh_o12, Nh_e12, Kh_l2,
            σ_H12, min, Kh, part2, a, a1, m, z1_sum_z2, z1, z2, U1_2f, delta_U, b, b2, d1, d2,
            d_a1, d_a2, d_f1, d_f2, verify, V;
        public string k_width, accuracy;
        //Третий расчет
        public double Y_fi, Tmax, P_edr, P_podr, sigma_t;
        public string S_h;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Calculation()
        {
            /*----------------------------------------*/
            /*-------------ДЛЯ МУФТЫ-----------------*/
            if (select == "Муфта")
            {
                /*----------------Формулы для 1.1)--------*/
                Tvuh = (T * n) / 9550;
                nu_obsh = n_zub * n_pod * n_pod;
                Tpotr = Tvuh / nu_obsh;
                /*----------------Формулы для 1.2)--------*/
                Upriv = N_vhod / n;
                Ured = Upriv;
                U1_2 = Ured;
                /*----------------Формулы для 1.3)--------*/
                P_z1 = Tpotr * n_pod;
                P_z2 = P_z1 * n_zub;
                P_vuh = P_z2 * n_pod;
                /*----------------Формулы для 1.4)--------*/
                n_z1 = N_vhod;
                n_z2 = n_z1 / U1_2;
                n_vuh = n_z2;
                /*----------------Формулы для 1.5)--------*/
                T_z1 = (9550 * P_z1) / n_z1;
                T_z2 = (9550 * P_z2) / n_z2;
                T_vuh = (9550 * P_vuh) / n_vuh;
                /*-------------Вывод----------*/
                label13.Text = "P вых =  " + Tvuh;
                label14.Text = "n общ =  " + nu_obsh;
                label15.Text = "P потр =  " + Tpotr;
                label17.Text = "U прив =  " + Upriv;
                label18.Text = "U ред =  " + Ured;
                label19.Text = "U 1-2 =  " + U1_2;
                label21.Text = "P шк1 =  ";
                label22.Text = "P шк2 =  ";
                label23.Text = "P z1 =  " + P_z1;
                label24.Text = "P z2 =  " + P_z2;
                label25.Text = "P вых =  " + P_vuh;
                label26.Text = "n шк1 =  ";
                label27.Text = "n шк2 =  ";
                label28.Text = "n z1 =  " + n_z1;
                label29.Text = "n z2 =  " + n_z2;
                label30.Text = "n вых =  " + n_vuh;
                label33.Text = "T шк1 =  ";
                label34.Text = "T шк2 =  ";
                label35.Text = "T z1 =  " + T_z1;
                label36.Text = "T z2 =  " + T_z2;
                label37.Text = "T вых =  " + T_vuh;

            }
            /*-------------ДЛЯ РЕМЕННОЙ ПЕРЕДАЧИ----------*/
            if (select == "Ременная передача")
            {
                /*----------------Формулы для 1.1)--------*/
                Tvuh = (T * n) / 9550;
                nu_obsh = n_rem_per * n_zub * n_pod * n_pod;
                Tpotr = Tvuh / nu_obsh;
                /*----------------Формулы для 1.2)--------*/
                Upriv = N_vhod / n;
                Ured = Upriv / U;
                U1_2 = Ured;
                /*----------------Формулы для 1.3)--------*/
                P_sh1 = Tpotr;
                P_sh2 = P_sh1 * nu_obsh;
                P_z1 = P_sh2 * n_pod;
                P_z2 = P_z1 * n_zub;
                P_vuh = P_z2 * n_pod;
                /*----------------Формулы для 1.4)--------*/
                n_sh1 = N_vhod;
                n_sh2 = N_vhod / U;
                n_z1 = n_sh2;
                n_z2 = n_z1 / U1_2;
                n_vuh = n_z2;
                /*----------------Формулы для 1.5)--------*/
                T_sh1 = (9550 * P_sh1) / n_sh1;
                T_sh2 = (9550 * P_sh2) / n_sh2;
                T_z1 = (9550 * P_z1) / n_z1;
                T_z2 = (9550 * P_z2) / n_z2;
                T_vuh = (9550 * P_vuh) / n_vuh;
                /*----------------------------------------*/
                /*-------------Вывод----------*/
                label13.Text = "P вых =  " + Tvuh;
                label14.Text = "n общ =  " + nu_obsh;
                label15.Text = "P потр =  " + Tpotr;
                label17.Text = "U прив =  " + Upriv;
                label18.Text = "U ред =  " + Ured;
                label19.Text = "U 1-2 =  " + U1_2;
                label21.Text = "P шк1 =  " + P_sh1;
                label22.Text = "P шк2 =  " + P_sh2;
                label23.Text = "P z1 =  " + P_z1;
                label24.Text = "P z2 =  " + P_z2;
                label25.Text = "P вых =  " + P_vuh;
                label26.Text = "n шк1 =  " + n_sh1;
                label27.Text = "n шк2 =  " + n_sh2;
                label28.Text = "n z1 =  " + n_z1;
                label29.Text = "n z2 =  " + n_z2;
                label30.Text = "n вых =  " + n_vuh;
                label33.Text = "T шк1 =  " + T_sh1;
                label34.Text = "T шк2 =  " + T_sh2;
                label35.Text = "T z1 =  " + T_z1;
                label36.Text = "T z2 =  " + T_z2;
                label37.Text = "T вых =  " + T_vuh;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            T = (double.Parse(textBox1.Text));
            n = (double.Parse(textBox2.Text));
            nu_sinh = (double.Parse(textBox3.Text));
            U = (double.Parse(textBox4.Text));
            n_rem_per = (double.Parse(textBox5.Text));
            n_pod = (double.Parse(textBox6.Text));
            n_zub = (double.Parse(textBox7.Text));
            N_vhod = double.Parse(comboBox2.SelectedItem.ToString());
            power = double.Parse(comboBox1.SelectedItem.ToString());
            select = comboBox3.SelectedItem.ToString();//Из списка вытягиваем выбранное значение
            Calculation();
        }

        public void Calculation1()
        {
            /*----------------Считывание ввода-----------*/
            switch (metal_for_gear)
            {
                case "40Х, 45, 40ХН":
                    H1 = 280;
                    break;
                case "40Х, 40ХН, 35ХМ":
                    H1 = 53;
                    break;
                case "20Х, 20ХНМ":
                    H1 = 61;
                    break;
            }
            switch (metal_for_wheel)
            {
                case "40Х, 45, 40ХН":
                    H2 = 250;
                    break;
                case "40Х, 40ХН, 35ХМ":
                    H2 = 52;
                    break;
                case "20Х, 20ХНМ":
                    H2 = 60;
                    break;
            }
            switch (k_width)
            {
                case "0.1":
                    k = 0.1;
                    break;
                case "0,125":
                    k = 0.125;
                    break;
                case "0,16":
                    k = 0.16;
                    break;
                case "0,2":
                    k = 0.2;
                    break;
                case "0,25":
                    k = 0.25;
                    break;
                case "0,315":
                    k = 0.315;
                    break;
                case "0,4":
                    k = 0.4;
                    break;
                case "0,5":
                    k = 0.5;
                    break;
                case "0,630":
                    k = 0.630;
                    break;
                case "0,8":
                    k = 0.8;
                    break;
                case "1":
                    k = 1;
                    break;
                case "1,25":
                    k = 1.25;
                    break;
            }
            /*---------------------------------------*/
            /*----------------Вычисление 2.1)-------------*/
            /*Для шестрени */
            σn_limb = 2 * H1 + 70;
            Nh_o1 = Math.Round(30 * Math.Pow(σn_limb, 2.4));
            Nh_e1 = Math.Round(60 * n_z1 * (t1 * Math.Pow(P1, 3) + t2 * Math.Pow(P2, 3) + t3 * Math.Pow(P3, 3)));
            Kh_l = Math.Round(Math.Pow(Nh_o1 / Nh_e1, 1 / 6));
            if (Kh_l >= 1)
            {
                Kh_l = Kh_l;
            }
            else Kh_l = 1;
            σ_H1 = Math.Round(((σn_limb / 1.1) * Kh_l));
            /*Для колеса */
            σn_limb2 = 2 * H2 + 70;
            Nh_o12 = Math.Round(30 * Math.Pow(σn_limb2, 2.4));
            Nh_e12 = Math.Round(Nh_e1 / U1_2);
            Kh_l2 = Math.Round(Math.Pow(Nh_o12 / Nh_e12, 1 / 6));
            if (Kh_l2 >= 1)
            {
                Kh_l2 = Kh_l2; ;
            }
            else Kh_l2 = 1;
            σ_H12 = Math.Round(((σn_limb2 / 1.1) * Kh_l2));
            min = Math.Min(σ_H1, σ_H12);
            /******************************************/
            /*----------------Вычисление 2.2)-------------*/
            Kh = Math.Round(Kh_alpha * Kh_betta * Kh_v, 4);
            /*----------------Вычисление 2.3)-------------*/
            part2 = (P_z1 * Kh_betta * Kh_v * Kh_alpha) / (k * n_z1 * U1_2 * Math.Pow(min, 2));
            a = Kap * (U1_2 + 1) * (Math.Round((Math.Pow(part2, 1 / 3)), 3));
            if (a >= 103.545)
            {
                a = 105;
            }
            /*----------------Вычисление 2.4)-------------*/
            m = 0.01 * a;
            if (m >= 1 && m < 1.25)
            {
                m = 1.25;
            }
            if (m >= 1.125 && m < 1.375)
            {
                m = 1.3125;
            }
            if (m >= 1.375 && m < 1.5)
            {
                m = 1.507;
            }
            if (m >= 1.5 && m < 1.75)
            {
                m = 1.625;
            }
            z1_sum_z2 = (2 * a) / m;
            /*----------------Вычисление 2.5)-------------*/
            z1 = Math.Round(z1_sum_z2 / (U1_2 + 1));
            z2 = Math.Round(z1_sum_z2 - z1);
            U1_2f = Math.Round((z2 / z1), 2);
            delta_U = Math.Round((Math.Abs((U1_2 - U1_2f) / (U1_2)) * 100), 2);
            /*----------------Вычисление 2.6)-------------*/
            b = b2 = k * a;
            /*----------------Вычисление 2.7)-------------*/
            d1 = Math.Round(m * z1, 2);
            d2 = Math.Round(m * z2, 2);
            d_a1 = Math.Round(d1 + 2 * m, 2);
            d_a2 = Math.Round(d2 + 2 * m, 2);
            d_f1 = Math.Round(d1 - 2.5 * m, 2);
            d_f2 = Math.Round(d2 - 2.5 * m, 2);
            verify = (d1 / 2) + (d2 / 2);
            /*----------------Вычисление 2.8)-------------*/
            V = Math.Round((Math.PI * d1 * n_z1) / 60000, 2);
            /*----------------Определение точности)-------------*/
            //Коническая передача
            if (V >= 1.5 && V < 2)
            {
                accuracy = "9" + " " + "/nдля конической передачи";
            }

            if (V >= 2 && V < 4)
            {
                accuracy = "8" + " " + "/nдля конической передачи";
            }

            if (V >= 4 && V < 6)
            {
                accuracy = "7" + " " + "/nдля конической передачи";
            }
            if (V >= 8 && V < 10)
            {
                accuracy = "6" + " " + "/nдля конической передачи";
            }
            if (V >= 12 && V < 15)
            {
                accuracy = "5" + " " + "/nдля конической передачи";
            }

            /*-------------Вывод----------*/
            //2.1.1
            label38.Text = "H1 =  " + H1 + "(НВ)";
            label39.Text = "Sh =  " + 1.1;
            label40.Text = "σn_limb =  " + σn_limb + "(мПА)";
            label41.Text = "Nh_o1 =   " + Nh_o1;
            label42.Text = "Nh_e1 = " + Nh_e1;
            label44.Text = "Kh_l =  " + Kh_l;
            label45.Text = "σ_H1 =  " + σ_H1 + "(мПА)";
            //2.1.2
            label46.Text = "H2 =  " + H2 + "(НВ)";
            label47.Text = "Sh =  " + 1.1;
            label48.Text = "σn_limb =  " + σn_limb2 + "(мПА)";
            label50.Text = "Nh_o2 =   " + Nh_o12;
            label51.Text = "Nh_e2 = " + Nh_e12;
            label52.Text = "Kh_l =  " + Kh_l2;
            label53.Text = "σ_H2 =  " + σ_H12 + "(мПА)";
            label58.Text = min + "(мПА)";
            //2.2
            label49.Text = "Kh_alpha = " + Kh_alpha;
            label55.Text = "Kh_betta = " + Kh_betta;
            label59.Text = "Kh_v = " + Kh_v;
            label60.Text = "Kh = " + Kh;
            //2.3
            label62.Text = "a = " + a + "(мм)";
            //2.4
            label65.Text = "m = " + m + "(мм)";
            label66.Text = "z1 + z2 = " + z1_sum_z2;
            //2.5
            label86.Text = "z1 = " + z1;
            label87.Text = "z2 = " + z2;
            label88.Text = "U1_2f = " + U1_2f;
            label89.Text = "delta = " + delta_U + "%" + "<2.5%";
            //2.6
            label91.Text = "b2 = b = " + b2 + "(мм)";
            //2.7
            label93.Text = "d1 =  " + d1 + "(мм)";
            label94.Text = "d2 =  " + d2 + "(мм)";
            label95.Text = "d_a1 =  " + d_a1 + "(мм)";
            label96.Text = "d_a2 =   " + d_a2 + "(мм)";
            label97.Text = "d_f1 = " + d_f1 + "(мм)";
            label98.Text = "d_f2 =  " + d_f2 + "(мм)";
            label70.Text = "Проверка : 1/2 * d1 + 1/2 * d2 = a " + verify + "=" + a;
            //2.8
            label100.Text = "V = " + V + "(м/c)";
            label101.Text = "Степень точности зубчаты передач : " + accuracy;

        }

        private void Расчет1_Click(object sender, EventArgs e)
        {
            t1 = (double.Parse(textBox9.Text));
            t2 = (double.Parse(textBox16.Text));
            t3 = (double.Parse(textBox18.Text));
            P1 = (double.Parse(textBox8.Text));
            P2 = (double.Parse(textBox15.Text));
            P3 = (double.Parse(textBox17.Text));
            Kh_alpha = (double.Parse(textBox21.Text));
            Kh_betta = (double.Parse(textBox20.Text));
            Kh_v = (double.Parse(textBox19.Text));
            metal_for_gear = comboBox9.SelectedItem.ToString();
            metal_for_wheel = comboBox8.SelectedItem.ToString();
            k_width = comboBox9.SelectedItem.ToString();
            Calculation1();
        }

        public void Calculation2()
        {

            /*----------------Вычисление 3.1)------------*/
            //$E_a = round(1.88 - 3.2 * ((1 / $z_3) + (1 / $z_4)),2);
            //$Z_e = round(sqrt((4 - $E_a) / 3),2);
            //$sigma_n = round( Z_m * Z_h * $Z_e * (1 / $d_3)* sqrt((2000*9550 * $Pz1 * $Kh_alpha * $Kh_betta * $Kh_v * ($U1_2_f + 1))/($n1 * $b2 * $U1_2_f)),2);
            //if ($sigma_n <= $sigma_solve) {
            //    $verify3_1 = "$sigma_n < $sigma_solve" . "<br>" . 'Проверка пройдена';
            //} else $verify3_1 =  "$sigma_n > $sigma_solve" . "<br>" . 'Ошибка';
            ///*--------------------------------------------*/

            ///*----------------Вычисление 3.2)-------------*/
            ///*----------------Для шестерни----------------*/
            //$sigma_f_limb1 = 1.8 * $H_hb1;
            //$N_fe1 = 60 * $n1 * ($t1 * pow($P1, 6) + $t2 * pow($P2, 6) + $t3 * pow($P3, 6));
            //$K_fl = pow((N_f0 / $N_fe1), 1 / m);
            //if($K_fl > 1) {
            //    $K_fl = $K_fl;
            //}
            //else {
            //    $K_fl = 1;
            //}
            //$sigma_f1 = round(($sigma_f_limb1 / $s_f),1);
            ///*----------------Для колеса----------------*/
            //$sigma_f_limb2 = 1.8 * $H_hb2;
            //$N_fe2 = $N_fe1 / $U1_2_f ;
            //$K_fl = pow((N_f0 / $N_fe2), 1 / m);
            //if($K_fl > 1) {
            //    $K_fl = $K_fl;
            //}
            //else {
            //    $K_fl = 1;
            //}
            //$sigma_f2 = round(($sigma_f_limb2 / $s_f),1);
            //switch ($z_3) {
            // case (17<=$z_3 || $z_3=19) :
            // $Y_f1 = 4.28;
            // break;
            // case (20<=$z_3 || $z_3<=24) :
            // $Y_f1 = 4.09;
            // break;
            // case (25<=$z_3 || $z_3<=29) :
            // $Y_f1 = 3.9;
            // break;
            // case (30<=$z_3 || $z_3<=39) :
            // $Y_f1 = 3.8;
            // break;
            // case (40<=$z_3 || $z_3<=49) :
            // $Y_f1 = 3.7;
            // break;
            // case (50<=$z_3 || $z_3<=59) :
            // $Y_f1 = 3.65;
            // break;
            // case (60<=$z_3 || $z_3<=79) :
            // $Y_f1 = 3.62;
            // break;
            // case (80<=$z_3 || $z_3<100) :
            // $Y_f1 = 3.61;
            // break;
            // case ($z_3>=100) :
            // $Y_f1 = 3.6;
            // break;
            //}
            //$verify3_2_1 = $sigma_f1 / $Y_f1;
            //switch ($z_4) {
            //    case (17<=$z_4 || $z_4<=19) :
            //    $Y_f2 = 4.28;
            //    break;
            //    case (20<=$z_4 || $z_4<=24) :
            //    $Y_f2 = 4.09;
            //    break;
            //    case (25<=$z_4 || $z_4<=29) :
            //    $Y_f2 = 3.9;
            //    break;
            //    case (30<=$z_4 || $z_4<=39) :
            //    $Y_f2 = 3.8;
            //    break;
            //    case (40<=$z_4 || $z_4<=49) :
            //    $Y_f2 = 3.7;
            //    break;
            //    case (50<=$z_4 || $z_4<=59) :
            //    $Y_f2 = 3.65;
            //    break;
            //    case (60<=$z_4 || $z_4<=79) :
            //    $Y_f2 = 3.62;
            //    break;
            //    case (80<=$z_4 || $z_4<100) :
            //    $Y_f2 = 3.61;
            //    break;
            //    case ($z_4>=100) :
            //    $Y_f2 = 3.6;
            //    break;
            //}
            //$verify3_2_2 = $sigma_f2 / $Y_f2;
            //if ($verify3_2_1 > $verify3_2_2) {
            //    $sigma_f1_1 = $Y_f2 * ((2000 * 9550 * $Pz1 * $Kf_alpha * $Kf_betta * $Kf_v)/(m * $b2 * $d_3 * $sigma_f2));
            //    $verify3_2_2 = "$sigma_f1_1 < $sigma_f1" . "<br>" . 'Проверка пройдена';
            //}
            //else {
            //    $sigma_f1_1 = $Y_f1 * ((2000 * 9550 * $Pz1 * $Kf_alpha * $Kf_betta * $Kf_v)/(m * $b2 * $d_3 * $z_4));
            //}
            ///*---------------------------------------------*/

            ///*----------------Вычисление 3.3)-------------*/
            //$k_per = round(($T_max) * ($P_ed / $P_potr),2);
            //$sigma_n_max = round($sigma_n * sqrt($k_per),1);
            //$sigma_n_max1 = 2.8 * $sigma_t;
            //if ($sigma_n_max <= $sigma_n_max1) {
            //    $verify3_3 = "$sigma_n_max < $sigma_n_max1" . "<br>" . 'Проверка пройдена';
            //} else $verify3_3 = 'Ошибка';
            ///*---------------------------------------------*/

            ///*----------------Вычисление 3.4)-------------*/
            //$sigma_f_max = round($sigma_f1_1 * $k_per,1);
            //$sigma_f_max1 = 2.75 * $H_hb2;
            //if ($sigma_f_max <= $sigma_f_max1) {
            //    $verify3_4 = "$sigma_f_max < $sigma_f_max1" . "<br>" . 'Проверка пройдена';
            //} else $verify3_4 = 'Ошибка';
            ///*---------------------------------------------*/
            //        }
            //    }
        }
    }
}











/*//Цилиндрическая передача
               case V>=15:
               accuracy = '5A' . ' ' . 'для цилиндрической передачи';
               break;
               case V<15:
               accuracy = '6A' . ' ' . 'для цилиндрической передачи';
               break;
               case V<10:
               accuracy = '7A' . ' ' . 'для цилиндрической передачи';
               break;
               case V<6:
               accuracy = '8A' . ' ' . 'для цилиндрической передачи';
               break;
               case V<2:
               accuracy = '9A' . ' ' . 'для цилиндрической передачи';
               break;*/
