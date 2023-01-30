using SingleResponsibilityLibrary;
using OpenCloseLibrary;

namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*SingleResponsibilityLogic SRlogic = new();

            SRlogic.Display();*/

            OpenCloseLogic openCloseLogic = new();

            openCloseLogic.OpenCloseDisplay();
            Console.WriteLine();
            openCloseLogic.OpenCloseDisplay2();
        }

    }
}
