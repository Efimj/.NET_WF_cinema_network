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
            BackColor = ColorPalette.Orange;
            panelMainFormLayout.BackColor = ColorPalette.Orange;
            AuthorizationState.Instance.subscribeOnChange((EUsersType s) =>
            {
                new MainFormLayoutHandlers().OnAuthorization(panelContainerNavBar, panelMainFormLayout);
            });
        }
    }
}
