﻿using XblApp.Infrastructure.Data;
using XblApp.Infrastructure.Data.Seeding;
using XblApp.Test;

namespace XblApp.UI.Test.Infrastructure.Seeding
{
    public class TestSeedDatabase : BaseTestClass
    {
        [Fact]
        public async Task TestSeedDatabaseIfNoGamersAsyncEmptyDatabase()
        {
            //SETUP
            using (var context = new MsSqlDbContext(_config))
            {
                //context.Database.EnsureClean();

                var callingAssemblyPath = GetCallingAssemblyTopLevelDir();
                var wwwrootDir = Path.GetFullPath(Path.Combine(callingAssemblyPath, "..\\XblApp\\wwwroot"));

                //ATTEMPT
                await context.SeedDatabaseIfNoGamersAsync(wwwrootDir);

                //VERIFY
                Assert.Equal(2, context.Gamers.Count());
            }
        }

        [Fact]
        public async Task TestSeedDatabaseIfNoGamesAsyncEmptyDatabase()
        {
            //SETUP
            using (var context = new MsSqlDbContext(_config))
            {
                //context.Database.EnsureClean();

                var callingAssemblyPath = GetCallingAssemblyTopLevelDir();
                var wwwrootDir = Path.GetFullPath(Path.Combine(callingAssemblyPath, "..\\XblApp\\wwwroot"));

                //ATTEMPT
                await context.SeedDatabaseIfNoGamesAsync(wwwrootDir);

                //VERIFY
                Assert.Equal(2, context.Gamers.Count());
            }
        }
    }
}
