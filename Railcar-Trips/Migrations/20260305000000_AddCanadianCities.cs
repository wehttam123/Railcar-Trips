using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railcar_Trips.Migrations
{
    /// <inheritdoc />
    public partial class AddCanadianCities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SET IDENTITY_INSERT [Cities] ON;

                INSERT INTO [Cities] (CityId, CityName, TimeZone, Country, CreatedDate)
                SELECT v.CityId, v.CityName, v.TimeZone, N'Canada', GETUTCDATE()
                FROM (VALUES
                    (1,  N'Vancouver',            N'Pacific Standard Time'),
                    (2,  N'Victoria',             N'Pacific Standard Time'),
                    (3,  N'Kelowna',              N'Pacific Standard Time'),
                    (4,  N'Kamloops',             N'Pacific Standard Time'),
                    (5,  N'Prince George',        N'Pacific Standard Time'),
                    (6,  N'Calgary',              N'Mountain Standard Time'),
                    (7,  N'Edmonton',             N'Mountain Standard Time'),
                    (8,  N'Lethbridge',           N'Mountain Standard Time'),
                    (9,  N'Red Deer',             N'Mountain Standard Time'),
                    (10, N'Fort McMurray',        N'Mountain Standard Time'),
                    (11, N'Regina',               N'Canada Central Standard Time'),
                    (12, N'Saskatoon',            N'Canada Central Standard Time'),
                    (13, N'Moose Jaw',            N'Canada Central Standard Time'),
                    (14, N'Brandon',              N'Central Standard Time'),
                    (15, N'Winnipeg',             N'Central Standard Time'),
                    (16, N'Thunder Bay',          N'Eastern Standard Time'),
                    (17, N'Sault Ste. Marie',     N'Eastern Standard Time'),
                    (18, N'Sudbury',              N'Eastern Standard Time'),
                    (19, N'North Bay',            N'Eastern Standard Time'),
                    (20, N'Barrie',               N'Eastern Standard Time'),
                    (21, N'Toronto',              N'Eastern Standard Time'),
                    (22, N'Mississauga',          N'Eastern Standard Time'),
                    (23, N'Hamilton',             N'Eastern Standard Time'),
                    (24, N'London',               N'Eastern Standard Time'),
                    (25, N'Kitchener',            N'Eastern Standard Time'),
                    (26, N'Windsor',              N'Eastern Standard Time'),
                    (27, N'St. Catharines',      N'Eastern Standard Time'),
                    (28, N'Oshawa',               N'Eastern Standard Time'),
                    (29, N'Kingston',             N'Eastern Standard Time'),
                    (30, N'Ottawa',               N'Eastern Standard Time'),
                    (31, N'Gatineau',             N'Eastern Standard Time'),
                    (32, N'Montreal',             N'Eastern Standard Time'),
                    (33, N'Quebec City',          N'Eastern Standard Time'),
                    (34, N'Sherbrooke',           N'Eastern Standard Time'),
                    (35, N'Trois-Rivières',       N'Eastern Standard Time'),
                    (36, N'Saguenay',             N'Eastern Standard Time'),
                    (37, N'Rimouski',             N'Eastern Standard Time'),
                    (38, N'Edmundston',           N'Atlantic Standard Time'),
                    (39, N'Fredericton',          N'Atlantic Standard Time'),
                    (40, N'Moncton',              N'Atlantic Standard Time'),
                    (41, N'Saint John',           N'Atlantic Standard Time'),
                    (42, N'Bathurst',             N'Atlantic Standard Time'),
                    (43, N'Charlottetown',        N'Atlantic Standard Time'),
                    (44, N'Summerside',           N'Atlantic Standard Time'),
                    (45, N'Sydney',               N'Atlantic Standard Time'),
                    (46, N'Truro',                N'Atlantic Standard Time'),
                    (47, N'New Glasgow',          N'Atlantic Standard Time'),
                    (48, N'Dartmouth',            N'Atlantic Standard Time'),
                    (49, N'Halifax',              N'Atlantic Standard Time')
                ) AS v(CityId, CityName, TimeZone)
                WHERE NOT EXISTS (SELECT 1 FROM [Cities] WHERE CityId = v.CityId);

                SET IDENTITY_INSERT [Cities] OFF;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM [Cities] WHERE CityId BETWEEN 1 AND 49;
            ");
        }
    }
}
