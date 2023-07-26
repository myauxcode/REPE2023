 //EJERCICIO 1

        public int ejercicio1(int n)
        {
            int nn, e, d;
            nn = 0;
            e = 0;
            while (n > 0)
            {
                d = n % 10;

                nn = nn + d * (int)(Math.Pow(10, e));

                e = e + 1;

                n = Elim_todos_num(n, d);
            }
            return nn;
        }
        public int Elim_todos_num(int n, int num)
        {
            int nd, d, nn, e;

            nd = CantDig(num);
            d = 0;
            nn = 0;
            e = 0;

            while (n > 0)
            {
                d = n % (int)(Math.Pow(10, nd));
                n = n / (int)(Math.Pow(10, nd));

                if (d != num)
                {
                    nn = nn + (d * (int)(Math.Pow(10, e)));
                    e = e + nd;
                }
            }

            return nn;
        }

        public int CantDig(int n)
        {
            int d, c;
            c = 0;

            while (n > 0)
            {
                d = n % 10;
                n = n / 10;

                c = c + 1;
            }
            return c;


        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat(ejercicio1(int.Parse(textBox1.Text)));
        }

        //EJERCICIO 2
        public string ejercicio2(string s)
        {

            string sr = "";
            string sr2 = "";
            s = s + ' ';
            for (int i = 1; i <= s.Length; i++)
            {
                if (s[i - 1] != ' ')
                {
                    sr = sr + s[i - 1];
                }
                else
                {
                    sr = sr + " ";
                    sr2 = sr + sr2;
                    sr = "";
                }


            }

            return sr2;

        }


        public string Inv(string s)
        {

            string sr = "";
            for (int i = 1; i <= s.Length; i++)
            {
                sr = s[i - 1] + sr;

            }

            return sr;

        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat(ejercicio2((textBox1.Text)));
        }
    }