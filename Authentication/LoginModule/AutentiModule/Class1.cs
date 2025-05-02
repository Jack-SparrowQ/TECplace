
using Login;
namespace AutentiModule
{
    public class Class1
    {
        public bool runLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if(loginForm.enter())
            {
                return true;
            } else
                return false;
        }
    }
}
