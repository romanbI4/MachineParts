using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        //float _T, _n, _nu_sinh, _U, _n_rem_per, _n_pod, _n_zub;
        //float _Tvuh, _Tpotr, _nu_obsh, _Upriv, _Ured, _U1_2, _P_z1, _P_z2, _P_vuh, _n_z1, _n_z2, _n_vuh, _T_z1, _T_z2, _T_vuh,
        //    _P_sh1, _P_sh2, _n_sh1, _n_sh2, _T_sh1, _T_sh2;
        //float _N_vhod, _power;
        //string _select;//Из списка вытягиваем выбранное значение
        public float T, n, nu_sinh, U,
               n_rem_per, n_pod, n_zub;
        public float Tvuh, Tpotr, nu_obsh, Upriv, Ured, U1_2, P_z1, P_z2, P_vuh, n_z1, n_z2, n_vuh, T_z1, T_z2, T_vuh,
           P_sh1, P_sh2, n_sh1, n_sh2, T_sh1, T_sh2;
        public float N_vhod, power;
        public string select;//Из списка вытягиваем выбранное значение

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
            float T = (float.Parse(textBox1.Text)), n = (float.Parse(textBox2.Text)), nu_sinh = (float.Parse(textBox3.Text)), U = (float.Parse(textBox4.Text)),
                n_rem_per = (float.Parse(textBox5.Text)), n_pod = (float.Parse(textBox6.Text)), n_zub = (float.Parse(textBox7.Text));
            float N_vhod = float.Parse(comboBox2.SelectedItem.ToString()), power = float.Parse(comboBox1.SelectedItem.ToString());
            string select = comboBox3.SelectedItem.ToString();//Из списка вытягиваем выбранное значение
            Calculation();

        }

        //public void Calculation1()
        //{
        //    /*----------------Считывание ввода-----------*/
        //    float Kap = 9750;
        //    int t1, t2, t3;
        //    float P1, P2, P3;
        //    string metal_for_gear = comboBox9.SelectedItem.ToString(), metal_for_wheel = comboBox8.SelectedItem.ToString();
        //    float k_width = float.Parse(comboBox9.SelectedItem.ToString());
        //    float Kh_alpha, Kh_betta, Kh_v;
        //    int H1, H2;
        //    double k;
        //    switch (metal_for_gear) {
        //        case metal_for_gear == '40Х, 45, 40ХН':
        //            H1 = 280;
        //            break;
        //        case metal_for_gear == '40Х, 40ХН, 35ХМ':
        //            H1 = 53;
        //            break;
        //        case metal_for_gear == '40Х, 40ХН, 35ХМ':
        //            H1 = 52;
        //            break;
        //        case metal_for_gear == '20Х, 20ХНМ':
        //            H1 = 60;
        //            break;
        //        case metal_for_gear == '20Х, 20ХНМ':
        //            H1 = 61;
        //            break;
        //    }
        //    switch (metal_for_wheel) {
        //        case metal_for_gear == '40Х, 45, 40ХН':
        //            H2 = 250;
        //            break;
        //        case metal_for_gear == '40Х, 40ХН, 35ХМ':
        //            H2 = 280;
        //            break;
        //        case metal_for_gear == '40Х, 40ХН, 35ХМ':
        //            H2 = 52;
        //            break;
        //        case metal_for_gear == '20Х, 20ХНМ':
        //            H2 = 53;
        //            break;
        //        case metal_for_gear == '20Х, 20ХНМ':
        //            H2 = 60;
        //            break;
        //    }
        //    switch (k_width) {
        //        case k_width == '0,1':
        //            k = 0.1;
        //            break;
        //        case k_width == '0,125':
        //            k = 0.125;
        //            break;
        //        case k_width == '0,16':
        //            k = 0.16;
        //            break;
        //        case k_width == '0,2':
        //            k = 0.2;
        //            break;
        //        case k_width == '0,25':
        //            k = 0.25;
        //            break;
        //        case k_width == '0,315':
        //            k = 0.315;
        //            break;
        //        case k_width == '0,4':
        //            k = 0.4;
        //            break;
        //        case k_width == '0,5':
        //            k = 0.5;
        //            break;
        //        case k_width == '0,630':
        //            k = 0.630;
        //            break;
        //        case k_width == '0,8':
        //            k = 0.8;
        //            break;
        //        case k_width == '1':
        //            k = 1;
        //            break;
        //        case k_width == '1,25':
        //            k = 1.25;
        //            break;
        //    }
        //    /*---------------------------------------*/
        //    /*----------------Вычисление 2.1)-------------*/
        //    /*Для шестрени */
        //    σn_limb = 2 * H1 + 70;
        //    Nh_o1 = round(30 * pow(σn_limb, 2.4));
        //    Nh_e1 = round(60 * n_z1 * (t1 * pow(P1, 3) + t2 * pow(P2, 3) + t3 * pow(P3, 3)));
        //    Kh_l = round(pow(Nh_o1 / Nh_e1, 1 / 6), 2);
        //    if (Kh_l >= 1) {
        //        Kh_l = Kh_l;
        //    }
        //    else Kh_l = 1;
        //    σ_H1 = round(((σn_limb / 1.1) * Kh_l));
        //    /*Для колеса */
        //    σn_limb2 = 2 * H2 + 70;
        //    Nh_o12 = round(30 * pow(σn_limb2, 2.4));
        //    Nh_e12 = round(Nh_e1 / U1_2);
        //    Kh_l2 = round(pow(Nh_o12 / Nh_e12, 1 / 6), 2);
        //    if (Kh_l2 >= 1) {
        //        Kh_l2 = Kh_l2; ;
        //    }
        //    else Kh_l2 = 1;
        //    σ_H12 = round(((σn_limb2 / 1.1) * Kh_l2));
        //    min = min(σ_H1, σ_H12);
        //    /******************************************/
        //    /*----------------Вычисление 2.2)-------------*/
        //    Kh = round(Kh_alpha * Kh_betta * Kh_v, 4);
        //    /*----------------Вычисление 2.3)-------------*/
        //    part2 = (P_z1 * Kh_betta * Kh_v * Kh_alpha) / (k * n_z1 * U1_2 * pow(min, 2));
        //    a = Kap * (U1_2 + 1) * (round((pow(part2, 1 / 3)), 3));
        //    if (a < a1) {
        //        a = a1;
        //    }
        //    /*----------------Вычисление 2.4)-------------*/
        //    m = 0.01 * a;
        //    switch (m) {
        //        case (m >= 1 && m < 1.25):
        //            m = 1.25;
        //            break;
        //        case (m >= 1.125 && m < 1.375):
        //            m = 1.3125;
        //            break;
        //        case (m >= 1.375 && m < 1.5):
        //            m = 1.507;
        //            break;
        //        case (m >= 1.5 && m < 1.75):
        //            m = 1.625;
        //            break;
        //    }
        //    z1_sum_z2 = (2 * a) / m;
        //    /*----------------Вычисление 2.5)-------------*/
        //    z1 = round(z1_sum_z2 / (U1_2 + 1));
        //    z2 = round(z1_sum_z2 - z1);
        //    U1_2f = round((z2 / z1), 2);
        //    delta_U = round((abs((U1_2 - U1_2f) / (U1_2)) * 100), 2);
        //    /*----------------Вычисление 2.6)-------------*/
        //    b = b2 = ceil(k * a);
        //    /*----------------Вычисление 2.7)-------------*/
        //    d1 = round(m * z1, 2);
        //    d2 = round(m * z2, 2);
        //    d_a1 = round(d1 + 2 * m, 2);
        //    d_a2 = round(d2 + 2 * m, 2);
        //    d_f1 = round(d1 - 2.5 * m, 2);
        //    d_f2 = round(d2 - 2.5 * m, 2);
        //    verify = (d1 / 2) + (d2 / 2);
        //    /*----------------Вычисление 2.8)-------------*/
        //    V = round((M_PI * d1 * n_z1) / 60000, 2);
        //    /*----------------Определение точности)-------------*/
        //    switch (V) {
        //        /*//Цилиндрическая передача
        //        case V>=15:
        //        accuracy = '5A' . ' ' . 'для цилиндрической передачи';
        //        break;
        //        case V<15:
        //        accuracy = '6A' . ' ' . 'для цилиндрической передачи';
        //        break;
        //        case V<10:
        //        accuracy = '7A' . ' ' . 'для цилиндрической передачи';
        //        break;
        //        case V<6:
        //        accuracy = '8A' . ' ' . 'для цилиндрической передачи';
        //        break;
        //        case V<2:
        //        accuracy = '9A' . ' ' . 'для цилиндрической передачи';
        //        break;*/
        //        //Коническая передача
        //        case (V < 1.5) && (V < 2):
        //            accuracy = '9'. ' '. ' для конической передачи';
        //            break;
        //        case (V < 4) && (V < 6):
        //            accuracy = '8'. ' '. ' для конической передачи';
        //            break;
        //        case (V < 8) && (V < 10):
        //            accuracy = '7'. ' '. ' для конической передачи';
        //            break;
        //        case V <= (12) && (V < 15):
        //            accuracy = '6'. ' '. ' для конической передачи';
        //            break;
        //        case (V >= 12) && (V >= 15):
        //            accuracy = '5'. ' '. 'для конической передачи';
        //            break;
        //    }
        //}

        private void Расчет1_Click(object sender, EventArgs e)
        {
            //Calculation();
        }

    }
}












