/*==============================================================*/
/* DBMS name:      SAP SQL Anywhere 16                          */
/* Created on:     28.04.2017 14:55:13                          */
/*==============================================================*/


drop table if exists Answer;

drop table if exists userGroup;

drop table if exists Group_info;

drop table if exists Qs_Ar;

drop table if exists Questions;

drop table if exists Roles;

drop table if exists Test;

drop table if exists Test_Pool;

drop table if exists Test_info;

drop table if exists aqUser;

drop table if exists User_info;

drop table if exists User_result;

/*==============================================================*/
/* Table: Answer                                                */
/*==============================================================*/
create table Answer 
(
   ID                   bigint                         not null,
   answer               text                           null,
   true_variant         bit                            null,
   constraint PK_ANSWER primary key clustered (ID)
);

/*==============================================================*/
/* Table: "Group"                                               */
/*==============================================================*/
create table userGroup 
(
   ID                   bigint                         not null,
   ID_info              bigint                         null,
   ID_role              bigint                         null,
   constraint PK_GROUP primary key clustered (ID)
);

/*==============================================================*/
/* Table: Group_info                                            */
/*==============================================================*/
create table Group_info 
(
   ID                   bigint                         not null,
   Name                 char(25)                       null,
   Description          text                           null,
   constraint PK_GROUP_INFO primary key clustered (ID)
);

/*==============================================================*/
/* Table: Qs_Ar                                                 */
/*==============================================================*/
create table Qs_Ar 
(
   ID_Q                 bigint                         not null,
   ID_A                 bigint                         not null,
   constraint PK_QS_AR primary key clustered (ID_Q, ID_A)
);

/*==============================================================*/
/* Table: Questions                                             */
/*==============================================================*/
create table Questions 
(
   ID                   bigint                         not null,
   Question             text                           null,
   constraint PK_QUESTIONS primary key clustered (ID)
);

/*==============================================================*/
/* Table: Roles                                                 */
/*==============================================================*/
create table Roles 
(
   ID                   bigint                         not null,
   Name                 char(25)                       null,
   allowRead                 bit                            null,
   allowWrite                bit                            null,
   Admin                bit                            null,
   constraint PK_ROLES primary key clustered (ID)
);

/*==============================================================*/
/* Table: Test                                                  */
/*==============================================================*/
create table Test 
(
   ID                   bigint                         not null,
   ID_info              bigint                         null,
   constraint PK_TEST primary key clustered (ID)
);

/*==============================================================*/
/* Table: Test_Pool                                             */
/*==============================================================*/
create table Test_Pool 
(
   ID_test              bigint                         not null,
   ID_question          bigint                         not null,
   constraint PK_TEST_POOL primary key clustered (ID_test, ID_question)
);

/*==============================================================*/
/* Table: Test_info                                             */
/*==============================================================*/
create table Test_info 
(
   ID                   bigint                         not null,
   Amount               int                            null,
   Availble             bit                            null,
   Description          text                           null,
   constraint PK_TEST_INFO primary key clustered (ID)
);

/*==============================================================*/
/* Table: "User"                                                */
/*==============================================================*/
create table aqUser
(
   ID                   bigint                         not null,
   ID_group             bigint                         null,
   ID_info              bigint                         null,
   passwd               char(32)                       null,
   constraint PK_USER primary key clustered (ID)
);

/*==============================================================*/
/* Table: User_info                                             */
/*==============================================================*/
create table User_info 
(
   ID                   bigint                         not null,
   Name                 char(50)                       null,
   Surname              char(50)                       null,
   Patronym             char(50)                       null,
   constraint PK_USER_INFO primary key clustered (ID)
);

/*==============================================================*/
/* Table: User_result                                           */
/*==============================================================*/
create table User_result 
(
   ID                   bigint                         not null,
   ID_user              bigint                         null,
   ID_test              bigint                         null,
   constraint PK_USER_RESULT primary key clustered (ID)
);

alter table userGroup
   add constraint FK_GROUP_GROUP_GRO_GROUP_IN foreign key (ID_info)
      references Group_info (ID)
      on update restrict
      on delete restrict;

alter table userGroup
   add constraint FK_GROUP_ROLES_GRO_ROLES foreign key (ID_role)
      references Roles (ID)
      on update cascade
      on delete cascade;

alter table Qs_Ar
   add constraint FK_QS_AR_REF_A_ANSWER foreign key (ID_A)
      references Answer (ID)
      on update restrict
      on delete restrict;

alter table Qs_Ar
   add constraint FK_QS_AR_REF_AR_QUESTION foreign key (ID_Q)
      references Questions (ID)
      on update restrict
      on delete restrict;

alter table Test
   add constraint FK_TEST_TEST_TEST_TEST_INF foreign key (ID_info)
      references Test_info (ID)
      on update restrict
      on delete restrict;

alter table Test_Pool
   add constraint FK_TEST_POO_Q_P_QUESTION foreign key (ID_question)
      references Questions (ID)
      on update restrict
      on delete restrict;

alter table Test_Pool
   add constraint FK_TEST_POO_T_Q_TEST foreign key (ID_test)
      references Test (ID)
      on update restrict
      on delete restrict;

alter table aqUser
   add constraint FK_USER_USER_GROU_GROUP foreign key (ID_group)
      references userGroup (ID)
      on update restrict
      on delete restrict;

alter table aqUser
   add constraint FK_USER_USER_USER_USER_INF foreign key (ID_info)
      references User_info (ID)
      on update cascade
      on delete cascade;

alter table User_result
   add constraint FK_USER_RES_T_R_TEST foreign key (ID_test)
      references Test (ID)
      on update restrict
      on delete restrict;

alter table User_result
   add constraint FK_USER_RES_U_R_USER foreign key (ID_user)
      references aqUser (ID)
      on update restrict
      on delete restrict;

