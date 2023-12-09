

using Spire.Xls;

namespace Kr4.Model
{
    public interface IFileManager
    {
        void ExportData(List<Student> studentsList, string filePath);

    }
    public class FileManager: IFileManager
    {

       public void ExportData(List<Student> studentsList, string filePath)
        {
            Workbook workbook = new Workbook();
            Worksheet sheet = workbook.Worksheets[0];
            sheet.Range[1,1].Value = $"Имя";
            sheet.Range[1,2].Text = $"Фамилия";
            sheet.Range[1, 3].Text = $"Отчество";
            sheet.Range[1, 4].Text = $"Гендер";
            sheet.Range[1, 5].Text = $"Дата рождения";
            sheet.Range[1, 5].ColumnWidth = 16;
            sheet.Range[1, 6].Text = $"Группа";
            for (int i = 2; i < studentsList.Count+2; i++)
            {
                sheet.Range[i, 1].Text = studentsList[i-2].StudentName;
                sheet.Range[i, 2].Text = studentsList[i-2].StudentSurname;
                sheet.Range[i, 3].Text = studentsList[i - 2].StudentMidlename;
                if (studentsList[i-2].Gender)
                {
                    sheet.Range[i, 4].Text = "Мужской";
                }
                else
                {
                    sheet.Range[i , 4].Text = "Женский";
                }

                sheet.Range[i, 5].Text = studentsList[i - 2].Birthday.ToString("D");
                sheet.Range[i, 6].Text = studentsList[i - 2].Group!.Group;
            }
            workbook.SaveToFile(filePath, ExcelVersion.Version2016);
        }
    }
}
