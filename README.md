# ValidatorManager

## Basic
Basic design  
+ Put all functions for validation in a single class.

## Simple
Simple design  
+ An abstract class for validator.
+ A series of derived classes implement abstract method defined in base class.
+ Collect all parameters to a single class.

## Standard
Standard design
+ Similar with simple scenario.
+ Chain of responsibility parttern like.
+ Used for validation chain.

## Advance
Advance design
+ Similar with standard design.
+ A hook method `DerivedValidation`.
+ Put behavior not for validate in base class.
+ Less duplicate code in derived classes.

## Complex
Complex design
+ Gather advance design and simple design.
+ Also applicable for multiple validators.
+ Used for scenarios with very complex
  - Do some validations and react for validation result , then do a seires of validations.
  - For muptiple base validators.
