CREATE TABLE if not exists my.contract (
    id SERIAL PRIMARY KEY,
    contract_type_id INTEGER NOT NULL REFERENCES info.info_contract_type(id),
    user_id UUID NOT NULL REFERENCES my.sys_user(id),
    salary_id INTEGER NOT NULL REFERENCES info.info_salary(id),  
    created_date TIMESTAMP WITHOUT TIME ZONE DEFAULT CURRENT_TIMESTAMP,
    updated_date TIMESTAMP WITHOUT TIME ZONE
);