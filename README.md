# Austrlian EPG
Provides API fetcher for Free to Air TV Channels and Shows for Australia. Has the ability to fetch the channels for a particular Free to Air TV region, including all the shows for that chanell and show metadata. As required by the ACMA, today and the next six days of scheduling information is availbale.

This library requires the use a internet connection and .Net 4.6.1. When getting the guide with show metadata it may take some time. Personally takes about 1:30 mins to retrieve all the data.

## How to Use
Once you have referenced the DLL in your project. You will need to use the library inside the classes.
```C#
using AustraliaEPG;
```
To then use the library, you will need to access the Guide class. There is a static method which you use for everything.
```C#
List<Channel> guideInformation = Guide.getGuide(region, timezone, dayOfWeek, showMetaData);
```

- Region - is the area of Australia which you would like to get the guide from. By using the Regions class you can see every region.
- TimeZone - is the timezone in IANA format. The AustraliaTimeZone class provides static members for these. 
- Day of the Week - is the three letter abbreviation of the day. The DayOfWeek class provides static members for these.
- ShowMetaData - is optional. Default value is true. If set to false, the library will not get Show Meta data.

Example of getting Canberra's Free to Air guide based off the Australia/Sydney timezone on Monday.
```
List<Channel> guideInformation = Guide.getGuide(Regions.Canberra, AustraliaTimeZone.EASTERN_TIME, DayOfWeek.MONDAY);
```

## Regions
### New South Wales
- Sydney
- Broken Hill
- Central Coast
- Coffs Harbour
- Griffith
- Lismore
- Newcastle
- Orange/Dubbo
- Remote and Central
- South Coast
- Tamworth
- Taree/Port Macquarie
- Wagga Wagga
- Wollongong

### Victora
- Melbourne
- Albury/Wodonga
- Ballarat
- Geelong
- Gippsland
- Muldura/Sunraysia
- Shepparton

### South Australia
- Adelaide
- Port Augusta
- Remote and Central
- Riverland
- South East SA
- Spencer Gulf

### Queensland
- Brisbane
- Vairns
- Gold Coast
- Mackay
- Remote and Central
- Rockhampton
- Sunshine Coast
- Toowoomba
- Townsville
- Wide Bay

### Western Australia
- Perth
- Albany
- Bunbury
- Mandurah
- Regional WA

### Australian Capital Territory
- Canberra

### Northern Territory
- Darwin
- Regional NT

### Tasmania
- Hobart
- Launceston

## Timezones
The EPG Fetcher requires the use of IANA Time Zones. By changing the timezone, it will get the shows that will be showing during the day selected of that timezone for the channels. A helper class is available for commonn Australia timezones.

```C#
AustraliaTimeZone.EASTERN_TIME; //Based on Australia/Sydney
AustraliaTimeZone.CENTRAL_TIME; //Based on Australia/Adelaide
AustraliaTimeZone.WESTERN_TIME; // Based on Australia/Perth
```

## Days of the week
Days of the week are done in a lowercase three letter abbreviations
- mon
- tue
- wed
- thu
- fri
- sat
- sun

##Show Meta Data
All these values can be accessed from the Show class.
- Title: string
- Time: string
- Duration: int (in minutes)
- Series: boolean
- Classification: Classification
- Warnings: string
- Movie: boolean
- YearProduced: int
- Country: string
- Language: string
- SeriesNumber: int
- EpisodeNumber: int
- EpisodeTitle: string
- Director: string
- MainCast: string[]
- NewEpisode: boolean
- Premiere: boolean
- Repeat: boolean
- Final: boolean
- SeriesReturn: boolean
- Live: boolean
- HighDefinition: boolean
- Colour: boolean
- ClosedCaptions: boolean
- Synopsis: string

## Classification
By obtaining Show MetaData, some shows recieve a Australian Classification. You may get any of the following values for the these:
- G
- PG
- M
- MA
- R
- X
- Other (Used a Default for all shows which don't have a rating or have a rating not recongised by this library)