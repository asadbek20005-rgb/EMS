create table my.compliment(
id serial primary key,
details text not null,

from_user_id uuid not null references my.sys_user(id),
to_user_id uuid not null references my.sys_user(id),
compliment_type_id integer not null references info.info_compliment_type(id),
created_date TIMESTAMP without TIME ZONE DEFAULT current TIMESTAMP,
updated_date TIMESTAMP without TIME ZONE
);