//public float T
//{
//    get { return _T; }
//    set { _T = (float.Parse(textBox1.Text)); }
//}

//public float n
//{
//    get { return _n; }
//    set { _n = (float.Parse(textBox2.Text)); }
//}

//public float nu_sinh
//{
//    get { return _nu_sinh; }
//    set { _nu_sinh = (float.Parse(textBox3.Text)); }
//}

//public float U
//{
//    get { return _U; }
//    set { _U = (float.Parse(textBox4.Text)); }
//}

//public float n_rem_per
//{
//    get { return _n_rem_per; }
//    set { _n_rem_per = (float.Parse(textBox5.Text)); }
//}

//public float n_pod
//{
//    get { return _n_pod; }
//    set { _n_pod = (float.Parse(textBox6.Text)); }
//}

//public float n_zub
//{
//    get { return _n_zub; }
//    set { _n_zub = (float.Parse(textBox7.Text)); }
//}

//public float Tvuh
//{
//    get { return _Tvuh; }
//    set { _Tvuh = value; }
//}

//public float Tpotr
//{
//    get { return _Tpotr; }
//    set { _Tpotr = value; }
//}

//public float nu_obsh
//{
//    get { return _nu_obsh; }
//    set { _nu_obsh = value; }
//}

//public float Upriv
//{
//    get { return _Upriv; }
//    set { _Upriv = value; }
//}

