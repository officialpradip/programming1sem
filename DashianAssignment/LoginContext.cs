using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashianAssignment
{
   
        public class LoginContext : ApplicationContext
        {


            #region Private fields
            // here we can declare the all forms application and manage it directly
            //(show, close, set as MainForm and so on) 
            private Splash _frmSplash;
            private LoginForm _fLogin;
            private Main _fMain;

            #endregion

            #region Initialization

            public LoginContext()
            {
                CreateSplashForm();

                // CreateLoginForm();

            }

            #endregion

            #region Private Methods

            /// <summary>
            ///  The Splash form 
            ///  initialization, show and close
            /// </summary>
            private void CreateSplashForm()
            {
                _frmSplash = new Splash();
                _frmSplash.Closed += new EventHandler(frmSplash_Closed);
                MainForm = _frmSplash;
                _frmSplash.Show();


            }

            private void frmSplash_Closed(object sender, EventArgs e)
            {
                if (_frmSplash.showLoginForm)
                {
                    CreateLoginForm();
                }
                else
                {
                    Application.Exit();
                }
            }

            /// <summary>
            /// The Login form
            /// initialization and show
            /// </summary>
            private void CreateLoginForm()
            {

                _fLogin = new LoginForm();
                _fLogin.Closed += new EventHandler(fLogin_Closed);
                this.MainForm = _fLogin;
                _fLogin.Show();

            }
            /// If the login procedure done successfully
            /// we'll see the Main Form
            /// else the application will close 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void fLogin_Closed(object sender, EventArgs e)
            {
                // if (LWork.LoginWork.Logged) //if the user is logged
                var a = 1;
                if (a == 1)
                {
                    _fMain = new Main();
                    //_fMain._UserDetailModel = _fLogin.UserDetailModel;
                    this.MainForm = _fMain; //set the main message loop applicaton in this form
                    _fMain.Closed += new EventHandler(fMain_Closed);
                    _fMain.Show();
                }
                else
                {
                    ExitThread();
                }

            }

            private void fMain_Closed(object sender, EventArgs e)
            {
                if (_fMain.IsLogOut)
                {
                    CreateLoginForm();
                }
                else
                {
                    Application.Exit();
                }
            }

            #endregion
        }

    }
