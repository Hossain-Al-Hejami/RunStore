INSERT INTO Customers(
    id,
    firstName,
    lastName,
    email,
    phone,
    addressLine,
    postalCode,
    city
)
VALUES
(
    '6639cea1-10db-416b-9e06-4f75e3b6b7fe',
    'Michael',
    'Gustavsson',
    'michael@mail.com',
    '0701-11 11 11',
    'Strandvägen 1',
    '444 12',
    'Byn'
),
(
    '21bcb6b4-3c96-4c59-b833-f5b3fa57f6c5',
    'Oskar',
    'Person',
    'oskar@mail.com',
    '0701-11 11 11',
    'Strandvägen 2',
    '444 12',
    'Byn'
),
(
    '3a9410da-f6de-4c17-bc7f-11d16ebd7bf5',
    'Helene',
    'Persson',
    'helene@mail.com',
    '0701-11 11 11',
    'Strandvägen 3',
    '444 12',
    'Byn'
),
(
    'a73cfd4d-78c3-4f7e-9f74-1c98f4f889fc',
    'Bosse',
    'Kofot',
    'bosse@mail.com',
    '0701-11 11 11',
    'Strandvägen 4',
    '444 12',
    'Byn'
),
(
    '91c8143e-e9c7-498a-b887-57ba29dc8cf3',
    'Lena',
    'Karlsson',
    'lena@mail.com',
    '0701-11 11 11',
    'Strandvägen 5',
    '444 12',
    'Byn'
);

-- Add products 
INSERT INTO Products(
id,
itemNumber,
name,
imageUrl,
description,
supplier,
price
)
VALUES(
    '234d1eaaa87149429b0bbd6e8dc759c0',
    '1000',
    'Core 2000',
    'https://res.cloudinary.com/softtech-dev/image/upload/v1786556514/shoe-1_qig4ut.jpg',
    'Lorem ipsum dolor sit amet, consectetuer adipiscing',
    'Asics',
    1295
),
(
    '40f6e853ffb2424bb3eb652ba03576f2',
    '1002',
    'Gel 27',
    'https://res.cloudinary.com/softtech-dev/image/upload/v1786556530/shoe-3_qbzcwy.jpg',
    'Lorem ipsum dolor sit amet, consectetuer adipiscing',
    'Asics',
    2295
),
(
    '7a62c46d3a4b4ac4a4133ba66e47b6ec',
    '1009',
    'Jacket',
    'https://res.cloudinary.com/softtech-dev/image/upload/v1786556497/jacket-1_rio6db.jpg',
    'Lorem ipsum dolor sit amet, consectetuer adipiscing',
    'CLN Athletics',
    1495
);

-- Add Orders
INSERT INTO Orders(
id,
orderDate
) 
VALUES (
    '7a62c46d3a4b4ac4a4133ba66e47b6AC',
    '2026-10-20 10:30:15'
),
(
    '53gfc46d3a4b4ac4a4133ba66e47b6ec',
    '2026-10-21 14:45:30'
);
