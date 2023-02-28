using CPProject.Controls;
using CPProject.GlobalStates;

namespace CPProject.handlers
{
    public class MainFormLayoutHandlers
    {
        public void OnAuthorization(Panel navBarPanel, Panel pagePanel)
        {
            if (AuthorizationState.Instance.UsersType == types.EUsersType.Guest)
            {
                navBarPanel.Controls.Clear();
                navBarPanel.Controls.Add(new NBAuthorization(pagePanel));
            }
            if (AuthorizationState.Instance.UsersType == types.EUsersType.Customer)
            {
                navBarPanel.Controls.Clear();
                navBarPanel.Controls.Add(new NBCustomer(pagePanel));
            }
            if (AuthorizationState.Instance.UsersType == types.EUsersType.Administrator)
            {
                //navBarPanel.Controls.Clear();
                //navBarPanel.Controls.Add(new NBCustomer(pagePanel));
            }
        }
    }
}
