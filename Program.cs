using Altkom._8_10._07._2024.DesignPrinciples;

var customerId = 1;

var customersService = new CustomersService();

var customer = customersService.FingById(customerId);

if(customer is null)
{
    Console.WriteLine($"Customer {customerId} not exists");
    return;
}


var paymentService = new PaymentService();

paymentService.Fund(customer.Account, 500);
if (paymentService.Charge(customer.Account, 100))
    Console.WriteLine($"Customer {customerId} charged. Actual balance: {customer.Account.GetBalance()}");
else
    Console.WriteLine($"Not enought founds on customer {customerId} acconut! Actual balance: {customer.Account.GetBalance()}");