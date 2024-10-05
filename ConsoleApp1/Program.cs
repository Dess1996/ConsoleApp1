

namespace ConsoleApp1
{
    public interface iRow
    {
        void addCode(string Code);
        string getCode();
        void setRow(Func<string> Code, List<string> args);
        string getRows();
    }
    public class Row : iRow
    {
        private String Code;
        private List<(string, List<string>)> Rows = new List<(string, List<string>)>();
        void iRow.addCode(string Code)
        {
            this.Code = Code;
        }
        public string getCode()
        {
            return this.Code;
        }
        void iRow.setRow(Func<string> Code, List<string> args)
        {
             Rows.Add((getCode(), args));
        }
        public string getRows()
        {
            var MyRow = this.Rows.ToArray();
            var myString = "";
            for (int i = 0; i < Rows.Count; i++)
            {
                myString += MyRow[0].Item1;
                myString += " : [";
                for (int i2 = 0; i2 < MyRow[0].Item2.Count; i2++)
                {
                    var value = MyRow[0].Item2[i2].ToString() + ", ";
                    myString += value;
                }
                myString = myString.Substring(0, myString.Length - 2);
                myString += "]";
            }
            return myString;


        }
        }
    public class MyProgram

    {
        public static void Main(string[] args)
        {
            iRow MyIRow = new Row();
            MyIRow.addCode("@MyCode");
            //Console.WriteLine(MyIRow.getCode());
            MyIRow.setRow(MyIRow.getCode, new List<string> { "Misha", "Masha", "Dasha" });
            Console.WriteLine(MyIRow.getRows());


        }

    }

}