//POST / restaurants / italian / orders HTTP
{
    "order": [
        {
            "item": "pizza",
            "quantity": 1
        }
    ]
}
//HTTP 200 OK
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
//POST / restaurants / chinese / orders HTTP
{
    "order": [
        {
            "item": "fried rice",
            "quantity": 1
        }
    ]
}
//HTTP 200 OK
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
//POST / restaurants / indian / orders HTTP
{
    "order": [
        {
            "item": "curry",
            "quantity": 1
        }
    ]
}
//HTTP 200 OK
{
    "order": [
        {
            "orderNo": "89GY7QW8",
            "item": "fried rice",
            "quantity": 1
        }
    ],
        "total": "$5.60"
}