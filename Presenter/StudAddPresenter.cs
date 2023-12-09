
namespace Kr4.Presenter
{
    public interface IStudAddPresenter
    {
        public void Run();
        public void ReloadGroupBox();
        event EventHandler CloseForm;
        event EventHandler OpenGroupAdd;

    }
    public class StudAddPresenter : IStudAddPresenter
    {
        public event EventHandler? CloseForm;
        public event EventHandler? OpenGroupAdd;

        private readonly IStudAdd StudAddInt;
        private readonly IMessageService MessageInt;
        private readonly IValidator validatorInt;


        public StudAddPresenter(IStudAdd StudAddInt, IMessageService MessageInt, IValidator validatorInt)
        {
            this.StudAddInt = StudAddInt;
            this.MessageInt = MessageInt;
            this.validatorInt = validatorInt;

            StudAddInt.TryToAdd += new EventHandler(TryStudentAdd);
            StudAddInt.Exit += new EventHandler(TryToExit);
            StudAddInt.OpenForm += new EventHandler(OpenGroupAddForm);


        }

        public void ReloadGroupBox()
        {
            StudAddInt.ClearComboBox();
            LoadData();
        }
        public void OpenGroupAddForm(object? sender, EventArgs e)
        {
            if (OpenGroupAdd != null) OpenGroupAdd(this, EventArgs.Empty);
        }

        private void TryToExit(object? sender, EventArgs e)
        {
            Exit();
        }
      
        public void Run()
        {
            LoadData();
            StudAddInt.ShowForm();
        }

        public void LoadData()
        {
            
            List<StudentGroup> groups = DbManager.GetGroupList();

            StudAddInt.InsertGroupComboBox(groups);
        }
        private void Exit()
        {
            if (StudAddInt.name != "" || StudAddInt.middlename != "" || StudAddInt.surname != "" || StudAddInt.group != null)
            {
                string message = "Остались введённые данные. Выйти?";
                DialogResult result = MessageInt.ShowExitMessage(message);
                if (result == DialogResult.Yes)
                {
                    if (CloseForm != null) CloseForm(this, EventArgs.Empty);
                    StudAddInt.CloseForm();
                }
            }
            else
            {
                if (CloseForm != null) CloseForm(this, EventArgs.Empty);
                StudAddInt.CloseForm();
            }
        }

        private void TryStudentAdd(object? sender, EventArgs e)
        {
            string erorrs = validatorInt.StudAddPreValidation(StudAddInt.name, StudAddInt.surname, StudAddInt.middlename, StudAddInt.birthday);
            if (erorrs != "")
            {
                MessageInt.ShowError(erorrs);
                return;
            }
            Student student = new(StudAddInt.name, StudAddInt.surname, StudAddInt.middlename, StudAddInt.gender, StudAddInt.birthday);
            erorrs = validatorInt.GroupFirstValidation(StudAddInt.group);
            if (erorrs != "")
            {
                MessageInt.ShowError(erorrs);
                return;
            }
            DbManager.AddGroupToStudent(student, StudAddInt.group.ToString()!);
            string message = "Студент успешно добавлен!";
            MessageInt.ShowMessage(message);
            StudAddInt.ClearFields();

        }
    }
}
