using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorManager
{
    class Program
    {
        private static decimal validAmount = 11;
        private static string validEmail = "ron.sun@mailserver.com";
        private static string validCountry = "Taiwan";
        private static string validFoo = "Foo";
        private static string validBar = "Bar";

        static void Main(string[] args)
        {
            // Test
            var tests = new Tests();
            tests.BasicTest();
            tests.SimpleTest();
            tests.AdvanceTest();
            tests.ComplexTest();
            tests.BackToBasicTest();

            // Demo
            //BasicDemo();
            //SimpleDemo();
            //StandardDemo();
            //AdvanceDemo();
            //ComplexDemo();

            Console.ReadLine();
        }

        static void BasicDemo()
        {
            var manager = new Basic.ValidatorManager();
            bool isValid;

            isValid = manager.BasicValidation(validAmount, validEmail);
            Console.WriteLine($"Basic.ValidatorManager.BasicValidation() => {isValid}");

            isValid = manager.FullValidation(validAmount, validEmail, validCountry);
            Console.WriteLine($"Basic.ValidatorManager.FullValidation() => {isValid}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
        }

        static void SimpleDemo()
        {
            var manager = new Simple.ValidatorManager();
            bool isValid;

            isValid = manager.BasicValidation(new Simple.Validators.ValidateContext { Amount = validAmount, Email = validEmail });
            Console.WriteLine($"Simple.ValidatorManager.BasicValidation() => {isValid}");

            isValid = manager.FullValidation(new Simple.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = validCountry });
            Console.WriteLine($"Simple.ValidatorManager.FullValidation() => {isValid}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
        }

        static void StandardDemo()
        {
            var manager = new Standard.ValidatorManager();
            bool isValid;

            isValid = manager.BasicValidation(new Standard.Validators.ValidateContext { Amount = validAmount, Email = validEmail });
            Console.WriteLine($"Standard.ValidatorManager.BasicValidation() => {isValid}");

            isValid = manager.FullValidation(new Standard.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = validCountry });
            Console.WriteLine($"Standard.ValidatorManager.FullValidation() => {isValid}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
        }

        static void AdvanceDemo()
        {
            var manager = new Advance.ValidatorManager();
            bool isValid;

            isValid = manager.BasicValidation(new Advance.Validators.ValidateContext { Amount = validAmount, Email = validEmail });
            Console.WriteLine($"Advance.ValidatorManager.BasicValidation() => {isValid}");

            isValid = manager.FullValidation(new Advance.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = validCountry });
            Console.WriteLine($"Advance.ValidatorManager.FullValidation() => {isValid}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
        }

        static void ComplexDemo()
        {
            var manager = new Complex.ValidatorManager();
            bool isValid;

            isValid = manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = validAmount, Email = validEmail },
                                              new Complex.IndividualValidators.ValidateContext() { Foo = validFoo });
            Console.WriteLine($"Complex.ValidatorManager.BasicValidation() => {isValid}");

            isValid = manager.FullValidation(new Complex.ChainValidators.ValidateContext { Amount = validAmount, Email = validEmail, Country = validCountry },
                                             new Complex.IndividualValidators.ValidateContext() { Foo = validFoo, Bar = validBar });
            Console.WriteLine($"Complex.ValidatorManager.FullValidation() => {isValid}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();

        }
    }
}
