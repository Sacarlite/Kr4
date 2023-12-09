using Kr4.Presenter;
using Autofac;
using Kr4.Viev;
using Kr4.Model;

namespace Kr4
{
    public static class AutofacManager
    {
        public static IContainer? Container { get; private set; }
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            // Регистрируем сервис сообщений и валидатор
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<Validator>().As<IValidator>();
            builder.RegisterType<FileManager>().As<IFileManager>();

            // Регистрируем формы
            builder.RegisterType<MainForm>().As<IMain>();
            builder.RegisterType<StudentChangeForm>().As<IStudChange>();
            builder.RegisterType<StudAddForm>().As<IStudAdd>();
            builder.RegisterType<AddGroupForm>().As<IAddGroup>();

            // Регистрируем презентеры с их зависимостями

            builder.RegisterType<StudAddPresenter>().As<IStudAddPresenter>();
            builder.RegisterType<GroupAddPresenter>().As<IGroupAddPresenter>();
            builder.RegisterType<MainformPresenter>().As<IMainFormPresenter>();
            builder.RegisterType<StudChangePresenter>().As<IChangePresenter>();
            builder.RegisterType<MainPresenter>();

            // Создаем контейнер
            Container = builder.Build();

        }
  
    }
   
}
