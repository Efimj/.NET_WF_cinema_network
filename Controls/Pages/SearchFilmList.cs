using CPProject.components;
using CPProject.Controls.Pages;
using CPProject.GlobalStates;
using CPProject.handlers;
using CPProject.types;

namespace CPProject.Controls
{
    public partial class SearchFilmList : UserControl
    {
        public SearchFilmList()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void SearchFilmList_Load(object sender, EventArgs e)
        {
            createButtonShower(AuthorizationState.Instance.UsersType);
            AuthorizationState.Instance.subscribeOnChange((EUsersType s) =>
            {
                createButtonShower(s);
            });
            customComboBox1.ComboBoxElement.Items.AddRange(new object[] { "none", "descending date", "ascending date", "rating" });
            customComboBox1.ComboBoxElement.SelectedIndex = 0;
            for (int i = 0; i < 20; i++)
            {
                FilmCard card = new FilmCard();
                card.FilmNameLable.Text = "Terminator resistance ";
                card.FilmDescriptionLable.Text = "Этот код создает новую кнопку для каждой итерациЭтот код создает новую кнопку для каждой итерации цЭтот код создает новую кнопку для каждой итерации ци цикла и добавляет ее в Controls коллекцию FlowLayoutPanel. Поскольку FlowLayoutPanel автоматически упорядочивает элементы в соответствии с настройками свойства FlowDirection, кнопки будут отображаться в порядке, определенном ";
                card.filmClickEvent += () =>
                {
                    this.Hide();
                    Panel? parentPanel = (Panel?)this.Parent;
                    if (parentPanel != null)
                    {
                        FilmPage fp = new FilmPage(() =>
                        {
                            this.Show();
                            parentPanel.Controls.RemoveAt(1);
                        });
                        parentPanel.Controls.Add(fp);
                    }
                };
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void createButtonShower(EUsersType s)
        {
            if (s == types.EUsersType.Administrator)
            {
                buttonCreateNewFilm.Visible = true;
            }
            else
            {
                buttonCreateNewFilm.Visible = false;
            }
        }

        private void buttonCreateNewFilm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel? parentPanel = (Panel?)this.Parent;
            if (parentPanel != null)
            {
                CreateFilmPage createFilmPage = new CreateFilmPage(() =>
                {
                    this.Show();
                    parentPanel.Controls.RemoveAt(1);
                });
                parentPanel.Controls.Add(createFilmPage);
            }
        }
    }
}
