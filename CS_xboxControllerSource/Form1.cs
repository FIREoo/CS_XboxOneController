using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Input = Microsoft.Xna.Framework.Input;

//moust event
using System.Runtime.InteropServices;


namespace CS_xboxControllerSource
{
    
    public partial class Form1 : Form
    {     
        GamePadState gamePadState;
        GamePadState previousState;
        //one controller
        PlayerIndex playerIndex = PlayerIndex.One;


        int vibrationCountdown = 0;
        
        //keyboard
        System.Drawing.Point const_keyboard_right_point = new System.Drawing.Point(574, 121);
        System.Drawing.Point const_keyboard_left_point = new System.Drawing.Point(474, 121);
        string onText_R;
        string onText_L;

        bool keyboard_en = true;

        public Form1() 
        {
            InitializeComponent();

            this.Size = new Size(980, 550);

            GamePad.SetVibration(PlayerIndex.One, 0.0f, 0.0f);

            pictureBox_xboxController.Controls.Add(pictureBox_controllerConnected);
            pictureBox_xboxController.Controls.Add(pictureBox_Xbutton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_Ybutton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_Abutton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_Bbutton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_Axis1_pos);
            pictureBox_xboxController.Controls.Add(pictureBox_Axis2_pos);
            pictureBox_xboxController.Controls.Add(pictureBox_UPbutton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_DOWNbutton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_RIGHTbutton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_LEFTbutton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_LeftStick_press);
            pictureBox_xboxController.Controls.Add(pictureBox_RightStick_press);
            pictureBox_xboxController.Controls.Add(pictureBox_LeftShoulder_press);
            pictureBox_xboxController.Controls.Add(pictureBox_RightShoulder_press);
            pictureBox_xboxController.Controls.Add(pictureBox_ShowMenuButton_press);
            pictureBox_xboxController.Controls.Add(pictureBox_ShowAddressBarButton_press);
            
            pictureBox_controllerConnected.BackColor = System.Drawing.Color.Transparent;
            pictureBox_Xbutton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_Ybutton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_Abutton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_Bbutton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_Axis1_pos.BackColor = System.Drawing.Color.Transparent;
            pictureBox_Axis2_pos.BackColor = System.Drawing.Color.Transparent;
            pictureBox_UPbutton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_DOWNbutton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_RIGHTbutton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_LEFTbutton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_LeftStick_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_RightStick_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_LeftShoulder_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_RightShoulder_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_RightTrigger.BackColor = System.Drawing.Color.Transparent;
            pictureBox_LeftTrigger.BackColor = System.Drawing.Color.Transparent;
            pictureBox_ShowMenuButton_press.BackColor = System.Drawing.Color.Transparent;
            pictureBox_ShowAddressBarButton_press.BackColor = System.Drawing.Color.Transparent;

            pictureBox_controllerConnected.Location = new System.Drawing.Point(329, 30);
            pictureBox_Xbutton_press.Location = new System.Drawing.Point(471, 121);
            pictureBox_Ybutton_press.Location = new System.Drawing.Point(521, 73);
            pictureBox_Abutton_press.Location = new System.Drawing.Point(521, 170);
            pictureBox_Bbutton_press.Location = new System.Drawing.Point(571, 121);
            pictureBox_Axis1_pos.Location = new System.Drawing.Point(169, 136);//r = 40
            pictureBox_Axis2_pos.Location = new System.Drawing.Point(445, 246);//r = 40
            pictureBox_UPbutton_press.Location = new System.Drawing.Point(250, 209);
            pictureBox_DOWNbutton_press.Location = new System.Drawing.Point(251, 290);
            pictureBox_RIGHTbutton_press.Location = new System.Drawing.Point(294, 244);
            pictureBox_LEFTbutton_press.Location = new System.Drawing.Point(216, 245);
            pictureBox_LeftStick_press.Location = new System.Drawing.Point(121, 90);
            pictureBox_RightStick_press.Location = new System.Drawing.Point(395, 196);
            pictureBox_LeftShoulder_press.Location = new System.Drawing.Point(111, 0);
            pictureBox_RightShoulder_press.Location = new System.Drawing.Point(455, 1);
            pictureBox_ShowMenuButton_press.Location = new System.Drawing.Point(399, 131);
            pictureBox_ShowAddressBarButton_press.Location = new System.Drawing.Point(295, 131);

            pictureBox_controllerConnected.Visible = false;
            pictureBox_Axis1_pos.Visible = false;
            pictureBox_Axis2_pos.Visible = false;
            pictureBox_Xbutton_press.Visible = false;
            pictureBox_Ybutton_press.Visible = false;
            pictureBox_Abutton_press.Visible = false;
            pictureBox_Bbutton_press.Visible = false;
            pictureBox_UPbutton_press.Visible = false;
            pictureBox_DOWNbutton_press.Visible = false;
            pictureBox_RIGHTbutton_press.Visible = false;
            pictureBox_LEFTbutton_press.Visible = false;
            pictureBox_LeftStick_press.Visible = false;
            pictureBox_RightStick_press.Visible = false;
            pictureBox_LeftStick_press.Visible = false;
            pictureBox_RightStick_press.Visible = false;
            pictureBox_LeftShoulder_press.Visible = false;
            pictureBox_RightShoulder_press.Visible = false;
            pictureBox_ShowMenuButton_press.Visible = false;
            pictureBox_ShowAddressBarButton_press.Visible = false;

            pictureBox_LeftTrigger_press.Size = new Size(45, 0);
            pictureBox_LeftTrigger_press.Size = new Size(45, 0);

            textBox_Sensitivity.Text = "50";

            //keyboard
            pictureBox_keyboard.Controls.Add(pictureBox_keyboard_Rpos);
            pictureBox_keyboard.Controls.Add(pictureBox_keyboard_Lpos);
            pictureBox_keyboard.BackColor = System.Drawing.Color.Transparent;
            pictureBox_keyboard.BackColor = System.Drawing.Color.Transparent;
            pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(490, 69);
            pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(145, 69);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer_readController.Start();
        }
        private void timer_readController_Tick(object sender, EventArgs e)
        {
            this.CheckVibrationTimeout();

            if (checkBox_mouseEventMode.Checked == true)
                this.UpdateControllerStateWithMouseEvent();
            else if (checkBox_keyboardOn.Checked == true)
                this.UpdateControllerStateKeyboardMode();
            else
                this.UpdateControllerState();
        }
        private void CheckVibrationTimeout()
        {
            if (vibrationCountdown > 0)
            {
                --vibrationCountdown;
                if (vibrationCountdown == 0.0f)
                {
                    GamePad.SetVibration(playerIndex, 0.0f, 0.0f);
                }
            }
        }
        private void UpdateControllerState()
        {
            //Get the new gamepad state and save the old state.
            this.previousState = this.gamePadState;
            this.gamePadState = GamePad.GetState(this.playerIndex);
            //If the controller is not connected, let the user know
            if(this.gamePadState.IsConnected)
            {
                ///pictureBox_controllerConnected.Visible = true;
                pictureBox_Axis1_pos.Visible = true;
                pictureBox_Axis2_pos.Visible = true;
            }
            else
            {
                ///pictureBox_controllerConnected.Visible = false;
                pictureBox_Axis1_pos.Visible = false;
                pictureBox_Axis2_pos.Visible = false;
            }

            //I personally prefer to only update the buttons if their state has been changed. 
            if (!this.gamePadState.Buttons.Equals(this.previousState.Buttons))
            {
                pictureBox_Xbutton_press.Visible = (this.gamePadState.Buttons.X == Input.ButtonState.Pressed);
                pictureBox_Ybutton_press.Visible = (this.gamePadState.Buttons.Y == Input.ButtonState.Pressed);
                pictureBox_Abutton_press.Visible = (this.gamePadState.Buttons.A == Input.ButtonState.Pressed);
                pictureBox_Bbutton_press.Visible = (this.gamePadState.Buttons.B == Input.ButtonState.Pressed);
                pictureBox_LeftStick_press.Visible = (this.gamePadState.Buttons.LeftStick == Input.ButtonState.Pressed);
                pictureBox_RightStick_press.Visible = (this.gamePadState.Buttons.RightStick == Input.ButtonState.Pressed);
                pictureBox_LeftShoulder_press.Visible = (this.gamePadState.Buttons.LeftShoulder == Input.ButtonState.Pressed);
                pictureBox_RightShoulder_press.Visible = (this.gamePadState.Buttons.RightShoulder == Input.ButtonState.Pressed);
                pictureBox_ShowMenuButton_press.Visible = (this.gamePadState.Buttons.Start == Input.ButtonState.Pressed);
                pictureBox_ShowAddressBarButton_press.Visible = (this.gamePadState.Buttons.Back == Input.ButtonState.Pressed);
                pictureBox_controllerConnected.Visible = (this.gamePadState.Buttons.BigButton == Input.ButtonState.Pressed);
            }

            if (!this.gamePadState.DPad.Equals(this.previousState.DPad))
            {
                pictureBox_UPbutton_press.Visible = (this.gamePadState.DPad.Up == Input.ButtonState.Pressed);
                pictureBox_DOWNbutton_press.Visible = (this.gamePadState.DPad.Down == Input.ButtonState.Pressed);
                pictureBox_RIGHTbutton_press.Visible = (this.gamePadState.DPad.Right == Input.ButtonState.Pressed);
                pictureBox_LEFTbutton_press.Visible = (this.gamePadState.DPad.Left == Input.ButtonState.Pressed);
            }

            //Update the position of the thumb sticks
            //since the thumbsticks can return a number between -1.0 and +1.0
            pictureBox_Axis1_pos.Location = new System.Drawing.Point(169 + (int)((this.gamePadState.ThumbSticks.Left.X ) * 40.0f), 136 - (int)((this.gamePadState.ThumbSticks.Left.Y) * 40f));
            label2.Text = this.gamePadState.ThumbSticks.Left.X.ToString();
            label3.Text = this.gamePadState.ThumbSticks.Left.Y.ToString();
            pictureBox_Axis2_pos.Location = new System.Drawing.Point(445 + (int)((this.gamePadState.ThumbSticks.Right.X) * 40.0f), 246 - (int)((this.gamePadState.ThumbSticks.Right.Y) * 40f));

            //The triggers return a value between 0.0 and 1.0.  I only needed to scale these values for
            //the progress bar
            this.pictureBox_LeftTrigger_press.Size = new Size(45, (int)((this.gamePadState.Triggers.Left * 67)));
            this.pictureBox_RightTrigger_press.Size = new Size(45, (int)((this.gamePadState.Triggers.Right * 67)));
        }

