namespace Kr4.Presenter
{
    public interface IGroupAddPresenter
    {
        public void Run();
      
        event EventHandler CloseForm;
       

    }
    public class GroupAddPresenter : IGroupAddPresenter
    {
        public event EventHandler? CloseForm;


        private readonly IMessageService MessageInt;
        private readonly IAddGroup AddGroupInt;
        private readonly IValidator ValidatorInt;
    
        public GroupAddPresenter(IAddGroup addGroupInt, IMessageService MessageInt, IValidator ValidatorInt)
        {
            AddGroupInt = addGroupInt;
            this.MessageInt = MessageInt;
            this.ValidatorInt = ValidatorInt;

            addGroupInt.TryToAddGroup += new EventHandler(GroupTryToAdd);
            addGroupInt.Exit += new EventHandler(TryToExit);
    
        }

        public void Run()
        {
            AddGroupInt.ShowForm();

        }
        private void GroupTryToAdd(object? sender, EventArgs e)
        {

            AddGroup();
        }
        public void AddGroup()
        {
            string? groupName = AddGroupInt.groupName;
            string erorrs = ValidatorInt.GroupFirstValidation(groupName);
            if (erorrs != "")
            {
                AddGroupInt.ClearFields();
                MessageInt.ShowError(erorrs);
                return;
            }
            erorrs = ValidatorInt.GroupPostValidation(groupName);
            if (erorrs != "")
            {
                AddGroupInt.ClearFields();
                MessageInt.ShowError(erorrs);
                return;
            }
            DbManager.AddGroup(groupName);
            string message = "Группа успешно сохранена";
            MessageInt.ShowMessage(message);
            AddGroupInt.ClearFields();



        }
        private void TryToExit(object? sender, EventArgs e)
        {

            Exit();
        }
        private void Exit()
        {
            if (AddGroupInt.groupName != "")
            {
                string message = "Остались введённые данные. Выйти?";
                DialogResult result = MessageInt.ShowExitMessage(message);
                if (result == DialogResult.OK)
                {
                    AddGroupInt.CloseForm();
                    if (CloseForm != null) CloseForm(this, EventArgs.Empty);
                }

            }
            else
            {
                if (CloseForm != null) CloseForm(this, EventArgs.Empty);
                AddGroupInt.CloseForm();
            }
        }



    }
}
