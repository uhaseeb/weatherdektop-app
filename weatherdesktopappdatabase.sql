create database weather_test;
use weather_test;
create table dailyweather_table(
City_name varchar(30) primary key not null,
Temperature_C varchar(30),
Temperature_F varchar(30),
Humidity varchar(30),
Pressure varchar(30),
Wind_speed varchar(30)
);
alter table dailyweather_table add Weather_Con varchar(30);
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Abbottabad';
update dailyweather_table set Weather_Con = 'Sunny' where City_name = 'Bahawalpur';
update dailyweather_table set Weather_Con = 'Rainy' where City_name = 'Dera Ghazi Khan';
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Faisalabad';
update dailyweather_table set Weather_Con = 'Sunny' where City_name = 'Gilgit';
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Gujrat';
update dailyweather_table set Weather_Con = 'Rainy' where City_name = 'Gwadar';
update dailyweather_table set Weather_Con = 'Sunny' where City_name = 'Islamabad';
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Jhelum';
update dailyweather_table set Weather_Con = 'Rainy' where City_name = 'Karachi';
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Lahore';
update dailyweather_table set Weather_Con = 'Sunny' where City_name = 'Multan';
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Okara';
update dailyweather_table set Weather_Con = 'Rainy' where City_name = 'Peshawar';
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Quetta';
update dailyweather_table set Weather_Con = 'Sunny' where City_name = 'Rahim Yar Khan';
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Sialkot';
update dailyweather_table set Weather_Con = 'Rainy' where City_name = 'Sibbi';
update dailyweather_table set Weather_Con = 'Sunny' where City_name = 'Sukkur';
update dailyweather_table set Weather_Con = 'Mostly Cloudy' where City_name = 'Swat';

create table weeklyweather_table(
W_City varchar(50) primary key not null, 
Sat_tempC varchar(30),
Sat_tempF varchar(30),
Sun_tempC varchar(30),
Sun_tempF varchar(30),
Mon_tempC varchar(30),
Mon_tempF varchar(30),
Tue_tempC varchar(30),
Tue_tempF varchar(30),
Wed_tempC varchar(30),
Wed_tempF varchar(30),
Thu_tempC varchar(30),
Thu_tempF varchar(30),
Fri_tempC varchar(30),
Fri_tempF varchar(30)
);

select * from dailyweather_table;

insert into dailyweather_table values('Lahore', '15°C', '59°F', '87%', '30.09 Hg', '0 km/h')
insert into dailyweather_table values('Karachi', '24°C', '61°F', '42%', '30.07 Hg', '11 km/h')
insert into dailyweather_table values('Islamabad', '08°C', '46°F', '78%', '30.13 Hg', '14 km/h')
insert into dailyweather_table values('Multan', '09°C', '48°F', '81%', '30.14 Hg', '0 km/h')
insert into dailyweather_table values('Bahawalpur', '11°C', '51°F', '81%', '30.07 Hg', '3 km/h')
insert into dailyweather_table values('Peshawar', '08°C', '46°F', '63%', '30.15 Hg', '10 km/h')
insert into dailyweather_table values('Quetta', '-3°C', '27°F', '49%', '30.03 Hg', '3 km/h')
insert into dailyweather_table values('Gilgit', '-2°C', '29°F', '73%', '30.00 Hg', '2 km/h')
insert into dailyweather_table values('Faisalabad', '09°C', '49°F', '8%', '30.06 Hg', '5 km/h')
insert into dailyweather_table values('Gujrat', '13°C', '55.4°F', '98%', '30.03 Hg', '23 km/h')
insert into dailyweather_table values('Abbottabad', '05°C', '41°F', '100%', '30.05 Hg', '10 km/h')
insert into dailyweather_table values('Rahim Yar Khan', '10°C', '50°F', '74%', '30.19 Hg', '0 km/h')
insert into dailyweather_table values('Dera Ghazi Khan', '12°C', '54°F', '72%', '30.06 Hg', '5 km/h')
insert into dailyweather_table values('Sukkur', '16°C', '60.8°F', '64%', '30.04 Hg', '0 km/h')
insert into dailyweather_table values('Okara', '15°C', '60.8°F', '96%', '30.10 Hg', '5 km/h')
insert into dailyweather_table values('Swat', '-5°C', '24.8°F', '90%', '30.19 Hg', '5 km/h')
insert into dailyweather_table values('Gwadar', '20°C', '68°F', '24%', '30.03 Hg', '13 km/h')
insert into dailyweather_table values('Sialkot', '13°C', '55.4°F', '87%', '30.09 Hg', '0 km/h')
insert into dailyweather_table values('Jhelum', '13°C', '55.4°F', '100%', '30.09 Hg', '8 km/h')
insert into dailyweather_table values('Sibbi', '15°C', '59°F', '41%', '30.04 Hg', '3 km/h')


