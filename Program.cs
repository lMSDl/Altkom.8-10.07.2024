using Altkom._8_10._07._2024.DesignPrinciples;

var service = new PaymentService();

var customerId = 1;

service.Fund(customerId, 500);
if (service.Charge(customerId, 100))
    Console.WriteLine($"Customer {customerId} charged. Actual balance: {service.GetBalance(customerId)}");
else
    Console.WriteLine($"Not enought founds on customer {customerId} acconut! Actual balance: {service.GetBalance(customerId)}");