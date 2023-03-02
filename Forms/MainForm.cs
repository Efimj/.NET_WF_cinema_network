using CPProject.GlobalStates;
using CPProject.handlers;
using CPProject.types;

namespace CPProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelContainerNavBar.Controls.Add(new NBAuthorization(panelMainFormLayout));
            BackColor = Color.White;
            panelMainFormLayout.BackColor = Color.White;
            AuthorizationState.Instance.subscribeOnChange((EUsersType s) =>
            {
                new MainFormLayoutHandlers().OnAuthorization(panelContainerNavBar, panelMainFormLayout);
            });
        }
    }
}
