﻿namespace ValidatorManager.ChainOfResponsibility.Validators
{
    public class AmountValidator : Validator
    {
        public override bool Validate(ValidateContext context)
        {
            if (context.Amount > 10 && context.Amount < 1000)
            {
                return NextValidator?.Validate(context) ?? true;
            }

            return false;
        }
    }
}
