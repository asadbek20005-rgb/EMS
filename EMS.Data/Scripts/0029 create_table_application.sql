
create table my.application(
id serial primary key,
type varchar(20),
status varchar(20),
description text null,



employee_id uuid not null references my.employee(id),
from_approved_user_id uuid not null references my.sys_user(id),
approved_date TIMESTAMP without TIME ZONE,

application_type_id INTEGER not NULL REFERENCES info.info_application_type(id),
created_date TIMESTAMP without TIME ZONE DEFAULT current TIMESTAMP,
updated_date TIMESTAMP without TIME ZONE
)