        private void UpdateControllerStateWithMouseEvent()
        {
            this.previousState = this.gamePadState;
            this.gamePadState = GamePad.GetState(this.playerIndex);         
            if (this.gamePadState.IsConnected)
            {
                ///pictureBox_controllerConnected.Visible = true;
                pictureBox_Axis1_pos.Visible = true;
                pictureBox_Axis2_pos.Visible = true;
            }
            else
            {
                ///pictureBox_controllerConnected.Visible = false;
                pictureBox_Axis1_pos.Visible = false;
                pictureBox_Axis2_pos.Visible = false;
            }

            //I personally prefer to only update the buttons if their state has been changed. 
            if (!this.gamePadState.Buttons.Equals(this.previousState.Buttons))
            {
                pictureBox_Xbutton_press.Visible = (this.gamePadState.Buttons.X == Input.ButtonState.Pressed);
                pictureBox_Ybutton_press.Visible = (this.gamePadState.Buttons.Y == Input.ButtonState.Pressed);
                pictureBox_Abutton_press.Visible = (this.gamePadState.Buttons.A == Input.ButtonState.Pressed);
                pictureBox_Bbutton_press.Visible = (this.gamePadState.Buttons.B == Input.ButtonState.Pressed);
                pictureBox_LeftStick_press.Visible = (this.gamePadState.Buttons.LeftStick == Input.ButtonState.Pressed);
                pictureBox_RightStick_press.Visible = (this.gamePadState.Buttons.RightStick == Input.ButtonState.Pressed);
                pictureBox_LeftShoulder_press.Visible = (this.gamePadState.Buttons.LeftShoulder == Input.ButtonState.Pressed);
                pictureBox_RightShoulder_press.Visible = (this.gamePadState.Buttons.RightShoulder == Input.ButtonState.Pressed);
                pictureBox_ShowMenuButton_press.Visible = (this.gamePadState.Buttons.Start == Input.ButtonState.Pressed);
                pictureBox_ShowAddressBarButton_press.Visible = (this.gamePadState.Buttons.Back == Input.ButtonState.Pressed);
                pictureBox_controllerConnected.Visible = (this.gamePadState.Buttons.BigButton == Input.ButtonState.Pressed);

                //

                //Left click
                if (this.gamePadState.Buttons.LeftShoulder == Input.ButtonState.Pressed)
                    MouseEvent.LeftDown();
                else if (this.gamePadState.Buttons.LeftShoulder == Input.ButtonState.Released)
                    MouseEvent.LeftUp();

                //Right click
                if (this.gamePadState.Buttons.RightShoulder == Input.ButtonState.Pressed)
                    MouseEvent.RightDown();
                else if (this.gamePadState.Buttons.RightShoulder == Input.ButtonState.Released)
                    MouseEvent.RightUp();

                //change mode
                if (this.gamePadState.Buttons.Start == Input.ButtonState.Pressed)
                {
                    checkBox_mouseEventMode.Checked = false;
                    checkBox_keyboardOn.Checked = true;
                }

            }

            //Update the position of the thumb sticks
            //since the thumbsticks can return a number between -1.0 and +1.0
            float asix1_x = this.gamePadState.ThumbSticks.Left.X;
            float asix1_y = this.gamePadState.ThumbSticks.Left.Y;
            pictureBox_Axis1_pos.Location = new System.Drawing.Point((int)(169 + asix1_x * 40.0f), (int)(136 - asix1_y * 40f));
            float sens = float.Parse(textBox_Sensitivity.Text);

            if(checkBox_linear.Checked == true)
            {
                MouseEvent.Move((int)(asix1_x * sens), -(int)(asix1_y * sens));
            }
            else
            {
                float move_x, move_y;
                if (asix1_x >= 0)
                    move_x = asix1_x * asix1_x;
                else
                    move_x = -(asix1_x * asix1_x);

                if (asix1_y >= 0)
                    move_y = asix1_y * asix1_y;
                else
                    move_y = -(asix1_y * asix1_y);
                MouseEvent.Move((int)(move_x * sens), -(int)(move_y * sens));
            }
           
            pictureBox_Axis2_pos.Location = new System.Drawing.Point(445 + (int)((this.gamePadState.ThumbSticks.Right.X) * 40.0f), 246 - (int)((this.gamePadState.ThumbSticks.Right.Y) * 40f));

            //The triggers return a value between 0.0 and 1.0.  I only needed to scale these values for
            //the progress bar
            this.pictureBox_LeftTrigger_press.Size = new Size(45, (int)((this.gamePadState.Triggers.Left * 67)));
            this.pictureBox_RightTrigger_press.Size = new Size(45, (int)((this.gamePadState.Triggers.Right * 67)));
        }

