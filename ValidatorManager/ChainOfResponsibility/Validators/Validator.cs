namespace ValidatorManager.ChainOfResponsibility.Validators
{
    public abstract class Validator
    {
        public Validator NextValidator { get; set; }

        public abstract bool Validate(ValidateContext context);
    }
}
