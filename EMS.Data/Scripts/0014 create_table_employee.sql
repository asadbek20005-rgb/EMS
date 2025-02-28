 CREATE Table my.employee
    (
        id SERIAL PRIMARY KEY,
        user_id UUID not NULL REFERENCES my.sys_user(id),
        organization_id INTEGER not NULL REFERENCES info.info_organization(id),
        job_type_id INTEGER not NULL REFERENCES info.info_job_type(id),
        job_level_id INTEGER not NULL REFERENCES info.info_job_level(id),
        salary_id    INTEGER not NULL REFERENCES info.info_salary(id),
        country_id INTEGER NOT NULL REFERENCES info.info_country(id),
        city_id INTEGER NOT NULL REFERENCES info.info_city(id),
        district_id  INTEGER NOT NULL REFERENCES info.info_district(id),
        created_date TIMESTAMP without TIME ZONE DEFAULT current_TIMESTAMP,
        created_user_id UUID NOT NULL,
        updated_date TIMESTAMP without TIME ZONE,
        modified_user_id UUID  NULL
    );