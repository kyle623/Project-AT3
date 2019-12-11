using AT3Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT3Server
{
    public partial class AT3Server : Form
    {
        public AT3Server()
        {
            InitializeComponent();
            enableStartButton();
            disableStopButton();
            AddDefaultUser();
            AddDefaultUser2();
        }

        static UserRepository userRepo = new UserRepository();
        static PasswordManager pwdManager = new PasswordManager();

        private NamedPipeServerStream pipe;
        //private Thread listenThread;
        private StreamWriter sw;

        //----------------------------------------------------------Button-Methods---------------------------------------------------------
        private void BtnStart_Click(object sender, EventArgs e)
        {
            pipe = new NamedPipeServerStream("JMCPipe", PipeDirection.InOut);
            Thread listenThread = new Thread(Listen)
            { IsBackground = true };
            listenThread.Name = "listenThread";
            
            listenThread.Start();
            disableStartButton();
            enableStopButton();
            LblPipelineStatus.Text = "Online";
            LblPipelineStatus.ForeColor = System.Drawing.Color.Green;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            enableStartButton();
            disableStopButton();
            LblPipelineStatus.ForeColor = System.Drawing.Color.Red;
            LblPipelineStatus.Text = "Not Connected";
            //listenThread.Abort(); FIX
            pipe.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBNUser.Text) && !string.IsNullOrEmpty(TBNPwd.Text))
            {
                LBOutputLog.Items.Clear();
                LBOutputLog.Items.Add("New User Created");
                string userid = TBNUser.Text;
                string password = TBNPwd.Text;
                LBOutputLog.Items.Add("userid " + userid);
                LBOutputLog.Items.Add("password " + password);
                string salt = null;
                string passwordHash = pwdManager.GeneratePasswordHash(password, out salt);
                string[] pwd = pwdManager.GeneratePasswordHash(password, out salt).Split(',');
                // save the values in the database
                User user = new User
                {
                    UserId = userid,
                    PasswordHash = pwd[0],
                    Salt = pwd[1]
                };
                userRepo.AddUser(user);
                LBOutputLog.Items.Add("Salt " + salt);
                TBNUser.Clear();
                TBNPwd.Clear();
            }
        }



        private void BtnValidate_Click(object sender, EventArgs e)
        {
            LBOutputLog.Items.Clear();
            LBOutputLog.Items.Add("Validation Check");
            string userid = TBVUser.Text;
            LBOutputLog.Items.Add("Staff ID " + userid);
            string password = TBVPwd.Text;
            LBOutputLog.Items.Add("Password " + password);
            User user2 = userRepo.GetUser(userid);
            bool result = pwdManager.IsPasswordMatch(password, user2.Salt, user2.PasswordHash);
            if (result)
                LBOutputLog.Items.Add("Password Matched");
            else
                LBOutputLog.Items.Add("Password FAIL");
            TBVUser.Clear();
            TBVPwd.Clear();
        }

        //-------------------------------------------------------------Methods-------------------------------------------------------------

        /// <summary>
        /// Listens for client
        /// </summary>
        public void Listen()
        {
            pipe.WaitForConnection();
            Thread readThread = new Thread(Read)
            { IsBackground = true };
            readThread.Start();
        }

        /// <summary>
        /// reads the input from client
        /// </summary>
        public void Read()
        {
            using (StreamReader sr = new StreamReader(pipe))
            {
                while (true)
                {
                    string buffer;
                    try
                    {
                        buffer = sr.ReadLine();
                        Console.WriteLine(buffer);
                    }
                    catch
                    {
                        break;
                    }
                    if (buffer != null)
                    {
                        Login(buffer);
                    }
                }
            }
        }

        /// <summary>
        /// Logs in a user from staff id and password information
        /// </summary>
        /// <param name="data"></param>
        public void Login(string data)
        {
            string[] split = data.Split(',');
            User user = userRepo.GetUser(split[0]);
            string password = split[1];

            bool result = pwdManager.IsPasswordMatch(password, user.Salt, user.PasswordHash);
            if (result)
            {
                LBOutputLog.Items.Add("Client Matched Password");
                LBOutputLog.Items.Add("Client Logged on the server");
                SendMessage("Correct");
            }
            else
            {
                LBOutputLog.Items.Add("Password FAIL");
                SendMessage("Incorrect");
            }
        }

        /// <summary>
        /// makes a default/initialised user
        /// </summary>
        private void AddDefaultUser()
        {
            string userID = "TEST";
            string password = "123456789";
            string salt = null;
            string passwordHash = pwdManager.GeneratePasswordHash(password, out salt);
            string[] pwd = pwdManager.GeneratePasswordHash(password, out salt).Split(',');
            User user = new User
            {
                UserId = userID,
                PasswordHash = pwd[0],
                Salt = pwd[1]
            };
            userRepo.AddUser(user);
        }

        void AddDefaultUser2()
        {
            string userID = "kyle";
            string password = "kyle";
            string salt = null;
            string passwordHash = pwdManager.GeneratePasswordHash(password, out salt);
            string[] pwd = pwdManager.GeneratePasswordHash(password, out salt).Split(',');
            User user2 = new User
            {
                UserId = userID,
                PasswordHash = pwd[0],
                Salt = pwd[1]
            };
            userRepo.AddUser(user2);
        }

        /// <summary>
        /// sends a message by writing into the pipeline and sending to a client
        /// </summary>
        /// <param name="message"></param>
        void SendMessage(string message)
        {
            try
            {
                sw = new StreamWriter(pipe);
                sw.AutoFlush = true;

                if (sw != null)
                {
                    sw.WriteLine(message);
                    sw.Flush();
                }
            }
            catch (ObjectDisposedException e)
            {
                MessageBox.Show("Error: " + e + "\n Server might have been closed try again");
            }
        }

        //----------------------------------------------------------Minor-methods----------------------------------------------------------
        private void enableStartButton()
        {
            BtnStart.Enabled = true;
        }

        void disableStartButton()
        {
            BtnStart.Enabled = false;
        }

        void enableStopButton()
        {
            BtnStop.Enabled = true;
        }

        void disableStopButton()
        {
            BtnStop.Enabled = false;
        }
        //------------------------------------------------------------Properties------------------------------------------------------------
        //Textboxes properties methods
        private void TBNUser_Enter(object sender, EventArgs e)
        {
            if (TBNUser.Text == "Staff ID")
            {
                TBNUser.Text = "";
                TBNUser.ForeColor = Color.Black;
            }
        }

        private void TBNUser_Leave(object sender, EventArgs e)
        {
            if (TBNUser.Text == "")
            {
                TBNUser.Text = "Staff ID";
                TBNUser.ForeColor = Color.Silver;
            }
        }

        private void TBNPwd_Enter(object sender, EventArgs e)
        {
            if (TBNPwd.Text == "Password")
            {
                TBNPwd.Text = "";
                TBNPwd.ForeColor = Color.Black;
            }
        }

        private void TBNPwd_Leave(object sender, EventArgs e)
        {
            if (TBNPwd.Text == "")
            {
                TBNPwd.Text = "Password";
                TBNPwd.ForeColor = Color.Silver;
            }
        }

        private void TBVUser_Enter(object sender, EventArgs e)
        {
            if (TBVUser.Text == "Staff ID")
            {
                TBVUser.Text = "";

                TBVUser.ForeColor = Color.Black;
            }
        }

        private void TBVUser_Leave(object sender, EventArgs e)
        {
            if (TBVUser.Text == "")
            {
                TBVUser.Text = "Staff ID";

                TBVUser.ForeColor = Color.Silver;
            }
        }

        private void TBVPwd_Enter(object sender, EventArgs e)
        {
            if (TBVPwd.Text == "Password")
            {
                TBVPwd.Text = "";

                TBVPwd.ForeColor = Color.Black;
            }
        }

        private void TBVPwd_Leave(object sender, EventArgs e)
        {
            if (TBVPwd.Text == "")
            {
                TBVPwd.Text = "Password";

                TBVPwd.ForeColor = Color.Silver;
            }
        }

        private void AT3Server_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
