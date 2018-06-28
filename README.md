# migSharp-Migrations-netcore2.0

This is a quick and dirty project for setting up Mig# (https://github.com/dradovic/MigSharp) and .netcore 2.0

The ideal state is:

* Run all migrations from a custom assembly.
* Use a docker container for sql server on linux
* Make it as verbose a possible. Everytime a migration is applied, have detailed information on what is going on.

TODO:

- [ ] Add sln for grouping the migrations and the runner.
- [ ] Update project to use a docker container for the sql server on demand. Right now it is running always.
- [ ] Check the use of https://github.com/dradovic/MigSharp/tree/master/Migrate instead of the migration runner.
- [ ] Unify .vscode folders
- [ ] Setup linting for .net core
- [X] Create a list of commands for generating each project from scracth