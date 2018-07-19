namespace ValidatorManager.Standard.Validators
{
    public class CountryValidator : Validator
    {
        public override bool Validate(ValidateContext context)
        {
            return context.Country == "Taiwan";
        }
    }
}
