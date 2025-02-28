create Table if not exists info.info_organization
(
    id            SERIAL PRIMARY KEY,
    code          VARCHAR(10)  NOT NUll,
    short_name    VARCHAR(10)  NOT NULL,
    full_name     VARCHAR(50)  NOT NULL,
    address       varchar(100) NOT NUll,
    inn           varchar(10)  not NULL UNIQUE,
    director      varchar(50)  not null,
    zip_code      varchar(15)  not null,
    phone_number  varchar(20)  not null,
    email         VARCHAR(50)  not null,
    work_schedule text null,
    detail        TEXT NULL,
    photo_url     UUID NULL,

    country_id INTEGER NOT NULL REFERENCES info.info_country(id),
    city_id INTEGER NOT NULL REFERENCES info.info_city(id),
    district_id  INTEGER NOT NULL REFERENCES info.info_district(id),
    
    created_date TIMESTAMP without TIME ZONE DEFAULT current TIMESTAMP,
    updated_date TIMESTAMP without TIME ZONE
);