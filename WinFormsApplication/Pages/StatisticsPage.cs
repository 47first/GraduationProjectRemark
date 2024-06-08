using System.Linq;
using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApplication.Pages
{
    public partial class StatisticsPage : UserControl
    {
        private readonly string _mostActiveEmployeeLabelFormat;
        private readonly string _mostActiveUserLabelFormat;
        private readonly string _mostPopularServiceLabelFormat;
        private readonly string _totalCompletedRequestsFormat;
        private readonly string _totalRequestRevenueLabelFormat;
        private readonly string _createdRequestAmountLabelFormat;
        private readonly string _topUsefullCategoriesFormat;

        public StatisticsPage()
        {
            InitializeComponent();

            _mostActiveEmployeeLabelFormat = mostActiveEmployeeLabel.Text;
            _mostActiveUserLabelFormat = mostActiveUserLabel.Text;
            _mostPopularServiceLabelFormat = mostPopularServiceLabel.Text;
            _totalCompletedRequestsFormat = totalCompletedRequests.Text;
            _totalRequestRevenueLabelFormat = totalRequestRevenueLabel.Text;
            _createdRequestAmountLabelFormat = createdRequestAmountLabel.Text;
            _topUsefullCategoriesFormat = topUsefullCategories.Text;
        }

        public void UpdateData()
        {
            using (var dbContext = new DatabaseContext())
            {
                mostActiveEmployeeLabel.Text = string.Format(_mostActiveEmployeeLabelFormat, GetMostActiveEmployee(dbContext));
                mostActiveUserLabel.Text = string.Format(_mostActiveUserLabelFormat, GetMostActiveUser(dbContext));
                mostPopularServiceLabel.Text = string.Format(_mostPopularServiceLabelFormat, GetMostPopularService(dbContext));
                totalCompletedRequests.Text = string.Format(_totalCompletedRequestsFormat, GetTotalCompletedRequests(dbContext));
                totalRequestRevenueLabel.Text = string.Format(_totalRequestRevenueLabelFormat, GetTotalRequestRevenue(dbContext));
                createdRequestAmountLabel.Text = string.Format(_createdRequestAmountLabelFormat, GetCreatedRequestAmount(dbContext));
                topUsefullCategories.Text = string.Format(_topUsefullCategoriesFormat, GetTopUsefullCategories(dbContext));
            }
        }

        private string GetMostActiveEmployee(DatabaseContext context)
        {
            var employeeCountPairs = new Dictionary<Employee, int>();

            foreach (var request in context.Requests
                .Where(x => x.EmployeeId.HasValue)
                .Include(x => x.Employee)
                .Include(x => x.Employee.User))
            {
                if (employeeCountPairs.ContainsKey(request.Employee))
                {
                    employeeCountPairs[request.Employee]++;
                }
                else
                {
                    employeeCountPairs.Add(request.Employee, 1);
                }
            }

            if (employeeCountPairs.Count < 1)
            {
                return "Не найден...";
            }

            var mostActiveEmployee = employeeCountPairs.MaxBy(x => x.Value).Key.User;

            return $"{mostActiveEmployee.LastName} {mostActiveEmployee.FirstName} {mostActiveEmployee.MiddleName}";
        }

        private string GetMostActiveUser(DatabaseContext context)
        {
            var usersCountPairs = new Dictionary<User, int>();

            foreach (var request in context.Requests
                .Include(x => x.User))
            {
                if (usersCountPairs.ContainsKey(request.User))
                {
                    usersCountPairs[request.User]++;
                }
                else
                {
                    usersCountPairs.Add(request.User, 1);
                }
            }

            if (usersCountPairs.Count < 1)
            {
                return "Не найден...";
            }

            var mostActiveUser = usersCountPairs.MaxBy(x => x.Value).Key;

            return $"{mostActiveUser.LastName} {mostActiveUser.FirstName} {mostActiveUser.MiddleName}";
        }

        private string GetMostPopularService(DatabaseContext context)
        {
            var servicesCountPairs = new Dictionary<Service, int>();

            foreach (var request in context.Requests.Include(x => x.Service))
            {
                if (servicesCountPairs.ContainsKey(request.Service))
                {
                    servicesCountPairs[request.Service]++;
                }
                else
                {
                    servicesCountPairs.Add(request.Service, 1);
                }
            }

            if (servicesCountPairs.Count < 1)
            {
                return "Не найден...";
            }

            var mostPopularService = servicesCountPairs.MaxBy(x => x.Value).Key;

            return mostPopularService.Name;
        }

        private string GetTotalCompletedRequests(DatabaseContext context)
        {
            return context.Requests.Where(x => x.IsCompleted).Count().ToString();
        }

        private string GetTotalRequestRevenue(DatabaseContext context)
        {
            return context.Requests.Select(x => x.Price).Sum().ToString();
        }

        private string GetCreatedRequestAmount(DatabaseContext context)
        {
            return context.Requests.Count().ToString();
        }

        private string GetTopUsefullCategories(DatabaseContext context)
        {
            var categoryCountPairs = new Dictionary<Category, int>();

            foreach (var request in context.Requests.Include(x => x.Service.Category))
            {
                if (categoryCountPairs.ContainsKey(request.Service.Category))
                {
                    categoryCountPairs[request.Service.Category]++;
                }
                else
                {
                    categoryCountPairs.Add(request.Service.Category, 1);
                }
            }

            if (categoryCountPairs.Count < 1)
            {
                return "Не найдено...";
            }

            var categoryNames = categoryCountPairs
                .OrderBy(x => x.Value)
                .Take(3)
                .Select(x => x.Key.Name);

            return "\n - " + string.Join(",\n - ", categoryNames);
        }
    }
}
