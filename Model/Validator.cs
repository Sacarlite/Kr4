namespace Kr4
{
    public interface IValidator
    {
        string StudAddPreValidation(string name, string surname, string middlename, DateTime birthday);
        string GroupPostValidation(object groupName);
        string GroupFirstValidation(object groupName);



    }
    public class Validator : IValidator
    {
        public string GroupFirstValidation(object groupName)
        {
            string errors = "";
            if (groupName == null) { errors += "Некорректный ввод группы"; return errors; }
            if (groupName.ToString() == "") { errors += "Некорректный ввод группы"; return errors; }
            return errors;

        }

        public string GroupPostValidation(object groupName)
        {
            string errors = "";
            if (groupName == null) { errors += "Некорректный ввод группы"; return errors; }
            if (DbManager.CheckGroupExist(groupName.ToString()!)) { errors += "Такая группа уже существует"; }
            return errors;
        }



        public string StudAddPreValidation(string name, string surname, string middlename, DateTime birthday)
        {
            string errors = "";
            if (name == "") { errors += "Имя введено не корректно" + Environment.NewLine; }
            if (surname == "") { errors += "Фамилия введена не корректно" + Environment.NewLine; }
            if (middlename == "") { errors += "Отчество введено не корректно" + Environment.NewLine; }
            for (int i = 0; i < name.Length - 1; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    errors += "Имя введено не корректно" + Environment.NewLine;
                    break;
                }
            }
            for (int i = 0; i < surname.Length - 1; i++)
            {
                if (!char.IsLetter(surname[i]))
                {
                    errors += "Фамилия введена не корректно" + Environment.NewLine;
                    break;
                }
            }
            for (int i = 0; i < middlename.Length - 1; i++)
            {
                if (!char.IsLetter(middlename[i]))
                {
                    errors += "Отчество введено не корректно" + Environment.NewLine;
                    break;
                }
            }
            if (birthday > DateTime.Now)
            {
                errors += "Дата введена не корректно" + Environment.NewLine;
            }
            return errors;
        }
    }
}