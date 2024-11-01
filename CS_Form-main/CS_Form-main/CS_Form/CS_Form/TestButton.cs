﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace CS_Form
{
    class TestButton : Button
    {

        /// <summary>
        /// コンストラクタ
        
        /// クラスを生成したときに呼び出される
        /// </summary>
        public TestButton(int x , int y, int width,int height,int id)
        {
            // ClickイベントにOnClick関数を登録
            // ボタンをクリックした時に登録した関数を実行します。
            Click += OnClick;

            Text = id.ToString();

            Location = new System.Drawing.Point(x, y);

            Size = new System.Drawing.Size(width,height);
        }

        /// <summary>
        /// ボタンをクリックした際の処理を記述する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(Text);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
