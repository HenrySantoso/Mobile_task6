using CourseMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CourseMVVM.Data
{
    public class CourseCategoryRepository : ICourseCategory
    {
        private readonly HttpClient _httpClient;

        public CourseCategoryRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<CourseCategory> AddAsync(CourseCategory courseCategory)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseCategory> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CourseCategory>> ListAsync()
        {
            //get data from http client
            var response = await _httpClient.GetAsync($"{HttpHelper.baseAddress}/api/v1/Categories");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var categories = JsonSerializer.Deserialize<List<CourseCategory>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return categories ?? new List<CourseCategory>();
            }
            else
            {
                throw new Exception("Cannot get data from server");
            }
        }

        public Task<CourseCategory> UpdateAsync(CourseCategory courseCategory)
        {
            throw new NotImplementedException();
        }
    }
}
