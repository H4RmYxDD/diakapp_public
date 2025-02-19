using MauiAppEF.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEF.Services
{
    public class GradeService
    {
        private readonly ApplicationDbContext _context;

        public GradeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Grades>> GetGradesAsync()
        {
            return await _context.Grades.Include(g => g.Student).Include(g => g.Subject).ToListAsync();
        }

        public async Task<Grades> GetGradeByIdAsync(int id)
        {
            return await _context.Grades.Include(g => g.Student).Include(g => g.Subject).FirstOrDefaultAsync(g => g.StudentId == id);
        }

        public async Task AddGradeAsync(Grades grade)
        {
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGradeAsync(Grades grade)
        {
            _context.Grades.Update(grade);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGradeAsync(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade != null)
            {
                _context.Grades.Remove(grade);
                await _context.SaveChangesAsync();
            }
        }
    }
}
