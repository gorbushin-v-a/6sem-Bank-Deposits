using sharps_ent.Context;

namespace sharps_ent
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            dbContext.SaveChanges();
        }
    }
}