select * from weeklyweather_table;
insert into weeklyweather_table values('Lahore','11°C','52°F','12°C','54°F','13°C','56°F','12°C','54°F','11°C','53°F','13°C','55°F','10°C','50°F')
insert into weeklyweather_table values('Karachi','12°C','54°F','13°C','55.4°F','13°C','55.4°F','14°C','57.9°F','11°C','51.8°F','13°C','55.4°F','11°C','51.8°F')
insert into weeklyweather_table values('Islamabad','10°C','50°F','10°C','5°F','09°C','48.2°F','09°C','48.2°F','08°C','46.4°F','08°C','46.4°F','11°C','51.8°F')
insert into weeklyweather_table values('Multan','11°C','51.8°F','12°C','54°F','11°C','51.8°F','11°C','51.8°F','10°C','50°F','10°C','50°F','10°C','50°F')
insert into weeklyweather_table values('Bahawalpur','11°C','51.8°F','12°C','54°F','13°C','55.4°F','14°C','57.9°F','14°C','57.9°F','15°C','59°F','13°C','55.4°F')
insert into weeklyweather_table values('Peshawar','10°C','50°F','10°C','50°F','08°C','46.4°F','08°C','46.4°F','09°C','48.2°F','11°C','51.8°F','10°C','50°F')
insert into weeklyweather_table values('Quetta','-02°C','28.4°F','-03°C','26.6°F','-01°C','32°F','-02°C','28.4°F','-02°C','28.4°F','0°C','32°F','0°C','32°F')
insert into weeklyweather_table values('Gilgit','-03°C','26.6°F','-02°C','28.4°F','-01°C','30.2°F','0°C','32°F','0°C','32°F','-04°C','24.8°F','-04°C','24.8°F')
insert into weeklyweather_table values('Faisalabad','10°C','50°F','11°C','51.8°F','10°C','51.8°F','12°C','54°F','10°C','50°F','12°C','54°F','11°C','51.8°F')
insert into weeklyweather_table values('Gujrat','10°C','50°F','10°C','50°F','11°C','51.8°F','12°C','54°F','13°C','55.4°F','13°C','55.4°F','11°C','51.8°F')
insert into weeklyweather_table values('Abbottabad','05°C','41°F','04°C','39.2°F','04°C','39.2°F','03°C','37.4°F','02°C','35.6°F','01°C','35.8°F','01°C','35.8°F')
insert into weeklyweather_table values('Rahim Yar Khan','10°C','50°F','11°C','51.8°F','11°C','51.8°F','12°C','54°F','12°C','54°F','13°C','55.4°F','10°C','50°F')
insert into weeklyweather_table values('Dera Ghazi Khan','12°C','54°F','13°C','55.4°F','13°C','55.4°F','14°C','57.9°F','14°C','57.9°F','15°C','59°F','15°C','55°F')
insert into weeklyweather_table values('Sukkur','15°C','59°F','14°C','57.9°F','14°C','57.9°F','15°C','59°F','15°C','59°F','16°C','60.6°F','16°C','60.8°F')
insert into weeklyweather_table values('Okara','15°C','59°F','14°C','57.9°F','13°C','55.4°F','12°C','54°F','13°C','55.4°F','15°C','59°F','15°C','59°F')
insert into weeklyweather_table values('Swat','-5°C','24.8°F','-4°C','24.8°F','-4°C','24.8°F','-3°C','26.6°F','-3°C','26.6°F','-4°C','24.8°F','-2°C','28.4°F')
insert into weeklyweather_table values('Gwadar','20°C','68°F','20°C','68°F','21°C','69.8°F','22°C','71.6°F','22°C','71.6°F','19°C','66.2°F','22°C','71.6°F')
insert into weeklyweather_table values('Sialkot','13°C','55.4°F','12°C','54°F','14°C','57.9°F','14°C','57.9°F','13°C','55.4°F','14°C','57.9°F','16°C','60.8°F')
insert into weeklyweather_table values('Jhelum','12°C','54°F','12°C','54°F','13°C','55.4°F','14°C','57.9°F','14°C','57.9°F','13°C','55.4°F','11°C','51.8°F')
insert into weeklyweather_table values('Sibbi','15°C','59°F','14°C','57.9°F','13°C','55.4°F','13°C','55.4°F','14°C','57.9°F','14°C','57.9°F','15°C','59°F')

select * from dailyweather_table;