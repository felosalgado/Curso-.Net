//POST / restaurants / italian / orders HTTP
{
    "order": [
        {
            "item": "pizza",
            "quantity": 1
        }
    ]
}
//HTTP 1.1 201 CREATED
{
    "order": [
        {
            "orderNo": "123456",
            "item": "pizza",
            "toppings": [
                "pepperoni",
                "extra cheese"
            ],
            "quantity": 1
        }
    ],
        "total": "$15.00"
}
//--------------------------------------------------------------------
//    POST / restaurants / chinese / orders HTTP
{
    "order": [
        {
            "item": "fried rice",
            "quantity": 1
        }
    ]
}
//HTTP 1.1 201 CREATED
{
    "order": [
        {
            "orderNo": "AW76W09",
            "item": "fried rice",
            "quantity": 1
        }
    ],
        "total": "$2.50"
}
//--------------------------------------------------------------------
//    PUT / restaurants / italian / orders / 123456 HTTP
{
    "order": [
        {
            "items": [
                {
                    "item": "pizza",
                    "toppings": [
                        "pepperoni",
                        "extra cheese",
                        "olives",
                        "anchovies"
                    ],
                    "quantity": 2
                }
            ]
        }
    ]
}
//HTTP 1.1 200 OK
{
    "order": [
        {
            "items": [
                {
                    "item": "pizza",
                    "toppings": [
                        "pepperoni",
                        "extra cheese",
                        "olives",
                        "anchovies"
                    ],
                    "quantity": 2
                }
            ]
        }
    ],
        "orderNo": "123456",
            "total": "$34.00"
}
//--------------------------------------------------------------------
//    POST / restaurants / indian / orders HTTP
{
    "order": [
        {
            "items": [
                {
                    "item": "curry",
                    "quantity": 1
                },
                {
                    "item": "poppadoms",
                    "quantity": 2
                }
            ]
        }
    ]
}
/*HTTP 1.1 201 CREATED*/
{
    "order": [
        {
            "items": [
                {
                    "item": "curry",
                    "quantity": 1
                },
                {
                    "item": "poppadoms",
                    "quantity": 2
                }
            ]
        }
    ],
        "orderNo": "89GY7QW8",
            "total": "$5.60"
}
//--------------------------------------------------------------------
//    DELETE / restaurants / indian / orders / 89GY7QW8 HTTP
//HTTP 1.1 204 NOCONTENT