        private void UpdateControllerStateKeyboardMode()
        {
            //Get the new gamepad state and save the old state.
            this.previousState = this.gamePadState;
            this.gamePadState = GamePad.GetState(this.playerIndex);
            //If the controller is not connected, let the user know
            if (this.gamePadState.IsConnected)
            {
                pictureBox_Axis1_pos.Visible = true;
                pictureBox_Axis2_pos.Visible = true;
            }
            else
            {
                pictureBox_Axis1_pos.Visible = false;
                pictureBox_Axis2_pos.Visible = false;
            }


            //I personally prefer to only update the buttons if their state has been changed. 
            if (!this.gamePadState.Buttons.Equals(this.previousState.Buttons))
            {
                pictureBox_Xbutton_press.Visible = (this.gamePadState.Buttons.X == Input.ButtonState.Pressed);
                pictureBox_Ybutton_press.Visible = (this.gamePadState.Buttons.Y == Input.ButtonState.Pressed);
                pictureBox_Abutton_press.Visible = (this.gamePadState.Buttons.A == Input.ButtonState.Pressed);
                pictureBox_Bbutton_press.Visible = (this.gamePadState.Buttons.B == Input.ButtonState.Pressed);
                pictureBox_LeftStick_press.Visible = (this.gamePadState.Buttons.LeftStick == Input.ButtonState.Pressed);
                pictureBox_RightStick_press.Visible = (this.gamePadState.Buttons.RightStick == Input.ButtonState.Pressed);
                pictureBox_LeftShoulder_press.Visible = (this.gamePadState.Buttons.LeftShoulder == Input.ButtonState.Pressed);
                pictureBox_RightShoulder_press.Visible = (this.gamePadState.Buttons.RightShoulder == Input.ButtonState.Pressed);
                pictureBox_ShowMenuButton_press.Visible = (this.gamePadState.Buttons.Start == Input.ButtonState.Pressed);
                pictureBox_ShowAddressBarButton_press.Visible = (this.gamePadState.Buttons.Back == Input.ButtonState.Pressed);
                pictureBox_controllerConnected.Visible = (this.gamePadState.Buttons.BigButton == Input.ButtonState.Pressed);

                //

                //change mode
                if (this.gamePadState.Buttons.Start == Input.ButtonState.Pressed)
                {
                    checkBox_mouseEventMode.Checked = true;
                    checkBox_keyboardOn.Checked = false;
                }

                //change EN CH
                if (this.gamePadState.Buttons.LeftStick == Input.ButtonState.Pressed)
                    if (keyboard_en == true)
                    {
                        pictureBox_keyboard.Image = CS_xboxControllerSource.Properties.Resources.keyboard2_ch;
                        SendKeys.SendWait("+");
                        keyboard_en = false;
                    }
                    else
                    {
                        pictureBox_keyboard.Image = CS_xboxControllerSource.Properties.Resources.keyboard2_en;
                        SendKeys.SendWait("+");
                        keyboard_en = true;
                    }

                //click to type
                if (this.gamePadState.Buttons.RightShoulder == Input.ButtonState.Pressed)
                    if (onText_R != null)
                        SendKeys.SendWait(onText_R);

                if (this.gamePadState.Buttons.LeftShoulder == Input.ButtonState.Pressed)
                    if (onText_L != null)
                        SendKeys.SendWait(onText_L);

                if (this.gamePadState.Buttons.A == Input.ButtonState.Pressed)
                    SendKeys.SendWait("{ENTER}");
                if (this.gamePadState.Buttons.B == Input.ButtonState.Pressed)
                    SendKeys.SendWait("{ENTER}");
                if (this.gamePadState.Buttons.X == Input.ButtonState.Pressed)
                    SendKeys.SendWait("{DELETE}");
                if (this.gamePadState.Buttons.Y == Input.ButtonState.Pressed)
                    SendKeys.SendWait("{BACKSPACE}");

            }

            if (!this.gamePadState.DPad.Equals(this.previousState.DPad))
            {
                if (this.gamePadState.DPad.Up == Input.ButtonState.Pressed)
                {
                    pictureBox_UPbutton_press.Visible = true;
                    SendKeys.SendWait("{UP}");
                }
                else
                    pictureBox_UPbutton_press.Visible = false;

                if (this.gamePadState.DPad.Down == Input.ButtonState.Pressed)
                {
                    pictureBox_DOWNbutton_press.Visible = true;
                    SendKeys.SendWait("{DOWN}");
                }
                else
                    pictureBox_DOWNbutton_press.Visible = false;

                if (this.gamePadState.DPad.Right == Input.ButtonState.Pressed)
                {
                    pictureBox_RIGHTbutton_press.Visible = true;
                    SendKeys.SendWait("{RIGHT}");
                }
                else
                    pictureBox_RIGHTbutton_press.Visible = false;

                if (this.gamePadState.DPad.Left == Input.ButtonState.Pressed)
                {
                    pictureBox_LEFTbutton_press.Visible = true;
                    SendKeys.SendWait("{LEFT}");
                }
                else
                    pictureBox_LEFTbutton_press.Visible = false;

            }

            //Update the position of the thumb sticks
            //since the thumbsticks can return a number between -1.0 and +1.0
            pictureBox_Axis1_pos.Location = new System.Drawing.Point(169 + (int)((this.gamePadState.ThumbSticks.Left.X) * 40.0f), 136 - (int)((this.gamePadState.ThumbSticks.Left.Y) * 40f));
            pictureBox_Axis2_pos.Location = new System.Drawing.Point(445 + (int)((this.gamePadState.ThumbSticks.Right.X) * 40.0f), 246 - (int)((this.gamePadState.ThumbSticks.Right.Y) * 40f));

            //The triggers return a value between 0.0 and 1.0
            this.pictureBox_LeftTrigger_press.Size = new Size(45, (int)((this.gamePadState.Triggers.Left * 67)));
            this.pictureBox_RightTrigger_press.Size = new Size(45, (int)((this.gamePadState.Triggers.Right * 67)));


            //get targit text
            if (keyboard_en == true)
            {
                onText_R = getRightAxisKeyboardText_en(this.gamePadState.ThumbSticks.Right.X, this.gamePadState.ThumbSticks.Right.Y);
                onText_L = getLeftAxisKeyboardText_en(this.gamePadState.ThumbSticks.Left.X, this.gamePadState.ThumbSticks.Left.Y);
            }
            else if(keyboard_en == false)
            {
                if ((int)(this.gamePadState.Triggers.Right) < 0.1)
                    onText_R = getRightAxisKeyboardText_ch(this.gamePadState.ThumbSticks.Right.X, this.gamePadState.ThumbSticks.Right.Y);
                else
                    onText_R = getRightAxisKeyboardText_outline_ch(this.gamePadState.ThumbSticks.Right.X, this.gamePadState.ThumbSticks.Right.Y);

                if ((int)(this.gamePadState.Triggers.Left) < 0.1)
                    onText_L = getLeftAxisKeyboardText_ch(this.gamePadState.ThumbSticks.Left.X, this.gamePadState.ThumbSticks.Left.Y);
                else
                    onText_L = getLeftAxisKeyboardText_outline_ch(this.gamePadState.ThumbSticks.Left.X, this.gamePadState.ThumbSticks.Left.Y);
            }


        }

