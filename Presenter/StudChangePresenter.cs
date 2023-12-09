
using Kr4.Viev;
using System.Drawing;

namespace Kr4.Presenter
{
    public interface IChangePresenter
    {
        public void Run(int id);
        public void ReloadGroupBox();
        event EventHandler CloseForm;
        event EventHandler OpenGroupAdd;
    }
    public class StudChangePresenter : IChangePresenter
    {
        public event EventHandler? CloseForm;
        public event EventHandler? OpenGroupAdd;

        private readonly IMessageService MessageInt;
        private readonly IValidator ValidatorInt;
        private readonly IStudChange StudChange;
        int tmp_id;
        public StudChangePresenter(IStudChange StudChange, IMessageService MessageInt, IValidator validatorInt)
        {
            this.StudChange = StudChange;
            this.MessageInt = MessageInt;
            ValidatorInt = validatorInt;
            StudChange.OpenGroupAddForm += new EventHandler(OpenGroupAddForm);
            StudChange.TryToChange += new EventHandler(TryStudentChange);
            StudChange.TryToDelete+= new EventHandler(TryStudentDelete);
         

        }
        public void ReloadGroupBox()
        {
            StudChange.ClearComboBox();
            LoadData();
        }
       
        public void OpenGroupAddForm(object? sender, EventArgs e)
        {
            if (OpenGroupAdd != null) OpenGroupAdd(this, EventArgs.Empty);
        }
        public void Run(int id)
        {
            tmp_id=id;
            LoadData();
            StudChange.ShowForm();
        }
        public void LoadData()
        {
            var student = DbManager.GetStudent(tmp_id);
            StudChange.name = student!.StudentName!;
            StudChange.surname = student!.StudentSurname!;
            StudChange.middlename = student!.StudentMidlename!;
            List<StudentGroup> groups = DbManager.GetGroupList();
            StudChange.InsertGroupComboBox(groups);
            StudChange.SetData();
            StudChange.SelectGroupComboBox(student.Group!);
            StudChange.group = student.Group!;
            StudChange.birthday = student!.Birthday;
            StudChange.gender = student!.Gender;
        }
  
        private void TryStudentChange(object? sender, EventArgs e)
        {
            string erorrs = ValidatorInt.StudAddPreValidation(StudChange.name, StudChange.surname, StudChange.middlename, StudChange.birthday);
            if (erorrs != "")
            {
                MessageInt.ShowError(erorrs);
                return;
            }
            Student newStudent = new(StudChange.name, StudChange.surname, StudChange.middlename, StudChange.gender, StudChange.birthday);
            erorrs = ValidatorInt.GroupFirstValidation(StudChange.group);
            if (erorrs != "")
            {
                MessageInt.ShowError(erorrs);
                return;
            }
            var student = DbManager.GetStudent(tmp_id);
            DbManager.ChangeStudent(student!, StudChange.group.ToString()!, newStudent);
            string message = "Данные изменены!";
            MessageInt.ShowMessage(message);
            StudChange.ClearFields();
            if (CloseForm != null) CloseForm(this, EventArgs.Empty);
            StudChange.CloseForm();

        }
        private void TryStudentDelete(object? sender, EventArgs e)
        {
            var student = DbManager.GetStudent(tmp_id);
            DbManager.DeleteStudent(student!);
            string message = "Студент успешно удалён!";
            MessageInt.ShowMessage(message);
            StudChange.ClearFields();
            if (CloseForm != null) CloseForm(this, EventArgs.Empty);
            StudChange.CloseForm();
        }


    }
}
