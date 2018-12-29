﻿/*
 * Copyright (C) 1994-2018 Microstar Electric Company Limited
 * 
 * All Rights Reserved.
 * 
 * LEGAL NOTICE: All information contained herein is, and 
 * remains the property of Microstar Electric Company Limited. 
 * The intellectual and technical concepts contained herein 
 * are proprietary to Microstar Electric Company Limited, and 
 * may be covered by patents, patents in process and are 
 * protected by the trade secret or copyright laws. Commercial 
 * use, or disclosure, or dissemination, or reproduction of 
 * the information contained in this file are strictly 
 * forbidden unless official specific written permissions are 
 * obtained from Microstar Electric Company Limited.
 */
using System.Windows.Forms;

namespace Microstar.Production.View
{
    /// <summary>
    /// 用户修改对话框
    /// </summary>
    public partial class UserEditDialog : Form
    {
        /// <summary>
        /// 初始化用户修改对话框上的控件
        /// </summary>
        public UserEditDialog()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
