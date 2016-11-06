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

        public Form1()
        {
            InitializeComponent();

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

                //Left click
                if (this.gamePadState.Buttons.LeftShoulder == Input.ButtonState.Pressed)
                {
                    pictureBox_LeftShoulder_press.Visible = true;
                    MouseEvent.LeftDown();
                }
                else if (this.gamePadState.Buttons.LeftShoulder == Input.ButtonState.Released)
                {
                    pictureBox_LeftShoulder_press.Visible = false;
                    MouseEvent.LeftUp();
                }
                else
                    pictureBox_LeftShoulder_press.Visible = false;

                //Right click
                if (this.gamePadState.Buttons.RightShoulder == Input.ButtonState.Pressed)
                {
                    pictureBox_RightShoulder_press.Visible = true;
                    MouseEvent.RightDown();
                }
                else if (this.gamePadState.Buttons.RightShoulder == Input.ButtonState.Released)
                {
                    pictureBox_RightShoulder_press.Visible = false;
                    MouseEvent.RightUp();
                }
                else
                    pictureBox_RightShoulder_press.Visible = false;
            
                pictureBox_ShowMenuButton_press.Visible = (this.gamePadState.Buttons.Start == Input.ButtonState.Pressed);
                pictureBox_ShowAddressBarButton_press.Visible = (this.gamePadState.Buttons.Back == Input.ButtonState.Pressed);
                pictureBox_controllerConnected.Visible = (this.gamePadState.Buttons.BigButton == Input.ButtonState.Pressed);
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
        private void button1_Click(object sender, EventArgs e)
        {
           // SetCursorPos(500, 500);
            MouseEvent.Move(300,200);
            Thread.Sleep(1000);
            MouseEvent.LeftClick();
            Thread.Sleep(1000);
            MouseEvent.LeftDown();
            Thread.Sleep(1000);
            MouseEvent.Move(100, 100);
            Thread.Sleep(1000);
            MouseEvent.LeftUp();
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