//public float Ured
//{
//    get { return _Ured; }
//    set { _Ured = value; }
//}

//public float U1_2
//{
//    get { return _U1_2; }
//    set { _U1_2 = value; }
//}

//public float P_z1
//{
//    get { return _P_z1; }
//    set { _P_z1 = value; }
//}

//public float P_z2
//{
//    get { return _P_z2; }
//    set { _P_z2 = value; }
//}

//public float P_vuh
//{
//    get { return _P_vuh; }
//    set { _P_vuh = value; }
//}

//public float n_z1
//{
//    get { return _n_z1; }
//    set { _n_z1 = value; }
//}

//public float n_z2
//{
//    get { return _n_z2; }
//    set { _n_z2 = value; }
//}

//public float n_vuh
//{
//    get { return _n_vuh; }
//    set { _n_vuh = value; }
//}

//public float T_z1
//{
//    get { return _T_z1; }
//    set { _T_z1 = value; }
//}

//public float T_z2
//{
//    get { return _T_z2; }
//    set { _T_z2 = value; }
//}

//public float T_vuh
//{
//    get { return _T_vuh; }
//    set { _T_vuh = value; }
//}

//public float P_sh1
//{
//    get { return _P_sh1; }
//    set { _P_sh1 = value; }
//}

//public float P_sh2
//{
//    get { return _P_sh2; }
//    set { _P_sh2 = value; }
//}

//public float n_sh1
//{
//    get { return _n_sh1; }
//    set { _n_sh1 = value; }
//}

//public float n_sh2
//{
//    get { return _n_sh2; }
//    set { _n_sh2 = value; }
//}

//public float T_sh1
//{
//    get { return _T_sh1; }
//    set { _T_sh1 = value; }
//}

//public float T_sh2
//{
//    get { return _T_sh2; }
//    set { _T_sh2 = value; }
//}

//public float N_vhod
//{
//    get { return _N_vhod; }
//    set { _N_vhod = float.Parse(comboBox2.SelectedItem.ToString()); }
//}

//public float power
//{
//    get { return _power; }
//    set { _power = float.Parse(comboBox1.SelectedItem.ToString()); }
//}

//public string select
//{
//    get { return _select; }
//    set { _select = comboBox3.SelectedItem.ToString(); }
//}