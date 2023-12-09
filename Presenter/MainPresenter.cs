using Autofac;


namespace Kr4.Presenter{
public class MainPresenter
{
    private  IChangePresenter changePresenter;
    private IMainFormPresenter mainFormPresenter;
    private  IStudAddPresenter studAddPresenter;
    private IGroupAddPresenter groupAddPresenter;
    private object? LastSender;
        public MainPresenter(IChangePresenter changePresenter, IMainFormPresenter mainFormPresenter,
            IStudAddPresenter studAddPresenter, IGroupAddPresenter groupAddPresenter)
        {
            this.changePresenter = changePresenter;
            this.mainFormPresenter = mainFormPresenter;
            this.studAddPresenter = studAddPresenter;
            this.groupAddPresenter = groupAddPresenter;

            groupAddPresenter.CloseForm += new EventHandler(ReloadGroupData);

            changePresenter.OpenGroupAdd += new EventHandler(OpenGroupAddForm);
            changePresenter.CloseForm += new EventHandler(ReloadData);

            studAddPresenter.OpenGroupAdd += new EventHandler(OpenGroupAddForm);
            studAddPresenter.CloseForm += new EventHandler(ReloadData);

            mainFormPresenter.OpenStudAdd += new EventHandler(OpenStudAddForm);
            mainFormPresenter.OpenStudChange += new EventHandler<OpenStudChangeEventArgs>(OpenChangeForm);
        }

        public void ReloadGroupData(object? sender, EventArgs e)
         {
        if (LastSender!.GetType() == changePresenter.GetType())
        {
            changePresenter.ReloadGroupBox();
        }
        else if (LastSender!.GetType() == studAddPresenter.GetType())
        {
            studAddPresenter.ReloadGroupBox();
        }

         }

    public void ReloadData(object? sender, EventArgs e)
    {

        mainFormPresenter.ReloadData();
    }

    public void OpenMainForm()
    {
        mainFormPresenter.Run();
    }

    public void OpenStudAddForm(object? sender, EventArgs e)
    {
        var scope = AutofacManager.Container!.BeginLifetimeScope();
        var tmp_resenter = scope.Resolve<IStudAddPresenter>();
        studAddPresenter = tmp_resenter;
        studAddPresenter.OpenGroupAdd += new EventHandler(OpenGroupAddForm);
        studAddPresenter.CloseForm += new EventHandler(ReloadData);
        studAddPresenter.Run();

    }

    public void OpenChangeForm(object? sender, OpenStudChangeEventArgs e)
    {
        var scope1 = AutofacManager.Container!.BeginLifetimeScope();
        var tmp_resenter = scope1.Resolve<IChangePresenter>();
        changePresenter = tmp_resenter;
        changePresenter.OpenGroupAdd += new EventHandler(OpenGroupAddForm);
        changePresenter.CloseForm += new EventHandler(ReloadData);
        changePresenter.Run(e.id);


    }

    public void OpenGroupAddForm(object? sender, EventArgs e)
    {
        LastSender = sender;
            var scope2 = AutofacManager.Container!.BeginLifetimeScope();
        var tmp_resenter = scope2.Resolve<IGroupAddPresenter>();
        groupAddPresenter= tmp_resenter;
        groupAddPresenter.CloseForm += new EventHandler(ReloadGroupData);
        groupAddPresenter.Run();

    }

}
}