using steam.Infrastructure.Context;
using steam.Services;

namespace steam
{
    /// <summary>
    /// Форма для админ панели карт
    /// </summary>
    public partial class Form14 : Form
    {
        private readonly SteamDbContext _dbContext;
        private readonly string _nickName;

        public Form14(SteamDbContext dbContext, string nickname)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _nickName = nickname;

            var cards = CardService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Number,
                    p.ExperationDate,
                    p.UserId,
                    p.Ballance,
                    p.CVV
                }).ToList();
            Cards.DataSource = cards;
        }

        /// <summary>
        /// Сортировать
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {
            DateTime minDate = MinimumDateField.Value.ToUniversalTime();
            DateTime maxDate = MaximumDateField.Value.ToUniversalTime();
            double minBallance = Convert.ToDouble(MinimumBallanceField.Value);
            double maxBallance = Convert.ToDouble(MaximumBallanceField.Value);

            var cards = CardService.GetAllWhere(
                _dbContext, minDate, maxDate, minBallance, maxBallance)
                .Select(p => new
                {
                    p.Id,
                    p.Number,
                    p.ExperationDate,
                    p.UserId,
                    p.Ballance,
                    p.CVV
                }).ToList();
            Cards.DataSource = cards;
        }

        /// <summary>
        /// Отменить сортировку
        /// </summary>
        private void CancelSortButton_Click(object sender, EventArgs e)
        {
            var cards = CardService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Number,
                    p.ExperationDate,
                    p.UserId,
                    p.Ballance,
                    p.CVV
                }).ToList();
            Cards.DataSource = cards;
        }

        /// <summary>
        /// Удалить карту
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Cards.SelectedRows.Count > 0)
            {
                Guid selectedCardnId = (Guid)Cards.SelectedRows[0].Cells["Id"].Value;

                var cardToDelete = CardService.GetById(_dbContext, selectedCardnId);

                var user = _dbContext.Users.FirstOrDefault(u => u.CardId == selectedCardnId);
                user.CardId = null;

                _dbContext.Cards.RemoveRange(cardToDelete);
                _dbContext.Update(user);
                _dbContext.SaveChanges();

                MessageBox.Show("Карта была удалена");

                var cards = CardService.GetAll(_dbContext)
                .Select(p => new
                {
                    p.Id,
                    p.Number,
                    p.ExperationDate,
                    p.UserId,
                    p.Ballance,
                    p.CVV
                }).ToList();

                Cards.DataSource = cards;
            }
        }

        /// <summary>
        /// Вернуться
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11(_dbContext, _nickName);
            form.Show();
            Hide();
        }
    }
}
