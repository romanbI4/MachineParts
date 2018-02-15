using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        //Первый расчет
        public double T, n, nu_sinh, U, n_rem_per, n_pod, n_zub, Tvuh, Tpotr, nu_obsh, Upriv,
            Ured, U1_2, P_z1, P_z2, P_vuh, n_z1, n_z2, n_vuh, T_z1, T_z2, T_vuh, P_sh1, P_sh2,
            n_sh1, n_sh2, T_sh1, T_sh2, N_vhod, power;
        public string select;
        //Второй расчет
        public double Kap = 9750, t1, t2, t3, P1, P2, P3, Kh_alpha, Kh_betta, Kh_v, H1, H2,
            k, σn_limb, Nh_o1, Nh_e1, Kh_l, σ_H1, σn_limb2, Nh_o12, Nh_e12, Kh_l2, σ_H12, min,
            Kh, part2, a, a1, m, z1_sum_z2, z1, z2, U1_2f, delta_U, b, b2, d1, d2, d_a1, d_a2,
            d_f1, d_f2, verify, V;
        public string metal_for_gear, metal_for_wheel, k_width, accuracy;
        //Третий расчет
        public double Y_fi, T_max, P_ed, P_potr, sigma_t, E_a, Z_e, sigma_n, Z_m = 275, Z_h,
            sigma_solve, sigma_f_limb1, N_fe1, K_fl, Kf_alpha = 1, Kf_betta = 1, Kf_v = 1.15,
            N_f0 = 4000000, sigma_f1, s_f, sigma_f_limb2, N_fe2, U1_2_f, sigma_f2, sigma_f1_1,
            k_per, sigma_n_max, sigma_f_max, sigma_f_max1, sigma_n_max1, Y_f1, Y_f2,
            verify3_2_1, verify3_2_2;
        public string S_h, verify3_4, verify3_3, verify3_1, verify3_2_2_2;
        //Четвертый расчет
        public double K_nu = 1.6, K_tao = 1.4, K_sigma = 1.5, K_tao_d = 0.7, K_sigma_b = 0.81,
            d, d3, d4, d5, l1, l2, P_tabl = 2, sigma_b = 400, F_t1, F_t2, F_r1, F_r2, R_a1, R_a2, sigma_sk1, sigma_sk2, tao_kr11, tao_kr12,
            sigma_minus_1, tao_minus_1, K_sigma_d, P_sigma_1, P_sigma_2, P_tao_11, P_tao_12, P11, P12;
        public string result1, result2;
        //Пятый расчет
        public double C1, L10_ah1, P_r1, P_r2, L10_ah2, L10_2, L10_1, C2, Y = 0, X = 1, K_b = 1.2,
            K_t = 1, V_c = 1, P = 3, a1_1 = 1, a23 = 0.75, Lh_potr = 12000;

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

        private void Button2_Click_1(object sender, EventArgs e)
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
            k = double.Parse(k_width);
            /*---------------------------------------*/
            /*----------------Вычисление 2.1)-------------*/
            /*Для шестрени */
            σn_limb = 2 * H1 + 70;
            Nh_o1 = Math.Round(30 * Math.Pow(σn_limb, 2.4));
            Nh_e1 = Math.Round(60 * n_z1 * (t1 * Math.Pow(P1, 3) + t2 * Math.Pow(P2, 3) + t3 * Math.Pow(P3, 3)));
            Kh_l = Math.Round(Math.Pow(Nh_o1 / Nh_e1, 1 / 6));
            if (Kh_l <= 1)
            {
                Kh_l = 1;
            }
            σ_H1 = Math.Round(((σn_limb / 1.1) * Kh_l));
            /*Для колеса */
            σn_limb2 = 2 * H2 + 70;
            Nh_o12 = Math.Round(30 * Math.Pow(σn_limb2, 2.4));
            Nh_e12 = Math.Round(Nh_e1 / U1_2);
            Kh_l2 = Math.Round(Math.Pow(Nh_o12 / Nh_e12, 1 / 6));
            if (Kh_l2 <= 1)
            {
                Kh_l2 = 1;
            }
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
            b2 = k * a;
            b = b2;
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
            k_width = comboBox7.SelectedItem.ToString();
            Calculation1();
        }

        public void Calculation2()
        {

            /*----------------Вычисление 3.1)------------*/
            E_a = Math.Round(1.88 - 3.2 * ((1 / z1) + (1 / z2)), 2);
            Z_h = Math.Sqrt(2 / Math.Sin(2 * 20));
            Z_e = Math.Round(Math.Sqrt((4 - E_a) / 3), 2);
            sigma_n = Math.Round(Z_m * Z_h * Z_e * (1 / d1) * Math.Sqrt((2000 * 9550 * P_z1 * Kh_alpha * Kh_betta * Kh_v * (U1_2f + 1)) / (n_z1 * b * U1_2f)), 2);
            if (sigma_n <= min)
            {
                verify3_1 = sigma_n + "<" + min + "Проверка пройдена";
            }
            else verify3_1 = sigma_n + ">" + min + "Ошибка";
            /*--------------------------------------------*/

            /*----------------Вычисление 3.2)-------------*/
            /*----------------Для шестерни----------------*/
            sigma_f_limb1 = 1.8 * H1;
            N_fe1 = 60 * n_z1 * (t1 * Math.Pow(P1, 6) + t2 * Math.Pow(P2, 6) + t3 * Math.Pow(P3, 6));
            K_fl = Math.Pow((N_f0 / N_fe1), 1 / m);
            if (K_fl <= 1)
            {
                K_fl = 1;
            }
            switch (S_h)
            {
                case "2.2":
                    s_f = 2.2;
                    break;
                case "1.75":
                    s_f = 1.75;
                    break;
            }
            sigma_f1 = Math.Round((sigma_f_limb1 / s_f), 1);
            /*----------------Для колеса----------------*/
            sigma_f_limb2 = 1.8 * H2;
            N_fe2 = N_fe1 / U1_2f;
            K_fl = Math.Pow((N_f0 / N_fe2), 1 / m);
            if (K_fl <= 1)
            {
                K_fl = 1;
            }
            sigma_f2 = Math.Round((sigma_f_limb2 / s_f), 1);
            if (z1 >= 17 || z1 <= 19)
            {
                Y_f1 = 4.28;
            }
            if (z1 >= 20 || z1 <= 24)
            {
                Y_f1 = 4.09;
            }
            if (z1 >= 25 || z1 <= 29)
            {
                Y_f1 = 3.9;
            }
            if (z1 >= 30 || z1 <= 39)
            {
                Y_f1 = 3.8;
            }
            if (z1 >= 40 || z1 <= 49)
            {
                Y_f1 = 3.7;
            }
            if (z1 >= 50 || z1 <= 59)
            {
                Y_f1 = 3.65;
            }
            if (z1 >= 60 || z1 <= 79)
            {
                Y_f1 = 3.62;
            }
            if (z1 >= 80 || z1 < 100)
            {
                Y_f1 = 3.61;
            }
            if (z1 >= 100)
            {
                Y_f1 = 3.6;
            }
            verify3_2_1 = sigma_f1 / Y_f1;
            if (z2 >= 17 || z2 <= 19)
            {
                Y_f2 = 4.28;
            }
            if (z2 >= 20 || z2 <= 24)
            {
                Y_f2 = 4.09;
            }
            if (z2 >= 25 || z2 <= 29)
            {
                Y_f2 = 3.9;
            }
            if (z2 >= 30 || z2 <= 39)
            {
                Y_f2 = 3.8;
            }
            if (z2 >= 40 || z2 <= 49)
            {
                Y_f2 = 3.7;
            }
            if (z2 >= 50 || z2 <= 59)
            {
                Y_f2 = 3.65;
            }
            if (z2 >= 60 || z2 <= 79)
            {
                Y_f2 = 3.62;
            }
            if (z2 >= 80 || z2 < 100)
            {
                Y_f2 = 3.61;
            }
            if (z2 >= 100)
            {
                Y_f2 = 3.6;
            }
            verify3_2_2 = sigma_f2 / Y_f2;
            if (verify3_2_1 > verify3_2_2)
            {
                sigma_f1_1 = Y_f2 * ((2000 * 9550 * P_z2 * Kf_alpha * Kf_betta * Kf_v) / (m * b2 * d2 * n_z2));
                verify3_2_2_2 = sigma_f1_1 + "<" + sigma_f1 + "Проверка пройдена";
            }
            else
            {
                sigma_f1_1 = Y_f1 * ((2000 * 9550 * P_z1 * Kf_alpha * Kf_betta * Kf_v) / (m * b2 * d1 * z2));
            }
            /*---------------------------------------------*/

            /*----------------Вычисление 3.3)-------------*/
            k_per = Math.Round((T_max) * (P_ed / P_potr), 2);
            sigma_n_max = Math.Round(sigma_n * Math.Sqrt(k_per), 1);
            sigma_n_max1 = 2.8 * sigma_t;
            if (sigma_n_max <= sigma_n_max1)
            {
                verify3_3 = sigma_n_max + "<" + sigma_n_max1 + "Проверка пройдена";
            }
            else verify3_3 = "Ошибка";
            /*---------------------------------------------*/

            /*----------------Вычисление 3.4)-------------*/
            sigma_f_max = Math.Round(sigma_f1_1 * k_per, 1);
            sigma_f_max1 = 2.75 * H2;
            if (sigma_f_max <= sigma_f_max1)
            {
                verify3_4 = sigma_f_max + "<" + sigma_f_max1 + "Проверка пройдена";
            }
            else verify3_4 = "Ошибка";
            /*---------------------------------------------*/

            /*-------------Вывод----------*/
            //3.1
            label142.Text = "Ea =  " + E_a;
            label141.Text = "Ze =  " + Z_e;
            label140.Text = "Zh =  " + Z_h;
            label139.Text = "Kh_alpha =   " + Kh_alpha;
            label138.Text = "Kh_betta = " + Kh_betta;
            label137.Text = "Kh_v =  " + Kh_v;
            label136.Text = "Simga_n =  " + sigma_n;
            label150.Text = "Результат: =  " + verify3_1;
            //3.2.1
            label133.Text = "sigma_f =  " + sigma_f_limb1;
            label134.Text = "Sf =  " + s_f;
            label127.Text = "Nf_e =  " + N_fe1;
            label128.Text = "Kf_l =   " + K_fl;
            label129.Text = "sigma_f1 = " + sigma_f1;
            //3.2.2
            label156.Text = "sigma_f * lim b = " + sigma_f_limb2;
            label153.Text = "Sf = " + s_f;
            label152.Text = "Nf_e = " + N_fe2;
            label151.Text = "Kf_l = " + K_fl;
            label143.Text = "sigma_f2 = " + sigma_f2;
            label131.Text = "Sigma_f Расчетное = " + sigma_f1_1;
            label130.Text = verify3_2_2_2;
            //3.3
            label107.Text = "Sigma_n_Max = " + sigma_n_max;
            label106.Text = "K_per = " + k_per;
            label105.Text = "Sigma_n_Max1 = " + sigma_n_max1;
            label104.Text = verify3_3;
            //3.4
            label102.Text = "Sigma_f = " + sigma_f_max;
            label73.Text = "sigma_f_max1 =  " + sigma_f_max1;
            label72.Text = verify3_4;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Y_fi = (double.Parse(textBox11.Text));
            T_max = (double.Parse(textBox10.Text));
            P_ed = (double.Parse(textBox13.Text));
            P_potr = (double.Parse(textBox12.Text));
            sigma_t = (double.Parse(textBox14.Text));
            S_h = comboBox4.SelectedItem.ToString();
            Calculation2();
        }

        public void Calculation3()
        {

            F_t1 = (2 * T_z1) / (d1 * 0.001);
            F_t2 = (2 * T_z2) / (d_a2 * 0.001);
            F_r1 = F_t1 * 0.363970;
            F_r2 = F_t2 * 0.363970;
            R_a1 = Math.Pow(((Math.Pow(F_r1, 2)) + (Math.Pow(F_t1, 2))), 0.5);
            R_a2 = Math.Pow(((Math.Pow(F_r2, 2)) + (Math.Pow(F_t2, 2))), 0.5);
            /*-------------------------------------------------------*/
            /*----------------ПРОВЕРКА ДИАМЕТРОВ для 2-х колес------------*/
            d2 = 130 * Math.Pow((P_potr / n_z1), 0.333333);
            d4 = 130 * Math.Pow((P_potr / n_z2), 0.333333);
            if (d2 >= 20 && d2 < 40)
            {
                d = 35;
            }
            if (d2 >= 40 && d2 < 50)
            {
                d = 45;
            }
            if (d2 >= 50 && d2 < 60)
            {
                d = 55;
            }
            if (d2 >= 60 && d2 < 70)
            {
                d = 65;
            }
            if (d2 >= 70 && d2 < 80)
            {
                d = 75;
            }
            if (d2 >= 80 && d2 < 90)
            {
                d = 85;
            }
            if (d2 >= 90 && d2 < 100)
            {
                d = 95;
            }

            if (d4 >= 30 && d4 < 40)
            {
                d5 = 35;
            }
            if (d4 >= 40 && d4 < 50)
            {
                d5 = 45;
            }
            if (d4 >= 50 && d4 < 60)
            {
                d5 = 55;
            }
            if (d4 >= 60 && d4 < 70)
            {
                d5 = 65;
            }
            if (d4 >= 70 && d4 < 80)
            {
                d5 = 75;
            }
            if (d4 >= 80 && d4 < 90)
            {
                d5 = 85;
            }
            if (d4 >= 90 && d4 < 100)
            {
                d5 = 95;
            }
            /*----------------Вычисление для 1-го колеса)------------*/
            tao_kr11 = T_z1 / (0.2 * Math.Pow(d, 3) * Math.Pow(10, -3));
            sigma_sk1 = (R_a1 * ((l1 + l2) / 2)) / (0.1 * Math.Pow(d, 3));
            /*-------------------------------------------------------*/
            /*----------------Вычисление для 2-го колеса)------------*/
            tao_kr12 = T_z2 / (0.2 * Math.Pow(d5, 3) * Math.Pow(10, -3));
            sigma_sk2 = (R_a2 * ((l1 + l2) / 2)) / (0.1 * Math.Pow(d5, 3));
            /*-------------------------------------------------------*/
            /*----------------Общие вычисления для 2-х колес------------*/
            sigma_minus_1 = 0.55 * sigma_b;
            tao_minus_1 = 0.6 * sigma_minus_1;
            K_sigma_d = (1 / K_nu) * ((K_sigma / K_sigma_b) * (Kh_betta + 1));
            /*-------------------------------------------------------*/
            /*----------------Вычисление для 1-го колеса)------------*/
            P_sigma_1 = sigma_minus_1 / (K_sigma_d * sigma_sk1);
            P_tao_11 = tao_minus_1 / (K_tao_d * tao_kr11);
            P11 = (P_sigma_1 * P_tao_11) / (Math.Sqrt(Math.Pow(P_sigma_1, 2) + Math.Pow(P_tao_11, 2)));
            /*-------------------------------------------------------*/
            /*----------------Вычисление для 2-го колеса)------------*/
            P_sigma_2 = sigma_minus_1 / (K_sigma_d * sigma_sk2);
            P_tao_12 = tao_minus_1 / (K_tao_d * tao_kr12);
            P12 = (P_sigma_2 * P_tao_12) / (Math.Sqrt(Math.Pow(P_sigma_2, 2) + Math.Pow(P_tao_12, 2)));
            /*-------------------------------------------------------*/
            if (P11 >= P_tabl)
            {
                result1 = "Все посчитано верно,d1 = " + d;
            }
            else result1 = "Все посчитано не верно";
            if (P12 >= P_tabl)
            {
                result2 = "Все посчитано верно,d2 = " + d5;
            }
            else result2 = "Все посчитано не верно";
            /****************ВЫВОД**//////////////
            //для 1-го колеса
            label171.Text = "Ft_1 =  " + F_t1;
            label170.Text = "Ft_2 =  " + F_t2;
            label169.Text = "Fr_1 =  " + F_r1;
            label168.Text = "Fr_2 =   " + F_r2;
            label167.Text = "R_a1 = " + R_a1;
            label166.Text = "sigma_k1 =  " + sigma_sk1;
            label165.Text = "tao_kr11 =  " + tao_kr11;
            label120.Text = "sigma_minus_1: =  " + sigma_minus_1;
            label162.Text = "tao_minus_1 =  " + tao_minus_1;
            label163.Text = "K_sigma_d =  " + K_sigma_d;
            label158.Text = "P_sigma_1 =  " + P_sigma_1;
            label159.Text = "P_tao_11 =   " + P_tao_11;
            label160.Text = "P11 = " + P11;
            label117.Text = "Все подсчитано верно = " + d;
            //для 2-го колеса
            label125.Text = "Ft_1 =  " + F_t1;
            label124.Text = "Ft_2 =  " + F_t2;
            label123.Text = "Fr_1 =  " + F_r1;
            label122.Text = "Fr_2 =   " + F_r2;
            label116.Text = "R_a1 = " + R_a2;
            label115.Text = "sigma_k2 =  " + sigma_sk2;
            label114.Text = "tao_kr12 =  " + tao_kr12;
            label113.Text = "sigma_minus_1: =  " + sigma_minus_1;
            label112.Text = "tao_minus_1 =  " + tao_minus_1;
            label121.Text = "K_sigma_d =  " + K_sigma_d;
            label119.Text = "P_sigma_2 =  " + P_sigma_2;
            label111.Text = "P_tao_12 =   " + P_tao_12;
            label110.Text = "P12 = " + P12;
            label109.Text = "Все подсчитано верно = " + d5;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            l1 = double.Parse(textBox26.Text.ToString());
            l2 = double.Parse(textBox25.Text.ToString());
            Calculation3();
        }

        public void Calculation4()
        {
            if (d == 35 && C1 == 25500)
            {
                if (L10_ah1 > Lh_potr)
                {
                    L10_1 = Math.Round(a1_1 * a23 * (Math.Pow(C1 / P_r1, P)), 1);
                    L10_ah1 = Math.Round((Math.Pow(10, 6)) / (60 * n_z1) * L10_1);
                }
            }
            if (d == 35 && C1 == 15900)
            {
                if (L10_ah1 > Lh_potr)
                {
                    L10_1 = Math.Round(a1_1 * a23 * (Math.Pow(C1 / P_r1, P)), 1);
                    L10_ah1 = Math.Round((Math.Pow(10, 6)) / (60 * n_z1) * L10_1);
                }
            }
            if (d == 35 && C1 == 33200)
            {
                if (L10_ah1 > Lh_potr)
                {
                    L10_1 = Math.Round(a1_1 * a23 * (Math.Pow(C1 / P_r1, P)), 1);
                    L10_ah1 = Math.Round((Math.Pow(10, 6)) / (60 * n_z1) * L10_1);
                }
            }
            if (d5 == 35 && C2 == 15900)
            {
                if (L10_ah2 > Lh_potr)
                {
                    L10_2 = Math.Round(a1_1 * a23 * (Math.Pow(C2 / P_r2, P)), 1);
                    L10_ah2 = Math.Round((((Math.Pow(10, 6)) / (60 * n_z2)) * L10_2));
                }
            }
            if (d5 == 35 && C2 == 25500)
            {
                if (L10_ah2 > Lh_potr)
                {
                    L10_2 = Math.Round(a1_1 * a23 * (Math.Pow(C2 / P_r2, P)), 1);
                    L10_ah2 = Math.Round((((Math.Pow(10, 6)) / (60 * n_z2)) * L10_2));
                }
            }
            if (d5 == 35 && C2 == 33200)
            {
                if (L10_ah2 > Lh_potr)
                {
                    L10_2 = Math.Round(a1_1 * a23 * (Math.Pow(C2 / P_r2, P)), 1);
                    L10_ah2 = Math.Round((((Math.Pow(10, 6)) / (60 * n_z2)) * L10_2));
                }
            }
            P_r1 = Math.Round(R_a1 * V_c * K_b * K_t, 1);
            L10_1 = Math.Round(a1_1 * a23 * (Math.Pow(C2 / P_r1, P)), 1);
            L10_ah1 = Math.Round((((Math.Pow(10, 6)) / (60 * n_z1)) * L10_1));
            if (L10_ah1 > Lh_potr)
            {
                result1 = "Все правильно." + "\n" + "L10_ah1:" + L10_ah1 + ">" + Lh_potr;
            }
            else
            {
                result1 = "Все посчитано неверно!";
            }
            P_r2 = Math.Round(R_a2 * V_c * K_b * K_t, 1);
            L10_2 = Math.Round(a1_1 * a23 * (Math.Pow(C1 / P_r2, P)), 1);
            L10_ah2 = Math.Round((((Math.Pow(10, 6)) / (60 * n_z2)) * L10_2));
            if (L10_ah2 > Lh_potr)
            {
                result2 = "Все правильно." + "\n" + "L10_ah2:" + L10_ah2 + ">" + Lh_potr;
            }
            else
            {
                result2 = "Все посчитано неверно!";
            }
            //**Вывод**//
            label187.Text = "P_r1 =  " + P_r1;
            label186.Text = "L10_1 =  " + L10_1;
            label185.Text = "L10_ah1 =  " + L10_ah1;
            label184.Text = "Результат =   " + result1;
            label178.Text = "P_r2 =  " + P_r2;
            label177.Text = "L10_2 =  " + L10_2;
            label176.Text = "L10_ah2 =  " + L10_ah2;
            label175.Text = "Результат =   " + result2;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            C1 = double.Parse(textBox23.Text.ToString());
            C2 = double.Parse(textBox22.Text.ToString());
            Calculation4();
        }
    }

}











////Цилиндрическая передача
//               case V>=15:
//               accuracy = '5A' . ' ' . 'для цилиндрической передачи';
//               break;
//               case V<15:
//               accuracy = '6A' . ' ' . 'для цилиндрической передачи';
//               break;
//               case V<10:
//               accuracy = '7A' . ' ' . 'для цилиндрической передачи';
//               break;
//               case V<6:
//               accuracy = '8A' . ' ' . 'для цилиндрической передачи';
//               break;
//               case V<2:
//               accuracy = '9A' . ' ' . 'для цилиндрической передачи';
//               break;*/
