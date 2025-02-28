create table info.info_compliment_type(
id serial primary key,
is_public boolean default false,
is_read boolean default false,
created_date TIMESTAMP without TIME ZONE DEFAULT current TIMESTAMP,
updated_date TIMESTAMP without TIME ZONE
);
