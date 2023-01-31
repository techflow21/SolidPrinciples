using SingleResponsibilityLibrary;
using OpenCloseLibrary;
using LiskovSubstitution;
using InterfaceSegregationLibrary;
using DependencyInversionLibrary;

namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleResponsibilityLogic SRlogic = new();

            SRlogic.Display();

            /////////////////////////////////////////////////////////

            /*OpenCloseLogic openCloseLogic = new();

            openCloseLogic.OpenCloseDisplay();
            Console.WriteLine();
            openCloseLogic.OpenCloseDisplay2();*/

            ////////////////////////////////////////////////////////

            /*LiskovSubs liskov = new();

            liskov.LiskovSubsDisplay();*/

            ////////////////////////////////////////////////////////

            /*InterfaceSegregation interfaceSegregation = new();

            interfaceSegregation.InterfaceSegDisplay();*/

            ///////////////////////////////////////////////////////

            DependencyInversion dependencyInversion = new();

            dependencyInversion.DependencyInversionDisplay();
        }

    }
}
