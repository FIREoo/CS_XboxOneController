namespace CS_xboxControllerSource
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_readController = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_mouseEventMode = new System.Windows.Forms.CheckBox();
            this.textBox_Sensitivity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_linear = new System.Windows.Forms.CheckBox();
            this.checkBox_keyboardOn = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_keyboard = new System.Windows.Forms.PictureBox();
            this.pictureBox_ShowAddressBarButton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_ShowMenuButton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_RightTrigger_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_RightTrigger = new System.Windows.Forms.PictureBox();
            this.pictureBox_LeftTrigger_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_LeftTrigger = new System.Windows.Forms.PictureBox();
            this.pictureBox_controllerConnected = new System.Windows.Forms.PictureBox();
            this.pictureBox_RightShoulder_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_LeftShoulder_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_RightStick_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_LeftStick_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_RIGHTbutton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_LEFTbutton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_DOWNbutton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_UPbutton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_keyboard_Lpos = new System.Windows.Forms.PictureBox();
            this.pictureBox_keyboard_Rpos = new System.Windows.Forms.PictureBox();
            this.pictureBox_Axis2_pos = new System.Windows.Forms.PictureBox();
            this.pictureBox_Axis1_pos = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bbutton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_Abutton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ybutton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_Xbutton_press = new System.Windows.Forms.PictureBox();
            this.pictureBox_xboxController = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_keyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowAddressBarButton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowMenuButton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightTrigger_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightTrigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftTrigger_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftTrigger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_controllerConnected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightShoulder_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftShoulder_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightStick_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftStick_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RIGHTbutton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LEFTbutton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DOWNbutton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UPbutton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_keyboard_Lpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_keyboard_Rpos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Axis2_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Axis1_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bbutton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Abutton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ybutton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Xbutton_press)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_xboxController)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_readController
            // 
            this.timer_readController.Interval = 10;
            this.timer_readController.Tick += new System.EventHandler(this.timer_readController_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_mouseEventMode
            // 
            this.checkBox_mouseEventMode.AutoSize = true;
            this.checkBox_mouseEventMode.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_mouseEventMode.Location = new System.Drawing.Point(761, 67);
            this.checkBox_mouseEventMode.Name = "checkBox_mouseEventMode";
            this.checkBox_mouseEventMode.Size = new System.Drawing.Size(173, 24);
            this.checkBox_mouseEventMode.TabIndex = 13;
            this.checkBox_mouseEventMode.Text = "Mouse Event Mode";
            this.checkBox_mouseEventMode.UseVisualStyleBackColor = true;
            // 
            // textBox_Sensitivity
            // 
            this.textBox_Sensitivity.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox_Sensitivity.Location = new System.Drawing.Point(855, 93);
            this.textBox_Sensitivity.Name = "textBox_Sensitivity";
            this.textBox_Sensitivity.Size = new System.Drawing.Size(64, 29);
            this.textBox_Sensitivity.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label1.Location = new System.Drawing.Point(765, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sensitivity";
            // 
            // checkBox_linear
            // 
            this.checkBox_linear.AutoSize = true;
            this.checkBox_linear.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_linear.Location = new System.Drawing.Point(855, 125);
            this.checkBox_linear.Name = "checkBox_linear";
            this.checkBox_linear.Size = new System.Drawing.Size(64, 21);
            this.checkBox_linear.TabIndex = 16;
            this.checkBox_linear.Text = "Linear";
            this.checkBox_linear.UseVisualStyleBackColor = true;
            // 
            // checkBox_keyboardOn
            // 
            this.checkBox_keyboardOn.AutoSize = true;
            this.checkBox_keyboardOn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_keyboardOn.Location = new System.Drawing.Point(761, 185);
            this.checkBox_keyboardOn.Name = "checkBox_keyboardOn";
            this.checkBox_keyboardOn.Size = new System.Drawing.Size(127, 24);
            this.checkBox_keyboardOn.TabIndex = 13;
            this.checkBox_keyboardOn.Text = "Keyboard On";
            this.checkBox_keyboardOn.UseVisualStyleBackColor = true;
            this.checkBox_keyboardOn.CheckedChanged += new System.EventHandler(this.checkBox_keyboardOn_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(774, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(774, 395);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(813, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(789, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(835, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "button3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(813, 475);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "button3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(885, 453);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "label2";
            // 
            // pictureBox_keyboard
            // 
            this.pictureBox_keyboard.Image = global::CS_xboxControllerSource.Properties.Resources.keyboard2_en;
            this.pictureBox_keyboard.Location = new System.Drawing.Point(14, 510);
            this.pictureBox_keyboard.Name = "pictureBox_keyboard";
            this.pictureBox_keyboard.Size = new System.Drawing.Size(817, 259);
            this.pictureBox_keyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_keyboard.TabIndex = 17;
            this.pictureBox_keyboard.TabStop = false;
            // 
            // pictureBox_ShowAddressBarButton_press
            // 
            this.pictureBox_ShowAddressBarButton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_ShowAddressBarButton_press;
            this.pictureBox_ShowAddressBarButton_press.Location = new System.Drawing.Point(343, 153);
            this.pictureBox_ShowAddressBarButton_press.Name = "pictureBox_ShowAddressBarButton_press";
            this.pictureBox_ShowAddressBarButton_press.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_ShowAddressBarButton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_ShowAddressBarButton_press.TabIndex = 11;
            this.pictureBox_ShowAddressBarButton_press.TabStop = false;
            // 
            // pictureBox_ShowMenuButton_press
            // 
            this.pictureBox_ShowMenuButton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_ShowMenuButton_press;
            this.pictureBox_ShowMenuButton_press.Location = new System.Drawing.Point(384, 153);
            this.pictureBox_ShowMenuButton_press.Name = "pictureBox_ShowMenuButton_press";
            this.pictureBox_ShowMenuButton_press.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_ShowMenuButton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_ShowMenuButton_press.TabIndex = 11;
            this.pictureBox_ShowMenuButton_press.TabStop = false;
            // 
            // pictureBox_RightTrigger_press
            // 
            this.pictureBox_RightTrigger_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_RightTrigger3_press;
            this.pictureBox_RightTrigger_press.Location = new System.Drawing.Point(626, 9);
            this.pictureBox_RightTrigger_press.Name = "pictureBox_RightTrigger_press";
            this.pictureBox_RightTrigger_press.Size = new System.Drawing.Size(45, 36);
            this.pictureBox_RightTrigger_press.TabIndex = 10;
            this.pictureBox_RightTrigger_press.TabStop = false;
            // 
            // pictureBox_RightTrigger
            // 
            this.pictureBox_RightTrigger.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_RightTrigger3;
            this.pictureBox_RightTrigger.Location = new System.Drawing.Point(626, 9);
            this.pictureBox_RightTrigger.Name = "pictureBox_RightTrigger";
            this.pictureBox_RightTrigger.Size = new System.Drawing.Size(45, 67);
            this.pictureBox_RightTrigger.TabIndex = 10;
            this.pictureBox_RightTrigger.TabStop = false;
            // 
            // pictureBox_LeftTrigger_press
            // 
            this.pictureBox_LeftTrigger_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_LeftTrigger3_press;
            this.pictureBox_LeftTrigger_press.Location = new System.Drawing.Point(75, 9);
            this.pictureBox_LeftTrigger_press.Name = "pictureBox_LeftTrigger_press";
            this.pictureBox_LeftTrigger_press.Size = new System.Drawing.Size(45, 42);
            this.pictureBox_LeftTrigger_press.TabIndex = 10;
            this.pictureBox_LeftTrigger_press.TabStop = false;
            // 
            // pictureBox_LeftTrigger
            // 
            this.pictureBox_LeftTrigger.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_LeftTrigger3;
            this.pictureBox_LeftTrigger.Location = new System.Drawing.Point(75, 9);
            this.pictureBox_LeftTrigger.Name = "pictureBox_LeftTrigger";
            this.pictureBox_LeftTrigger.Size = new System.Drawing.Size(45, 67);
            this.pictureBox_LeftTrigger.TabIndex = 10;
            this.pictureBox_LeftTrigger.TabStop = false;
            // 
            // pictureBox_controllerConnected
            // 
            this.pictureBox_controllerConnected.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_connected;
            this.pictureBox_controllerConnected.Location = new System.Drawing.Point(343, 48);
            this.pictureBox_controllerConnected.Name = "pictureBox_controllerConnected";
            this.pictureBox_controllerConnected.Size = new System.Drawing.Size(67, 67);
            this.pictureBox_controllerConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_controllerConnected.TabIndex = 9;
            this.pictureBox_controllerConnected.TabStop = false;
            // 
            // pictureBox_RightShoulder_press
            // 
            this.pictureBox_RightShoulder_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_RightShoulder_press;
            this.pictureBox_RightShoulder_press.Location = new System.Drawing.Point(416, 48);
            this.pictureBox_RightShoulder_press.Name = "pictureBox_RightShoulder_press";
            this.pictureBox_RightShoulder_press.Size = new System.Drawing.Size(159, 60);
            this.pictureBox_RightShoulder_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_RightShoulder_press.TabIndex = 8;
            this.pictureBox_RightShoulder_press.TabStop = false;
            // 
            // pictureBox_LeftShoulder_press
            // 
            this.pictureBox_LeftShoulder_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_LeftShoulder_press;
            this.pictureBox_LeftShoulder_press.Location = new System.Drawing.Point(182, 48);
            this.pictureBox_LeftShoulder_press.Name = "pictureBox_LeftShoulder_press";
            this.pictureBox_LeftShoulder_press.Size = new System.Drawing.Size(155, 60);
            this.pictureBox_LeftShoulder_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_LeftShoulder_press.TabIndex = 8;
            this.pictureBox_LeftShoulder_press.TabStop = false;
            // 
            // pictureBox_RightStick_press
            // 
            this.pictureBox_RightStick_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_RightStick_press;
            this.pictureBox_RightStick_press.Location = new System.Drawing.Point(560, 239);
            this.pictureBox_RightStick_press.Name = "pictureBox_RightStick_press";
            this.pictureBox_RightStick_press.Size = new System.Drawing.Size(120, 120);
            this.pictureBox_RightStick_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_RightStick_press.TabIndex = 7;
            this.pictureBox_RightStick_press.TabStop = false;
            // 
            // pictureBox_LeftStick_press
            // 
            this.pictureBox_LeftStick_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_LeftStick_press;
            this.pictureBox_LeftStick_press.Location = new System.Drawing.Point(83, 218);
            this.pictureBox_LeftStick_press.Name = "pictureBox_LeftStick_press";
            this.pictureBox_LeftStick_press.Size = new System.Drawing.Size(116, 116);
            this.pictureBox_LeftStick_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_LeftStick_press.TabIndex = 7;
            this.pictureBox_LeftStick_press.TabStop = false;
            // 
            // pictureBox_RIGHTbutton_press
            // 
            this.pictureBox_RIGHTbutton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_RIGHTbutton_press;
            this.pictureBox_RIGHTbutton_press.Location = new System.Drawing.Point(308, 263);
            this.pictureBox_RIGHTbutton_press.Name = "pictureBox_RIGHTbutton_press";
            this.pictureBox_RIGHTbutton_press.Size = new System.Drawing.Size(28, 38);
            this.pictureBox_RIGHTbutton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_RIGHTbutton_press.TabIndex = 6;
            this.pictureBox_RIGHTbutton_press.TabStop = false;
            // 
            // pictureBox_LEFTbutton_press
            // 
            this.pictureBox_LEFTbutton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_LEFTbutton_press;
            this.pictureBox_LEFTbutton_press.Location = new System.Drawing.Point(228, 263);
            this.pictureBox_LEFTbutton_press.Name = "pictureBox_LEFTbutton_press";
            this.pictureBox_LEFTbutton_press.Size = new System.Drawing.Size(28, 36);
            this.pictureBox_LEFTbutton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_LEFTbutton_press.TabIndex = 6;
            this.pictureBox_LEFTbutton_press.TabStop = false;
            // 
            // pictureBox_DOWNbutton_press
            // 
            this.pictureBox_DOWNbutton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_DOWNbutton_press;
            this.pictureBox_DOWNbutton_press.Location = new System.Drawing.Point(263, 306);
            this.pictureBox_DOWNbutton_press.Name = "pictureBox_DOWNbutton_press";
            this.pictureBox_DOWNbutton_press.Size = new System.Drawing.Size(36, 28);
            this.pictureBox_DOWNbutton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_DOWNbutton_press.TabIndex = 6;
            this.pictureBox_DOWNbutton_press.TabStop = false;
            // 
            // pictureBox_UPbutton_press
            // 
            this.pictureBox_UPbutton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_UPbutton_press;
            this.pictureBox_UPbutton_press.Location = new System.Drawing.Point(263, 227);
            this.pictureBox_UPbutton_press.Name = "pictureBox_UPbutton_press";
            this.pictureBox_UPbutton_press.Size = new System.Drawing.Size(36, 28);
            this.pictureBox_UPbutton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_UPbutton_press.TabIndex = 6;
            this.pictureBox_UPbutton_press.TabStop = false;
            // 
            // pictureBox_keyboard_Lpos
            // 
            this.pictureBox_keyboard_Lpos.Image = global::CS_xboxControllerSource.Properties.Resources.crosshair_keyboard_red;
            this.pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(868, 673);
            this.pictureBox_keyboard_Lpos.Name = "pictureBox_keyboard_Lpos";
            this.pictureBox_keyboard_Lpos.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_keyboard_Lpos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_keyboard_Lpos.TabIndex = 5;
            this.pictureBox_keyboard_Lpos.TabStop = false;
            // 
            // pictureBox_keyboard_Rpos
            // 
            this.pictureBox_keyboard_Rpos.Image = global::CS_xboxControllerSource.Properties.Resources.crosshair_keyboard_red;
            this.pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(868, 633);
            this.pictureBox_keyboard_Rpos.Name = "pictureBox_keyboard_Rpos";
            this.pictureBox_keyboard_Rpos.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_keyboard_Rpos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_keyboard_Rpos.TabIndex = 5;
            this.pictureBox_keyboard_Rpos.TabStop = false;
            // 
            // pictureBox_Axis2_pos
            // 
            this.pictureBox_Axis2_pos.Image = global::CS_xboxControllerSource.Properties.Resources.crosshair_red;
            this.pictureBox_Axis2_pos.Location = new System.Drawing.Point(458, 263);
            this.pictureBox_Axis2_pos.Name = "pictureBox_Axis2_pos";
            this.pictureBox_Axis2_pos.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Axis2_pos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Axis2_pos.TabIndex = 5;
            this.pictureBox_Axis2_pos.TabStop = false;
            // 
            // pictureBox_Axis1_pos
            // 
            this.pictureBox_Axis1_pos.Image = global::CS_xboxControllerSource.Properties.Resources.crosshair_red;
            this.pictureBox_Axis1_pos.Location = new System.Drawing.Point(181, 153);
            this.pictureBox_Axis1_pos.Name = "pictureBox_Axis1_pos";
            this.pictureBox_Axis1_pos.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Axis1_pos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Axis1_pos.TabIndex = 5;
            this.pictureBox_Axis1_pos.TabStop = false;
            // 
            // pictureBox_Bbutton_press
            // 
            this.pictureBox_Bbutton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_Bbutton_press;
            this.pictureBox_Bbutton_press.Location = new System.Drawing.Point(420, 374);
            this.pictureBox_Bbutton_press.Name = "pictureBox_Bbutton_press";
            this.pictureBox_Bbutton_press.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Bbutton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Bbutton_press.TabIndex = 1;
            this.pictureBox_Bbutton_press.TabStop = false;
            // 
            // pictureBox_Abutton_press
            // 
            this.pictureBox_Abutton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_Abutton_press;
            this.pictureBox_Abutton_press.Location = new System.Drawing.Point(364, 374);
            this.pictureBox_Abutton_press.Name = "pictureBox_Abutton_press";
            this.pictureBox_Abutton_press.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Abutton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Abutton_press.TabIndex = 1;
            this.pictureBox_Abutton_press.TabStop = false;
            // 
            // pictureBox_Ybutton_press
            // 
            this.pictureBox_Ybutton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_Ybutton_press;
            this.pictureBox_Ybutton_press.Location = new System.Drawing.Point(308, 374);
            this.pictureBox_Ybutton_press.Name = "pictureBox_Ybutton_press";
            this.pictureBox_Ybutton_press.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Ybutton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Ybutton_press.TabIndex = 1;
            this.pictureBox_Ybutton_press.TabStop = false;
            // 
            // pictureBox_Xbutton_press
            // 
            this.pictureBox_Xbutton_press.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Xbutton_press.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController_Xbutton_press;
            this.pictureBox_Xbutton_press.Location = new System.Drawing.Point(249, 374);
            this.pictureBox_Xbutton_press.Name = "pictureBox_Xbutton_press";
            this.pictureBox_Xbutton_press.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Xbutton_press.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Xbutton_press.TabIndex = 1;
            this.pictureBox_Xbutton_press.TabStop = false;
            // 
            // pictureBox_xboxController
            // 
            this.pictureBox_xboxController.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_xboxController.Image = global::CS_xboxControllerSource.Properties.Resources.xboxController;
            this.pictureBox_xboxController.Location = new System.Drawing.Point(12, 18);
            this.pictureBox_xboxController.Name = "pictureBox_xboxController";
            this.pictureBox_xboxController.Size = new System.Drawing.Size(722, 482);
            this.pictureBox_xboxController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_xboxController.TabIndex = 0;
            this.pictureBox_xboxController.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 781);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox_keyboard);
            this.Controls.Add(this.checkBox_linear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Sensitivity);
            this.Controls.Add(this.checkBox_keyboardOn);
            this.Controls.Add(this.checkBox_mouseEventMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_ShowAddressBarButton_press);
            this.Controls.Add(this.pictureBox_ShowMenuButton_press);
            this.Controls.Add(this.pictureBox_RightTrigger_press);
            this.Controls.Add(this.pictureBox_RightTrigger);
            this.Controls.Add(this.pictureBox_LeftTrigger_press);
            this.Controls.Add(this.pictureBox_LeftTrigger);
            this.Controls.Add(this.pictureBox_controllerConnected);
            this.Controls.Add(this.pictureBox_RightShoulder_press);
            this.Controls.Add(this.pictureBox_LeftShoulder_press);
            this.Controls.Add(this.pictureBox_RightStick_press);
            this.Controls.Add(this.pictureBox_LeftStick_press);
            this.Controls.Add(this.pictureBox_RIGHTbutton_press);
            this.Controls.Add(this.pictureBox_LEFTbutton_press);
            this.Controls.Add(this.pictureBox_DOWNbutton_press);
            this.Controls.Add(this.pictureBox_UPbutton_press);
            this.Controls.Add(this.pictureBox_keyboard_Lpos);
            this.Controls.Add(this.pictureBox_keyboard_Rpos);
            this.Controls.Add(this.pictureBox_Axis2_pos);
            this.Controls.Add(this.pictureBox_Axis1_pos);
            this.Controls.Add(this.pictureBox_Bbutton_press);
            this.Controls.Add(this.pictureBox_Abutton_press);
            this.Controls.Add(this.pictureBox_Ybutton_press);
            this.Controls.Add(this.pictureBox_Xbutton_press);
            this.Controls.Add(this.pictureBox_xboxController);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Xbox one controller";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_keyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowAddressBarButton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowMenuButton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightTrigger_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightTrigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftTrigger_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftTrigger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_controllerConnected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightShoulder_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftShoulder_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightStick_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftStick_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RIGHTbutton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LEFTbutton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DOWNbutton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UPbutton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_keyboard_Lpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_keyboard_Rpos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Axis2_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Axis1_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bbutton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Abutton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ybutton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Xbutton_press)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_xboxController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_xboxController;
        private System.Windows.Forms.PictureBox pictureBox_Xbutton_press;
        private System.Windows.Forms.PictureBox pictureBox_Ybutton_press;
        private System.Windows.Forms.PictureBox pictureBox_Abutton_press;
        private System.Windows.Forms.PictureBox pictureBox_Bbutton_press;
        private System.Windows.Forms.Timer timer_readController;
        private System.Windows.Forms.PictureBox pictureBox_Axis1_pos;
        private System.Windows.Forms.PictureBox pictureBox_Axis2_pos;
        private System.Windows.Forms.PictureBox pictureBox_UPbutton_press;
        private System.Windows.Forms.PictureBox pictureBox_DOWNbutton_press;
        private System.Windows.Forms.PictureBox pictureBox_LEFTbutton_press;
        private System.Windows.Forms.PictureBox pictureBox_RIGHTbutton_press;
        private System.Windows.Forms.PictureBox pictureBox_LeftStick_press;
        private System.Windows.Forms.PictureBox pictureBox_RightStick_press;
        private System.Windows.Forms.PictureBox pictureBox_LeftShoulder_press;
        private System.Windows.Forms.PictureBox pictureBox_RightShoulder_press;
        private System.Windows.Forms.PictureBox pictureBox_controllerConnected;
        private System.Windows.Forms.PictureBox pictureBox_LeftTrigger;
        private System.Windows.Forms.PictureBox pictureBox_RightTrigger;
        private System.Windows.Forms.PictureBox pictureBox_LeftTrigger_press;
        private System.Windows.Forms.PictureBox pictureBox_RightTrigger_press;
        private System.Windows.Forms.PictureBox pictureBox_ShowMenuButton_press;
        private System.Windows.Forms.PictureBox pictureBox_ShowAddressBarButton_press;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_mouseEventMode;
        private System.Windows.Forms.TextBox textBox_Sensitivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_linear;
        private System.Windows.Forms.CheckBox checkBox_keyboardOn;
        private System.Windows.Forms.PictureBox pictureBox_keyboard;
        private System.Windows.Forms.PictureBox pictureBox_keyboard_Rpos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox_keyboard_Lpos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

