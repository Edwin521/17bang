using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySelf
{
    class ProblemRepository
    {
        public IQueryable<Problem> GetBy(IList<ProblemStatus> exclude, bool hasReward, bool descByPublishTime)
        {
            //GetAfterExclude(exclude).ToList();

            //if (hasReward)
            //{
            //    return GetProblemWithout(GetAfterExclude(exclude)).GetProblemPublishTimeBy(descByPublishTime);
            //}
            //return GetProblemPublishTimeBy(GetAfterExclude(exclude), descByPublishTime);
            return null;
        }
         public IQueryable<Problem> GetAfterExclude(IList<ProblemStatus> exclude)
        {
            IQueryable<Problem> SqlDbContext = new SqlDbContext().problems;
            return SqlDbContext.Where(p => !exclude.Contains(p.Status));
        }
       

    }
    public static class Extension
    {
        public static IQueryable<Problem> GetProblemWithout(this IQueryable queryable, IQueryable<Problem> problems)
        {
            return problems.Where(p => p.Reward > 0);
        }
        public static IQueryable<Problem> GetProblemPublishTimeBy(this IQueryable queryable, IQueryable<Problem> problems, bool descByPublishTime)
        {
            if (descByPublishTime)
            {
                return problems.OrderBy(p => p.PublishTime);
            }
            return problems.OrderByDescending(p => p.PublishTime);
        }
    }
}
