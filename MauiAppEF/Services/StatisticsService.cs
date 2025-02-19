using MauiAppEF.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEF.Services
{
    public class StatisticsService
    {
        private readonly ApplicationDbContext _context;

        public StatisticsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<dynamic>> GetBestAndWorstStudentsPerSubjectAsync()
        {
            return await _context.Grades
                .GroupBy(g => g.SubjectId)
                .Select(g => new
                {
                    Subject = g.First().Subject.Name,
                    BestStudent = g.OrderByDescending(x => x.Grade).First().Student.Name,
                    BestAverage = g.OrderByDescending(x => x.Grade).First().Grade,
                    WorstStudent = g.OrderBy(x => x.Grade).First().Student.Name,
                    WorstAverage = g.OrderBy(x => x.Grade).First().Grade
                })
                .ToListAsync<dynamic>();
        }

        public async Task<dynamic> GetOverallBestAndWorstStudentAsync()
        {
            var studentAverages = await _context.Students
                .Select(s => new
                {
                    StudentName = s.Name,
                    Average = s.Grades.Average(g => g.Grade)
                })
                .ToListAsync();

            return new
            {
                BestStudent = studentAverages.OrderByDescending(s => s.Average).First(),
                WorstStudent = studentAverages.OrderBy(s => s.Average).First()
            };
        }
    }
}
