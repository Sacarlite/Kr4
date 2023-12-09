    
using Kr4.Model;
using Kr4.Properties;

namespace Kr4.Presenter
{
    public interface IMainFormPresenter
    {
        void Run();
        void ReloadData();
        event EventHandler OpenStudAdd;
        event EventHandler<OpenStudChangeEventArgs> OpenStudChange;
    }
    public class OpenStudChangeEventArgs : EventArgs
    {
        public readonly int id;
       

        public OpenStudChangeEventArgs(int id)
        {
            this.id = id;
            
        }

    }
    public class MainformPresenter : IMainFormPresenter
    {
        
       
        public event EventHandler? OpenStudAdd;
        public event EventHandler<OpenStudChangeEventArgs>? OpenStudChange;
        List<Student> students = new List<Student>();
        List<Student>? studentsSelectedList;
        const string male = "Мужской";
        const string female = "Женский";
        private readonly IMain mainForm;
        private readonly IMessageService messageInt;
        private readonly IFileManager fileManagerInt;
        public MainformPresenter(IMain mainForm, IMessageService messageInt, IFileManager fileManagerInt)
        {
            this.mainForm = mainForm;
            this.messageInt = messageInt;
            this.fileManagerInt= fileManagerInt;
            mainForm.SaveData += new EventHandler(SaveData);
            mainForm.Selection += new EventHandler(MainFormSelection);
            mainForm.Reset += new EventHandler(Reset);
            mainForm.LoadData += new EventHandler(MainFormLoadData);
            mainForm.OpenForm += new EventHandler(Open);
            mainForm.OpenChangeForm += new EventHandler(MainFormChangeRun);
            mainForm.ShowMainForm += new EventHandler(MainFormShow);


        }
        private void MainFormShow(object? sender, EventArgs e)
        {
            if (Settings.Default.Grettings)
            {
                messageInt.ShowMessage("Боковой Владислав Сергеевич 415а Контрольная работа №4 Вариант№2\n Задание: Программа хранящая список студентов");

            }
        }
        private void MainFormChangeRun(object? sender, EventArgs e)
        {
            if (OpenStudChange != null) OpenStudChange(this, new OpenStudChangeEventArgs(mainForm.id));
           
        }
        private void Reset(object? sender, EventArgs e)
        {
            mainForm.ResetSample();
            List<List<string?>> studentList = GetStringStudentList(students);
            mainForm.LoadDataTable(studentList);
        }
        private void MainFormSelection(object? sender, EventArgs e)
        {
            mainForm.DataGridClear();
            if ((mainForm.selectectedGender.ToString() == "-") && mainForm.selectectedGroup.ToString() == "-") { return; }
            else if (mainForm.selectectedGender.ToString() == "-")
            {
                studentsSelectedList = DbManager.GetStudentsGroupX(mainForm.selectectedGroup.ToString()!);
            }
            else if (mainForm.selectectedGroup.ToString() == "-")
            {
                bool gender = true;
                if (mainForm.selectectedGender.ToString() == female) { gender = false; }
                studentsSelectedList = DbManager.GetStudentsGenderX(gender);
            }
            else
            {

                bool gender = true;
                if (mainForm.selectectedGender.ToString() == male) { gender = true; }
                else if (mainForm.selectectedGender.ToString() == female) { gender = false; }
                studentsSelectedList = DbManager.GetStudentsGroupAndGenderX(mainForm.selectectedGroup.ToString()!, gender);
            }
            List<List<string?>> studentList = GetStringStudentList(studentsSelectedList);
            mainForm.LoadDataTable(studentList);
        }

        private void SaveData(object? sender, EventArgs e)
        {
            if (mainForm.FilePath == "")
                return;
            try
            {
                fileManagerInt.ExportData(students, mainForm.FilePath!);
            }
            catch (Exception)
            {

                messageInt.ShowError("Файл был закрыт до внесения изменений!");
            }


        }
        private void Open(object? sender, EventArgs e)
        {
            if (OpenStudAdd != null) OpenStudAdd(this, EventArgs.Empty);
        }
        private void MainFormLoadData(object? sender, EventArgs e)
        {

            LoadData();
        }
        private List<List<string?>> GetStringStudentList(List<Student> students)
        {
            List<List<string?>> studentList = new List<List<string?>>();
            foreach (Student student in students)
            {
                List<string?> studentData = new List<string?>
                
                {
                    student.Id.ToString(),
                    student.StudentName,
                    student.StudentSurname,
                    student.StudentMidlename
                };
                if (student.Gender)
                {
                    studentData.Add(male);
                }
                else
                {
                    studentData.Add(female);
                }
                studentData.Add(student.Birthday.ToString("D"));
                studentData.Add(student.Group!.Group);
                studentList.Add(studentData);
            }
            return studentList;
        }

        public void Run()
        {
       
            mainForm.ShowForm();
         
        }

        public void LoadData()
        {
            ConectString.conectionString = Settings.Default.ConectionString;
            students = DbManager.GetStudentList();
            List<StudentGroup> groups = DbManager.GetGroupList();
            List<List<string?>> studentList = GetStringStudentList(students);
            mainForm.LoadDataTable(studentList);
            mainForm.InsertGroupComboBox(groups);
        }

        public void ReloadData()
        {
            mainForm.DataGridClear();
            mainForm.ComboboxClear();
            LoadData();
        }


    }
}
