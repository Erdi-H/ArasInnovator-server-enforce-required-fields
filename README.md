# ArasInnovator-server-enforce-required-fields

## Description
This project is an example of an easy and flexible way to enforce a required field from a server event, such as onBeforeAdd or onBeforeUpdate events. Since this is such a common usecase when developing on Aras I figured it would be nice to have a uniform way to always replicate.

## Next Step
The next thing I'm going to do with this project is adjust it so that with just a few lines of code we can call it from another server method. This will require just passing in the field Names and Labels through a Dict to the method but will reduce code duplication for your dev team. (https://www.aras.com/community/f/development/9206/calling-server-method-from-another-server-method)
