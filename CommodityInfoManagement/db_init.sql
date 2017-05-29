/* 
	Database initialization script for Commodity Infomation Management
	Author: Xiangyi Meng
	Date: 5/28/2017
*/

USE commodity;

-- Table: Authority (comm_authority)
create table comm_authority(    
	auth_id smallint unsigned primary key auto_increment, 
	auth_name varchar(24) not null unique
)engine=innodb;  

-- Table: Role (comm_role)
create table comm_role(  
    role_id smallint unsigned primary key auto_increment,
    role_name varchar(24) not null unique
)engine=innodb;

-- Table: Role Authority (comm_role_authority)
create table comm_role_authority(    
    role_id smallint unsigned,
    auth_id smallint unsigned,
    primary key(role_id,auth_id), 
    foreign key(role_id) references comm_role(role_id),
    foreign key(auth_id) references comm_authority(auth_id)
)engine=innodb; 

-- Table: User (comm_user)
create table comm_user(
	user_id smallint unsigned auto_increment primary key,
    username varchar(32) not null unique,
    password char(40) not null,
    create_time datetime not null
)engine=innodb;

-- Table: User Role (comm_user_role)
create table comm_user_role(
	user_id smallint unsigned,
    role_id smallint unsigned,
    primary key(user_id, role_id),
    foreign key(user_id) references comm_user(user_id),
    foreign key(role_id) references comm_role(role_id)
)engine=innodb;

-- Table: Commodity Category (comm_category)
create table comm_category(
	category_id smallint unsigned auto_increment primary key,
    category_name varchar(20) not null
)engine=innodb;

-- Table: Commodity Infomation (comm_info)
create table comm_info(
	comm_id smallint auto_increment primary key, 
	comm_name varchar(255) not null, 
	comm_category_id smallint unsigned not null, 
    comm_owner_id smallint unsigned not null,
    comm_image longblob not null,
    comm_length int,
    comm_width int,
    comm_height int,
    comm_weight int,
    comm_color varchar(20),
    comm_shape varchar(20),
    comm_description varchar(255),
    foreign key(comm_owner_id) references comm_user(user_id),
    foreign key(comm_category_id) references comm_category(category_id)
)engine=innodb;

-- Table: Commodity Storage Rack (comm_storage_rack)
create table comm_storage_rack(
	comm_id smallint not null,
    comm_stock_amount int not null,
    comm_unit_price float not null,
    foreign key(comm_id) references comm_info(comm_id)
    on delete cascade on update cascade
)engine=innodb;

-- Table: Commodity Not Stored (comm_not_stored)
create table comm_not_stored(
	comm_id smallint not null,
    comm_remaining_amount int not null,
    foreign key(comm_id) references comm_info(comm_id)
    on delete cascade on update cascade
);

-- Insert authority
insert into comm_authority
values(null, 'READ');

insert into comm_authority
values(null, 'MODIFY');

insert into comm_authority
values(null, 'DELETE');

insert into comm_authority
values(null, 'FULL_CONTROL');

insert into comm_authority
values(null, 'MODIFY_NORMAL_USER');

insert into comm_authority
values(null, 'MODIFY_ADMIN');
-- Insert authority

-- Insert role
insert into comm_role
values(null, 'CUSTOMER');

insert into comm_role
values(null, 'SHOPKEEPER');

insert into comm_role
values(null, 'ADMIN');

insert into comm_role
values(null, 'SUPER_USER');
-- Insert role

-- Insert role's authority
insert into comm_role_authority
values(1, 1), (1, 2);

insert into comm_role_authority
values(2, 1), (2, 2), (2, 3), (2, 4);

insert into comm_role_authority
values(3, 1), (3, 2), (3, 3), (3, 4), (3, 5);

insert into comm_role_authority
values(4, 1), (4, 2), (4, 3), (4, 4), (4, 5), (4, 6);
-- Insert role's authority

-- Insert superuser
insert into comm_user
values(null, 'su', sha1('mxylls123!@#'), now());

insert into comm_user_role
values(1, 4);
-- Insert superuser
