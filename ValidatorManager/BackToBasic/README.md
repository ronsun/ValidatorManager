**Back to basic and simpler**
+ If scenario not too comlex, just back to basic.
+ Group validations into few validators.
+ Simply use `&&` and `||` in ValidatorManager instead of `List<Func<bool>>` or chain of repository.

> `&&`: rest validations will not be excuted if any false.  
> `||`: rest validations will not be excuted if any ture.  
