# Ex-TaxPayer
C# exercise using abstract methods.

Make a program to read data from N contributors (N provided by the user) which can be an individual or legal entity, and then show the
amount of tax paid by each, as well as the total tax collected.

Individuals data are: name, annual income and health expenses. Corporate data are name, annual income and number of employees.
The rules for tax calculation are as follows:

Individuals: People whose income was below 20000.00 pay 15% tax. People with income from 20000.00 onwards pay 25% tax. If the person had
health expenses, 50% These expenses are deducted from the tax.
Example: A person whose income was 50000.00 and had 2000.00 in health care, the tax is: (50000 * 25%) - (2000 * 50%) = 11500.00

Legal entity: Legal entities pay 16% tax. However, if the company has more than 10 employees, she pays 14% tax.
Example: A company whose income was 400000.00 and has 25 employees, the tax is: 400000 * 14% = 56000.00
