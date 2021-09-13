
namespace ToyShop
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.checkBoxDoll = new System.Windows.Forms.CheckBox();
            this.checkBoxTeddy = new System.Windows.Forms.CheckBox();
            this.checkBoxBall = new System.Windows.Forms.CheckBox();
            this.groupBoxToys = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxLego = new System.Windows.Forms.CheckBox();
            this.groupBoxPrices = new System.Windows.Forms.GroupBox();
            this.lblPriceLego = new System.Windows.Forms.Label();
            this.lblPriceBalls = new System.Windows.Forms.Label();
            this.lblPriceTeddy = new System.Windows.Forms.Label();
            this.lblPriceBarbie = new System.Windows.Forms.Label();
            this.groupBoxAmount = new System.Windows.Forms.GroupBox();
            this.txtBoxBall = new System.Windows.Forms.TextBox();
            this.txtBoxLego = new System.Windows.Forms.TextBox();
            this.txtBoxTeddy = new System.Windows.Forms.TextBox();
            this.txtBoxBarbie = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblFlat = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxHouse = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxBuilding = new System.Windows.Forms.TextBox();
            this.txtBoxFlat = new System.Windows.Forms.TextBox();
            this.comboBoxPaying = new System.Windows.Forms.ComboBox();
            this.lblPaying = new System.Windows.Forms.Label();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.dateTimePickerPickup = new System.Windows.Forms.DateTimePicker();
            this.radioBtnDelivery = new System.Windows.Forms.RadioButton();
            this.radioBtnPickup = new System.Windows.Forms.RadioButton();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnOrderHelp = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxToys.SuspendLayout();
            this.groupBoxPrices.SuspendLayout();
            this.groupBoxAmount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseOrder.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCloseOrder.Location = new System.Drawing.Point(254, 406);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(110, 33);
            this.btnCloseOrder.TabIndex = 0;
            this.btnCloseOrder.Text = "Закрыть";
            this.btnCloseOrder.UseVisualStyleBackColor = false;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnExitOrder_Click);
            // 
            // checkBoxDoll
            // 
            this.checkBoxDoll.AutoSize = true;
            this.checkBoxDoll.Location = new System.Drawing.Point(6, 21);
            this.checkBoxDoll.Name = "checkBoxDoll";
            this.checkBoxDoll.Size = new System.Drawing.Size(100, 17);
            this.checkBoxDoll.TabIndex = 1;
            this.checkBoxDoll.Text = "Кукла \"Барби\"";
            this.checkBoxDoll.UseVisualStyleBackColor = true;
            this.checkBoxDoll.CheckedChanged += new System.EventHandler(this.checkBoxDoll_CheckedChanged);
            // 
            // checkBoxTeddy
            // 
            this.checkBoxTeddy.AutoSize = true;
            this.checkBoxTeddy.Location = new System.Drawing.Point(6, 47);
            this.checkBoxTeddy.Name = "checkBoxTeddy";
            this.checkBoxTeddy.Size = new System.Drawing.Size(129, 17);
            this.checkBoxTeddy.TabIndex = 2;
            this.checkBoxTeddy.Text = "Плюшевый медведь";
            this.checkBoxTeddy.UseVisualStyleBackColor = true;
            this.checkBoxTeddy.CheckedChanged += new System.EventHandler(this.checkBoxTeddy_CheckedChanged);
            // 
            // checkBoxBall
            // 
            this.checkBoxBall.AutoSize = true;
            this.checkBoxBall.Location = new System.Drawing.Point(6, 70);
            this.checkBoxBall.Name = "checkBoxBall";
            this.checkBoxBall.Size = new System.Drawing.Size(113, 17);
            this.checkBoxBall.TabIndex = 4;
            this.checkBoxBall.Text = "Футбольный мяч";
            this.checkBoxBall.UseVisualStyleBackColor = true;
            this.checkBoxBall.CheckedChanged += new System.EventHandler(this.checkBoxBall_CheckedChanged);
            // 
            // groupBoxToys
            // 
            this.groupBoxToys.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxToys.Controls.Add(this.panel1);
            this.groupBoxToys.Controls.Add(this.checkBoxDoll);
            this.groupBoxToys.Controls.Add(this.checkBoxLego);
            this.groupBoxToys.Controls.Add(this.checkBoxTeddy);
            this.groupBoxToys.Controls.Add(this.checkBoxBall);
            this.groupBoxToys.Location = new System.Drawing.Point(12, 12);
            this.groupBoxToys.Name = "groupBoxToys";
            this.groupBoxToys.Size = new System.Drawing.Size(147, 128);
            this.groupBoxToys.TabIndex = 6;
            this.groupBoxToys.TabStop = false;
            this.groupBoxToys.Text = "Игрушки";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 34);
            this.panel1.TabIndex = 6;
            // 
            // checkBoxLego
            // 
            this.checkBoxLego.AutoSize = true;
            this.checkBoxLego.Location = new System.Drawing.Point(6, 93);
            this.checkBoxLego.Name = "checkBoxLego";
            this.checkBoxLego.Size = new System.Drawing.Size(127, 17);
            this.checkBoxLego.TabIndex = 5;
            this.checkBoxLego.Text = "Конструктор \"Lego\"";
            this.checkBoxLego.UseVisualStyleBackColor = true;
            this.checkBoxLego.CheckedChanged += new System.EventHandler(this.checkBoxLego_CheckedChanged);
            // 
            // groupBoxPrices
            // 
            this.groupBoxPrices.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxPrices.Controls.Add(this.lblPriceLego);
            this.groupBoxPrices.Controls.Add(this.lblPriceBalls);
            this.groupBoxPrices.Controls.Add(this.lblPriceTeddy);
            this.groupBoxPrices.Controls.Add(this.lblPriceBarbie);
            this.groupBoxPrices.Location = new System.Drawing.Point(166, 13);
            this.groupBoxPrices.Name = "groupBoxPrices";
            this.groupBoxPrices.Size = new System.Drawing.Size(88, 127);
            this.groupBoxPrices.TabIndex = 7;
            this.groupBoxPrices.TabStop = false;
            this.groupBoxPrices.Text = "Цены";
            // 
            // lblPriceLego
            // 
            this.lblPriceLego.AutoSize = true;
            this.lblPriceLego.Location = new System.Drawing.Point(6, 93);
            this.lblPriceLego.Name = "lblPriceLego";
            this.lblPriceLego.Size = new System.Drawing.Size(48, 13);
            this.lblPriceLego.TabIndex = 4;
            this.lblPriceLego.Text = "449 руб.";
            // 
            // lblPriceBalls
            // 
            this.lblPriceBalls.AutoSize = true;
            this.lblPriceBalls.Location = new System.Drawing.Point(6, 70);
            this.lblPriceBalls.Name = "lblPriceBalls";
            this.lblPriceBalls.Size = new System.Drawing.Size(42, 13);
            this.lblPriceBalls.TabIndex = 3;
            this.lblPriceBalls.Text = "99 руб.";
            // 
            // lblPriceTeddy
            // 
            this.lblPriceTeddy.AutoSize = true;
            this.lblPriceTeddy.Location = new System.Drawing.Point(6, 47);
            this.lblPriceTeddy.Name = "lblPriceTeddy";
            this.lblPriceTeddy.Size = new System.Drawing.Size(48, 13);
            this.lblPriceTeddy.TabIndex = 1;
            this.lblPriceTeddy.Text = "999 руб.";
            // 
            // lblPriceBarbie
            // 
            this.lblPriceBarbie.AutoSize = true;
            this.lblPriceBarbie.Location = new System.Drawing.Point(7, 24);
            this.lblPriceBarbie.Name = "lblPriceBarbie";
            this.lblPriceBarbie.Size = new System.Drawing.Size(48, 13);
            this.lblPriceBarbie.TabIndex = 0;
            this.lblPriceBarbie.Text = "149 руб.";
            // 
            // groupBoxAmount
            // 
            this.groupBoxAmount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxAmount.Controls.Add(this.txtBoxBall);
            this.groupBoxAmount.Controls.Add(this.txtBoxLego);
            this.groupBoxAmount.Controls.Add(this.txtBoxTeddy);
            this.groupBoxAmount.Controls.Add(this.txtBoxBarbie);
            this.groupBoxAmount.Location = new System.Drawing.Point(261, 13);
            this.groupBoxAmount.Name = "groupBoxAmount";
            this.groupBoxAmount.Size = new System.Drawing.Size(103, 127);
            this.groupBoxAmount.TabIndex = 8;
            this.groupBoxAmount.TabStop = false;
            this.groupBoxAmount.Text = "Количество";
            // 
            // txtBoxBall
            // 
            this.txtBoxBall.Location = new System.Drawing.Point(6, 70);
            this.txtBoxBall.Name = "txtBoxBall";
            this.txtBoxBall.Size = new System.Drawing.Size(90, 20);
            this.txtBoxBall.TabIndex = 4;
            // 
            // txtBoxLego
            // 
            this.txtBoxLego.Location = new System.Drawing.Point(6, 96);
            this.txtBoxLego.Name = "txtBoxLego";
            this.txtBoxLego.Size = new System.Drawing.Size(90, 20);
            this.txtBoxLego.TabIndex = 3;
            // 
            // txtBoxTeddy
            // 
            this.txtBoxTeddy.Location = new System.Drawing.Point(6, 44);
            this.txtBoxTeddy.Name = "txtBoxTeddy";
            this.txtBoxTeddy.Size = new System.Drawing.Size(91, 20);
            this.txtBoxTeddy.TabIndex = 1;
            // 
            // txtBoxBarbie
            // 
            this.txtBoxBarbie.Location = new System.Drawing.Point(6, 18);
            this.txtBoxBarbie.Name = "txtBoxBarbie";
            this.txtBoxBarbie.Size = new System.Drawing.Size(90, 20);
            this.txtBoxBarbie.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Имя";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(18, 159);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 11;
            this.txtBoxName.Text = "Анна";
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(137, 143);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(93, 13);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Номер телефона";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(10, 1);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(39, 13);
            this.lblStreet.TabIndex = 13;
            this.lblStreet.Text = "Улица";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(10, 40);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(30, 13);
            this.lblHouse.TabIndex = 14;
            this.lblHouse.Text = "Дом";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Location = new System.Drawing.Point(210, 1);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(91, 13);
            this.lblBuilding.TabIndex = 15;
            this.lblBuilding.Text = "Корпус/подъезд";
            // 
            // lblFlat
            // 
            this.lblFlat.AutoSize = true;
            this.lblFlat.Location = new System.Drawing.Point(210, 40);
            this.lblFlat.Name = "lblFlat";
            this.lblFlat.Size = new System.Drawing.Size(55, 13);
            this.lblFlat.TabIndex = 16;
            this.lblFlat.Text = "Квартира";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(140, 160);
            this.txtBoxPhone.MaxLength = 11;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(108, 20);
            this.txtBoxPhone.TabIndex = 17;
            this.txtBoxPhone.Text = "9184443322";
            this.txtBoxPhone.TextChanged += new System.EventHandler(this.txtBoxPhone_TextChanged);
            // 
            // txtBoxHouse
            // 
            this.txtBoxHouse.Location = new System.Drawing.Point(13, 56);
            this.txtBoxHouse.Name = "txtBoxHouse";
            this.txtBoxHouse.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHouse.TabIndex = 18;
            this.txtBoxHouse.TextChanged += new System.EventHandler(this.txtBoxHouse_TextChanged);
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(13, 17);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStreet.TabIndex = 19;
            this.txtBoxStreet.TextChanged += new System.EventHandler(this.txtBoxStreet_TextChanged);
            // 
            // txtBoxBuilding
            // 
            this.txtBoxBuilding.Location = new System.Drawing.Point(213, 17);
            this.txtBoxBuilding.Name = "txtBoxBuilding";
            this.txtBoxBuilding.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBuilding.TabIndex = 20;
            this.txtBoxBuilding.TextChanged += new System.EventHandler(this.txtBoxBuilding_TextChanged);
            // 
            // txtBoxFlat
            // 
            this.txtBoxFlat.Location = new System.Drawing.Point(213, 56);
            this.txtBoxFlat.Name = "txtBoxFlat";
            this.txtBoxFlat.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFlat.TabIndex = 21;
            this.txtBoxFlat.TextChanged += new System.EventHandler(this.txtBoxFlat_TextChanged);
            // 
            // comboBoxPaying
            // 
            this.comboBoxPaying.FormattingEnabled = true;
            this.comboBoxPaying.Items.AddRange(new object[] {
            "Наличный расчёт",
            "Безналичный расчёт"});
            this.comboBoxPaying.Location = new System.Drawing.Point(261, 159);
            this.comboBoxPaying.Name = "comboBoxPaying";
            this.comboBoxPaying.Size = new System.Drawing.Size(103, 21);
            this.comboBoxPaying.TabIndex = 22;
            this.comboBoxPaying.Text = "Выберите";
            this.comboBoxPaying.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaying_SelectedIndexChanged);
            // 
            // lblPaying
            // 
            this.lblPaying.AutoSize = true;
            this.lblPaying.Location = new System.Drawing.Point(258, 143);
            this.lblPaying.Name = "lblPaying";
            this.lblPaying.Size = new System.Drawing.Size(47, 13);
            this.lblPaying.TabIndex = 23;
            this.lblPaying.Text = "Оплата:";
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetOrder.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnGetOrder.Location = new System.Drawing.Point(12, 406);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(110, 33);
            this.btnGetOrder.TabIndex = 24;
            this.btnGetOrder.Text = "Рассчитать заказ";
            this.btnGetOrder.UseVisualStyleBackColor = false;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // dateTimePickerPickup
            // 
            this.dateTimePickerPickup.Location = new System.Drawing.Point(5, 17);
            this.dateTimePickerPickup.Name = "dateTimePickerPickup";
            this.dateTimePickerPickup.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerPickup.TabIndex = 26;
            // 
            // radioBtnDelivery
            // 
            this.radioBtnDelivery.AutoSize = true;
            this.radioBtnDelivery.Location = new System.Drawing.Point(18, 185);
            this.radioBtnDelivery.Name = "radioBtnDelivery";
            this.radioBtnDelivery.Size = new System.Drawing.Size(75, 17);
            this.radioBtnDelivery.TabIndex = 27;
            this.radioBtnDelivery.TabStop = true;
            this.radioBtnDelivery.Text = "Доставка";
            this.radioBtnDelivery.UseVisualStyleBackColor = true;
            this.radioBtnDelivery.CheckedChanged += new System.EventHandler(this.radioBtnDelivery_CheckedChanged);
            // 
            // radioBtnPickup
            // 
            this.radioBtnPickup.AutoSize = true;
            this.radioBtnPickup.Location = new System.Drawing.Point(18, 286);
            this.radioBtnPickup.Name = "radioBtnPickup";
            this.radioBtnPickup.Size = new System.Drawing.Size(84, 17);
            this.radioBtnPickup.TabIndex = 28;
            this.radioBtnPickup.TabStop = true;
            this.radioBtnPickup.Text = "Самовывоз";
            this.radioBtnPickup.UseVisualStyleBackColor = true;
            this.radioBtnPickup.CheckedChanged += new System.EventHandler(this.radioBtnPickup_CheckedChanged);
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Items.AddRange(new object[] {
            "ул. Постовая, 21",
            "ул. Гаврилова, 144",
            "ул. Круговая, 84"});
            this.comboBoxAddress.Location = new System.Drawing.Point(162, 16);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(181, 21);
            this.comboBoxAddress.TabIndex = 29;
            this.comboBoxAddress.Text = "Выберите";
            this.comboBoxAddress.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddress_SelectedIndexChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(160, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(145, 13);
            this.lblAddress.TabIndex = 32;
            this.lblAddress.Text = "Выберите адрес магазина:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(215, 367);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 13);
            this.lblResult.TabIndex = 33;
            this.lblResult.Text = "Результат:";
            // 
            // btnOrderHelp
            // 
            this.btnOrderHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderHelp.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnOrderHelp.Location = new System.Drawing.Point(128, 406);
            this.btnOrderHelp.Name = "btnOrderHelp";
            this.btnOrderHelp.Size = new System.Drawing.Size(120, 33);
            this.btnOrderHelp.TabIndex = 34;
            this.btnOrderHelp.Text = "Справка";
            this.btnOrderHelp.UseVisualStyleBackColor = false;
            this.btnOrderHelp.Click += new System.EventHandler(this.btnOrderHelp_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(15, 367);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(153, 26);
            this.lblInfo.TabIndex = 35;
            this.lblInfo.Text = "Перед оформлением заказа\r\n ознакомьтесь со справкой!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.txtBoxFlat);
            this.panel2.Controls.Add(this.txtBoxBuilding);
            this.panel2.Controls.Add(this.txtBoxStreet);
            this.panel2.Controls.Add(this.txtBoxHouse);
            this.panel2.Controls.Add(this.lblFlat);
            this.panel2.Controls.Add(this.lblBuilding);
            this.panel2.Controls.Add(this.lblHouse);
            this.panel2.Controls.Add(this.lblStreet);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 82);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.lblAddress);
            this.panel3.Controls.Add(this.comboBoxAddress);
            this.panel3.Controls.Add(this.dateTimePickerPickup);
            this.panel3.Location = new System.Drawing.Point(13, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 49);
            this.panel3.TabIndex = 37;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 451);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnOrderHelp);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.radioBtnPickup);
            this.Controls.Add(this.radioBtnDelivery);
            this.Controls.Add(this.btnGetOrder);
            this.Controls.Add(this.lblPaying);
            this.Controls.Add(this.comboBoxPaying);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBoxAmount);
            this.Controls.Add(this.groupBoxPrices);
            this.Controls.Add(this.groupBoxToys);
            this.Controls.Add(this.btnCloseOrder);
            this.Name = "FormOrder";
            this.ShowIcon = false;
            this.Text = "Заказ";
            this.groupBoxToys.ResumeLayout(false);
            this.groupBoxToys.PerformLayout();
            this.groupBoxPrices.ResumeLayout(false);
            this.groupBoxPrices.PerformLayout();
            this.groupBoxAmount.ResumeLayout(false);
            this.groupBoxAmount.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseOrder;
        private System.Windows.Forms.CheckBox checkBoxDoll;
        private System.Windows.Forms.CheckBox checkBoxTeddy;
        private System.Windows.Forms.CheckBox checkBoxBall;
        private System.Windows.Forms.GroupBox groupBoxToys;
        private System.Windows.Forms.GroupBox groupBoxPrices;
        private System.Windows.Forms.Label lblPriceLego;
        private System.Windows.Forms.Label lblPriceBalls;
        private System.Windows.Forms.Label lblPriceTeddy;
        private System.Windows.Forms.Label lblPriceBarbie;
        private System.Windows.Forms.GroupBox groupBoxAmount;
        private System.Windows.Forms.TextBox txtBoxBall;
        private System.Windows.Forms.TextBox txtBoxLego;
        private System.Windows.Forms.TextBox txtBoxTeddy;
        private System.Windows.Forms.TextBox txtBoxBarbie;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblFlat;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxHouse;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.TextBox txtBoxBuilding;
        private System.Windows.Forms.TextBox txtBoxFlat;
        private System.Windows.Forms.ComboBox comboBoxPaying;
        private System.Windows.Forms.Label lblPaying;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickup;
        private System.Windows.Forms.RadioButton radioBtnDelivery;
        private System.Windows.Forms.RadioButton radioBtnPickup;
        private System.Windows.Forms.CheckBox checkBoxLego;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnOrderHelp;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}