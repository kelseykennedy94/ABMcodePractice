<?php
class Customer {
    public $name;
    
    public function __construct($name) {
        $this->name = $name;
    }
}

class CustomerAddress {
    public $address;
    public $contact;
    
    public function __construct($address, $contact) {
        $this->address = $address;
        $this->contact = $contact;
    }
}

class DeliveryDriver {
    public $name = 'David';
    public $vehicle = 'BMW';
    public $contact = '555-1234';
}

class RestaurantAddress {
    public $name = 'McDonalds';
    public $address = '456 St';
    public $contact = '555-5678';
}

class Order {
    public $status = 'Ordered';
    public $items = ['Burger', 'Fries', 'Drink'];
    public $totalAmount = 25.99;
    
    public function acceptOrder() {
        $this->status = 'order accepted';
    }
    
    public function assignToDriver() {
        $this->status = 'Assigned to driver';
    }
    
    public function markDelivered() {
        $this->status = 'Delivered';
    }
}

$customer = new Customer('John');
$customerAddress = new CustomerAddress('123 Main St', '555-2345');
$deliveryDriver = new DeliveryDriver();
$restaurantAddress = new RestaurantAddress();
$order = new Order();

echo "Initial Order Status: " . $order->status . "\n";
echo "\nRestaurant: " . $restaurantAddress->name . " - Address: " . $restaurantAddress->address . " - Contact: " . $restaurantAddress->contact . "\n";
echo "Items Ordered: " . implode(', ', $order->items) . "\n";
echo "Total Amount: $" . $order->totalAmount . "\n";

echo "\nCustomer: " . $customer->name . "\n";
echo "Customer Address: " . $customerAddress->address . "\n";
echo "Contact: " . $customerAddress->contact . "\n";

$order->assignToDriver();
echo "\nOrder status after assigning to driver: " . $order->status . "\n";

echo "\nDelivery Driver: " . $deliveryDriver->name . "\n";
echo "Vehicle: " . $deliveryDriver->vehicle . "\n";
echo "Contact: " . $deliveryDriver->contact . "\n";

$order->markDelivered();
echo "\nFinal Order status after delivery: " . $order->status . "\n";
?>