        private String getRightAxisKeyboardText_ch(float value_x, float value_y)
        {
            //mid line
            const int Y_m = 100;
            const int X_mid_place = 491;
            const int gap_v = 69;
            const int gap_h = 51;
            if (value_y < 0.3f && value_y > -0.3f)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_m);
                    return "k";
                }
                else if (value_x > 0.15f && value_x <= 0.65f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_m);
                    return "l";
                }
                else if (value_x > 0.65f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_m);
                    return ";";
                }
                else if (value_x < -0.15f && value_x >= -0.65f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_m);
                    return "j";
                }
                else if (value_x < -0.65f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_m);
                    return "h";
                }
            }

            //up line
            const int Y_u = Y_m - gap_h;
            if (value_y > 0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_u);
                    return "i";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_u);
                    return "o";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_u);
                    return "p";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_u);
                    return "u";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_u);
                    return "y";
                }
            }

            //down line
            const int Y_d = Y_m + gap_h;
            if (value_y < -0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_d);
                    return ",";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_d);
                    return ".";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_d);
                    return "/";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_d);
                    return "m";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_d);
                    return "n";
                }
            }
            return null;
        }
        private String getLeftAxisKeyboardText_ch(float value_x, float value_y)
        {
            //mid line
            const int Y_m = 100;
            const int X_mid_place = 146;
            const int gap_v = 69;
            const int gap_h = 51;
            if (value_y < 0.3f && value_y > -0.3f)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_m);
                    return "d";
                }
                else if (value_x > 0.15f && value_x <= 0.65f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_m);
                    return "f";
                }
                else if (value_x > 0.65f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_m);
                    return "g";
                }
                else if (value_x < -0.15f && value_x >= -0.65f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_m);
                    return "s";
                }
                else if (value_x < -0.65f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_m);
                    return "a";
                }
            }

            //up line
            const int Y_u = Y_m - gap_h;
            if (value_y > 0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_u);
                    return "e";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_u);
                    return "r";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_u);
                    return "t";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_u);
                    return "w";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_u);
                    return "q";
                }
            }

            //down line
            const int Y_d = Y_m + gap_h;
            if (value_y < -0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_d);
                    return "c";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_d);
                    return "v";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_d);
                    return "b";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_d);
                    return "x";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_d);
                    return "z";
                }
            }
            return null;
        }
        private String getRightAxisKeyboardText_outline_ch(float value_x, float value_y)
        {
            //mid line outline
            const int Y_m = 100;
            const int X_mid_place = 491;
            const int gap_v = 69;
            const int gap_h = 51;
            if (value_y < 0.3f && value_y > -0.3f)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_m);
                    return "k";
                }
                else if (value_x > 0.15f && value_x <= 0.65f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_m);
                    return "l";
                }
                else if (value_x > 0.65f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 3, Y_m - gap_h * 2);
                    return "-";
                }
                else if (value_x < -0.15f && value_x >= -0.65f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_m);
                    return "j";
                }
                else if (value_x < -0.65f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_m);
                    return "h";
                }
            }

            //up line outline
            const int Y_u = Y_m - gap_h*2;
            if (value_y > 0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_u);
                    return "8";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_u);
                    return "9";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_u);
                    return "0";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_u);
                    return "7";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_u);
                    return "6";
                }
            }

            //down line
            const int Y_d = Y_m + gap_h;
            if (value_y < -0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_d);
                    return ",";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_d);
                    return ".";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_d);
                    return "/";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_d);
                    return "m";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_d);
                    return "n";
                }
            }
            return null;
        }
        private String getLeftAxisKeyboardText_outline_ch(float value_x, float value_y)
        {
            //mid line
            const int Y_m = 100;
            const int X_mid_place = 146;
            const int gap_v = 69;
            const int gap_h = 51;
            if (value_y < 0.3f && value_y > -0.3f)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_m);
                    return "d";
                }
                else if (value_x > 0.15f && value_x <= 0.65f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_m);
                    return "f";
                }
                else if (value_x > 0.65f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_m);
                    return "g";
                }
                else if (value_x < -0.15f && value_x >= -0.65f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_m);
                    return "s";
                }
                else if (value_x < -0.65f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_m);
                    return "a";
                }
            }

            //up line outline
            const int Y_u = Y_m - gap_h*2;
            if (value_y > 0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_u);
                    return "3";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_u);
                    return "4";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_u);
                    return "5";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_u);
                    return "2";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_u);
                    return "1";
                }
            }

            //down line
            const int Y_d = Y_m + gap_h;
            if (value_y < -0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_d);
                    return "c";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_d);
                    return "v";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_d);
                    return "b";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_d);
                    return "x";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_d);
                    return "z";
                }
            }
            return null;
        }
        private String getRightAxisKeyboardText_en(float value_x, float value_y)
        {
            //mid line
            const int Y_m = 69;
            const int X_mid_place = 490;
            const int gap_v = 69;
            const int gap_h = 64;
            if (value_y < 0.3f && value_y > -0.3f)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_m);
                    return "k";
                }
                else if (value_x > 0.15f && value_x <= 0.65f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_m);
                    return "l";
                }
                else if (value_x > 0.65f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_m);
                    return ";";
                }
                else if (value_x < -0.15f && value_x >= -0.65f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_m);
                    return "j";
                }
                else if (value_x < -0.65f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_m);
                    return "h";
                }
            }

            //up line
            const int Y_u = Y_m - gap_h;
            if (value_y > 0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_u);
                    return "i";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_u);
                    return "o";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_u);
                    return "p";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_u);
                    return "u";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_u);
                    return "y";
                }
            }

            //down line
            const int Y_d = Y_m + gap_h;
            if (value_y < -0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place, Y_d);
                    return ",";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_d);
                    return ".";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_d);
                    return "/";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_d);
                    return "m";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_d);
                    return "n";
                }
            }
            return null;
        }
        private String getLeftAxisKeyboardText_en(float value_x, float value_y)
        {
            //mid line
            const int Y_m = 69;
            const int X_mid_place = 145;
            const int gap_v = 69;
            const int gap_h = 64;
            if (value_y < 0.3f && value_y > -0.3f)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_m);
                    return "d";
                }
                else if (value_x > 0.15f && value_x <= 0.65f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v* 1, Y_m);
                    return "f";
                }
                else if (value_x > 0.65f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_m);
                    return "g";
                }
                else if (value_x < -0.15f && value_x >= -0.65f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_m);
                    return "s";
                }
                else if (value_x < -0.65f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_m);
                    return "a";
                }
            }

            //up line
            const int Y_u = Y_m - gap_h;
            if (value_y > 0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_u);
                    return "e";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_u);
                    return "r";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_u);
                    return "t";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_u);
                    return "w";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_u);
                    return "q";
                }
            }

            //down line
            const int Y_d = Y_m + gap_h;
            if (value_y < -0.3)
            {
                if (value_x > -0.15f && value_x <= 0.15f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place, Y_d);
                    return "c";
                }
                else if (value_x > 0.15f && value_x <= 0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 1, Y_d);
                    return "v";
                }
                else if (value_x > 0.55f && value_x <= 1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place + gap_v * 2, Y_d);
                    return "b";
                }
                else if (value_x < -0.15f && value_x >= -0.55f)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 1, Y_d);
                    return "x";
                }
                else if (value_x < -0.55f && value_x >= -1)
                {
                    pictureBox_keyboard_Lpos.Location = new System.Drawing.Point(X_mid_place - gap_v * 2, Y_d);
                    return "z";
                }
            }
            return null;
        }


        // check box 
        private void checkBox_mouseEventMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mouseEventMode.Checked == true)
            {
                checkBox_keyboardOn.Checked = false;
                this.Size = new Size(980, 550);
            }
        }
        private void checkBox_keyboardOn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_keyboardOn.Checked == true)
            {
                checkBox_mouseEventMode.Checked = false;
                this.Size = new Size(980, 820);
            }
            else
            {
                this.Size = new Size(980, 550);
            }
        }


        //testing-------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox_keyboard_Rpos.Location = new System.Drawing.Point((int)int.Parse(textBox1.Text), (int)int.Parse(textBox2.Text));
            //GamePad.SetVibration(playerIndex, 1, 1);
            vibrationCountdown = 10;
            //Thread.Sleep(1000);
            //SendKeys.SendWait("aa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(pictureBox_keyboard_Rpos.Location.X, pictureBox_keyboard_Rpos.Location.Y - (int)int.Parse(textBox3.Text));

            textBox1.Text = pictureBox_keyboard_Rpos.Location.X.ToString();
            textBox2.Text = pictureBox_keyboard_Rpos.Location.Y.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(pictureBox_keyboard_Rpos.Location.X, pictureBox_keyboard_Rpos.Location.Y + (int)int.Parse(textBox3.Text));

            textBox1.Text = pictureBox_keyboard_Rpos.Location.X.ToString();
            textBox2.Text = pictureBox_keyboard_Rpos.Location.Y.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(pictureBox_keyboard_Rpos.Location.X - (int)int.Parse(textBox3.Text), pictureBox_keyboard_Rpos.Location.Y);

            textBox1.Text = pictureBox_keyboard_Rpos.Location.X.ToString();
            textBox2.Text = pictureBox_keyboard_Rpos.Location.Y.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox_keyboard_Rpos.Location = new System.Drawing.Point(pictureBox_keyboard_Rpos.Location.X + (int)int.Parse(textBox3.Text), pictureBox_keyboard_Rpos.Location.Y);

            textBox1.Text = pictureBox_keyboard_Rpos.Location.X.ToString();
            textBox2.Text = pictureBox_keyboard_Rpos.Location.Y.ToString();
        }


    }


    //moust event
    public class MouseEvent
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public static void Move(int xDelta, int yDelta)
        {
            mouse_event(MOUSEEVENTF_MOVE, xDelta, yDelta, 0, 0);
        }
        public static void MoveTo(int x, int y)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
        }
        public static void LeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }

        public static void LeftDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }

        public static void LeftUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }

        public static void RightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }

        public static void RightDown()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }

        public static void RightUp()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y, 0, 0);
        }
    }
}
