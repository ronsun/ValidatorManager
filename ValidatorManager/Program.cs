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
        private static decimal invalidAmount = 10;

        private static string validEmail = "ron.sun@mailserver.com";
        private static string invalidEmail = "a";

        private static string validCountry = "Taiwan";
        private static string invalidCountry = "a";

        private static string validFoo = "Foo";
        private static string inValidFoo = "a";

        private static string validBar = "Bar";
        private static string inValidBar = "a";

        static void Main(string[] args)
        {
            BasicDemo();
            SimpleDemo();
            StandardDemo();
            AdvanceDemo();
            ComplexDemo();
            Console.ReadLine();
        }

        static void BasicDemo()
        {
            var manager = new Basic.ValidatorManager();

            Console.WriteLine($"Basic.ValidatorManager.BasicValidation() => ");
            Console.WriteLine($"isValid: {manager.BasicValidation(invalidAmount, validEmail)}");
            Console.WriteLine($"isValid: {manager.BasicValidation(validAmount, invalidEmail)}");
            Console.WriteLine($"isValid: {manager.BasicValidation(validAmount, validEmail)}");

            Console.WriteLine();

            Console.WriteLine($"Basic.ValidatorManager.FullValidation() => ");
            Console.WriteLine($"isValid: {manager.FullValidation(invalidAmount, validEmail, validCountry)}");
            Console.WriteLine($"isValid: {manager.FullValidation(validAmount, invalidEmail, validCountry)}");
            Console.WriteLine($"isValid: {manager.FullValidation(validAmount, validEmail, invalidCountry)}");
            Console.WriteLine($"isValid: {manager.FullValidation(validAmount, validEmail, validCountry)}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();

        }

        static void SimpleDemo()
        {
            var manager = new Simple.ValidatorManager();

            Console.WriteLine($"Simple.ValidatorManager.BasicValidation() => ");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Simple.Validators.ValidateContext { Amount = invalidAmount, Email = validEmail })}");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Simple.Validators.ValidateContext { Amount = validAmount, Email = invalidEmail })}");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Simple.Validators.ValidateContext { Amount = validAmount, Email = validEmail })}");

            Console.WriteLine();

            Console.WriteLine($"Simple.ValidatorManager.FullValidation() => ");
            Console.WriteLine($"isValid: {manager.FullValidation(new Simple.Validators.ValidateContext { Amount = invalidAmount, Email = validEmail, Country = validCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Simple.Validators.ValidateContext { Amount = validAmount, Email = invalidEmail, Country = validCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Simple.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = invalidCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Simple.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = validCountry })}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
        }

        static void StandardDemo()
        {
            var manager = new Standard.ValidatorManager();

            Console.WriteLine($"Standard.ValidatorManager.BasicValidation() => ");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Standard.Validators.ValidateContext { Amount = invalidAmount, Email = validEmail })}");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Standard.Validators.ValidateContext { Amount = validAmount, Email = invalidEmail })}");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Standard.Validators.ValidateContext { Amount = validAmount, Email = validEmail })}");

            Console.WriteLine();

            Console.WriteLine($"Standard.ValidatorManager.FullValidation() => ");
            Console.WriteLine($"isValid: {manager.FullValidation(new Standard.Validators.ValidateContext { Amount = invalidAmount, Email = validEmail, Country = validCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Standard.Validators.ValidateContext { Amount = validAmount, Email = invalidEmail, Country = validCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Standard.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = invalidCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Standard.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = validCountry })}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
        }

        static void AdvanceDemo()
        {
            var manager = new Advance.ValidatorManager();

            Console.WriteLine($"Advance.ValidatorManager.BasicValidation() => ");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Advance.Validators.ValidateContext { Amount = invalidAmount, Email = validEmail })}");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Advance.Validators.ValidateContext { Amount = validAmount, Email = invalidEmail })}");
            Console.WriteLine($"isValid: {manager.BasicValidation(new Advance.Validators.ValidateContext { Amount = validAmount, Email = validEmail })}");

            Console.WriteLine();

            Console.WriteLine($"Advance.ValidatorManager.FullValidation() => ");
            Console.WriteLine($"isValid: {manager.FullValidation(new Advance.Validators.ValidateContext { Amount = invalidAmount, Email = validEmail, Country = validCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Advance.Validators.ValidateContext { Amount = validAmount, Email = invalidEmail, Country = validCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Advance.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = invalidCountry })}");
            Console.WriteLine($"isValid: {manager.FullValidation(new Advance.Validators.ValidateContext { Amount = validAmount, Email = validEmail, Country = validCountry })}");

            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();
        }

        static void ComplexDemo()
        {
            var manager = new Complex.ValidatorManager();

            Console.WriteLine("Complex.ValidatorManager.BasicValidation() => ");
            Console.WriteLine("isValid: " +
                                manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = invalidAmount, Email = validEmail },
                                                        new Complex.IndividualValidators.ValidateContext() { Foo = validFoo }));
            Console.WriteLine("isValid: " +
                                manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = validAmount, Email = invalidEmail },
                                                        new Complex.IndividualValidators.ValidateContext() { Foo = validFoo }));
            Console.WriteLine("isValid: " +
                                manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = validAmount, Email = validEmail },
                                                        new Complex.IndividualValidators.ValidateContext() { Foo = inValidFoo }));
            Console.WriteLine("isValid: " +
                                manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = invalidAmount, Email = invalidEmail },
                                                        new Complex.IndividualValidators.ValidateContext() { Foo = validFoo }));
            Console.WriteLine("isValid: " +
                                manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = invalidAmount, Email = validEmail },
                                                        new Complex.IndividualValidators.ValidateContext() { Foo = inValidFoo }));
            Console.WriteLine("isValid: " +
                                manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = validAmount, Email = invalidEmail },
                                                        new Complex.IndividualValidators.ValidateContext() { Foo = inValidFoo }));
            Console.WriteLine("isValid: " +
                                manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = invalidAmount, Email = invalidEmail },
                                                        new Complex.IndividualValidators.ValidateContext() { Foo = inValidFoo }));
            Console.WriteLine("isValid: " +
                                manager.BasicValidation(new Complex.ChainValidators.ValidateContext { Amount = validAmount, Email = validEmail },
                                                        new Complex.IndividualValidators.ValidateContext() { Foo = validFoo }));

            Console.WriteLine();

            // to much scanario, skip...
            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine();

        }
    }
}
