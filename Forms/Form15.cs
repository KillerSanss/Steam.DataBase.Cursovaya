using steam.Infrastructure.Context;
using steam.Infrastructure.Enums;
using steam.Services;

namespace steam
{
    /// <summary>
    /// Форма админ панели пользователей
    /// </summary>
    public partial class Form15 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form15(SteamDbContext dbContext, string nickName)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _nickName = nickName;

            var users = UserService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.NickName,
                    p.RegistrationDate,
                    p.Ballance,
                    p.Password,
                    p.Role
                }).ToList();
            Users.DataSource = users;
        }

        /// <summary>
        /// Сортировать пользователей
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {
            DateTime minDate = MinimumDateField.Value.ToUniversalTime();
            DateTime maxDate = MaximumDateField.Value.ToUniversalTime();
            double minBallance = Convert.ToDouble(MinimumBallanceField.Value);
            double maxBallance = Convert.ToDouble(MaximumBallanceField.Value);
            string role = RoleField.Text;
            Role userRole = Role.None;

            switch (role)
            {
                case "User":
                    {
                        userRole = Role.User;
                        break;
                    }
                case "Developer":
                    {
                        userRole = Role.Developer;
                        break;
                    }
            }

            var users = UserService.GetAllWhere(
                _dbContext, minDate, maxDate, minBallance, maxBallance, userRole)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.NickName,
                    p.RegistrationDate,
                    p.Ballance,
                    p.Password,
                    p.Role
                }).ToList();

            Users.DataSource = users;
        }

        /// <summary>
        /// Отменить сортировку
        /// </summary>
        private void CancelSortButton_Click(object sender, EventArgs e)
        {
            var users = UserService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.NickName,
                    p.RegistrationDate,
                    p.Ballance,
                    p.Password,
                    p.Role
                }).ToList();
            Users.DataSource = users;
        }

        /// <summary>
        /// Удалить пользователя из базы данных
        /// </summary>
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (Users.SelectedRows.Count > 0)
            {
                Guid selectedUserId = (Guid)Users.SelectedRows[0].Cells["id"].Value;

                var userToDelete = CardService.GetById(_dbContext, selectedUserId);

                _dbContext.Cards.RemoveRange(userToDelete);
                _dbContext.SaveChanges();

                MessageBox.Show("Пользователь был удален!");

                var users = UserService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.NickName,
                    p.RegistrationDate,
                    p.Ballance,
                    p.Password,
                    p.Role
                }).ToList();
                Users.DataSource = users;
            }
        }
        
        /// <summary>
        /// Возвращение на главную страницу
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11(_dbContext, _nickName);
            form.Show();
            Hide();
        }
    }
}
