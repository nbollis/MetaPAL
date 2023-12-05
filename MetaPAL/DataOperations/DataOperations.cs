using MetaPAL.Data;
using MetaPAL.Models;
using Microsoft.EntityFrameworkCore;
using Readers;

namespace MetaPAL.DataOperations
{
    public static class DataOperations
    {
        public static void AddRange<T>(this DbSet<T> dbSet, IEnumerable<T> entities) where T : class
        {
            foreach (var entity in entities)
            {
                dbSet.Add(entity);
            }
        }


        public static void AddPsmsFromFile(this ApplicationDbContext context, string filePath)
        {

            var psms = SpectrumMatchTsvReader.ReadTsv(filePath, out _);


            //int currentMaxId = context.SpectrumMatch!.Max(p => p.Id) + 1;
            //for (int i = currentMaxId; i < currentMaxId + psms.Count; i++)
            //{
            //    SpectrumMatch match = 
            //}

            //for (int i = context.SpectrumMatch.Max(p => p.Id); i < context.SpectrumMatch.Max(p => p.Id); i++)
            //{
                
            //}

            //context.SpectrumMatch.AddRange(SpectrumMatchTsvReader.ReadPsmTsv(filePath, out _));
            //context.SaveChanges();
        }
    }
}
