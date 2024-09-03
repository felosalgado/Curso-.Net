//POST / restaurants / italian / orders HTTP
{
    "order": [
        {
            "items": [
                {
                    "item": "pizza",
                    "toppings": [
                        "pepperoni",
                        "extra cheese"
                    ],
                    "quantity": 1
                }
            ]
        }
    ]
}
//HTTP 1.1 201 CREATED
{
    "response": [
        {
            "order": [
                {
                    "items": [
                        {
                            "item": "pizza",
                            "toppings": [
                                "pepperoni",
                                "extra cheese"
                            ],
                            "quantity": 1
                        }
                    ]
                }
            ],
            "orderNo": "123456",
            "total": "$17.00"
        }
    ],
        "links": [
            {
                "rel": "self",
                "href": "/restaurants/italian/orders/89GY7QW8",
                "method": "GET"
            },
            {
                "rel": "toppings",
                "href": "/restaurants/italian/toppings",
                "method": "GET"
            },
            {
                "rel": "delete_order",
                "href": "/restaurants/italian/orders/89GY7QW8",
                "method": "DELETE"
            }
        ]
}