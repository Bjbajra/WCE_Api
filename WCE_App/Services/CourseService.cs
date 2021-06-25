using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WCE_App.Interfaces;
using WCE_App.Models;
using WCE_App.ViewModels;

namespace WCE_App.Services
{
    public class CourseService : ICourseService
    {

        private readonly string _baseUrl;
        private readonly JsonSerializerOptions _options;
        private readonly HttpClient _http;

        public CourseService(IConfiguration config, HttpClient http)
        {
            _http = http;
            _baseUrl = config.GetSection("api:baseUrl").Value + config.GetSection("api:courseBaseUrl").Value;

            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        }

        public async Task<bool> AddCourse(CourseModel model)
        {
            try
            {
                var url = _baseUrl;
                var data = JsonSerializer.Serialize(model);

                var response = await _http.PostAsync(url, new StringContent(data, Encoding.Default, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var error = response.Content.ReadAsStringAsync().Result;
                    throw new Exception(error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteCourse(int courseNo)
        {
            try
            {
                var response = await _http.DeleteAsync($"{_baseUrl}/{courseNo}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var error = response.Content.ReadAsStringAsync().Result;
                    throw new Exception(error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<List<CourseModel>> GetCourseAsync()
        {
            var response = await _http.GetAsync($"{_baseUrl}");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<CourseModel>>(data, _options);

                return result;
            }
            else
            {
                throw new Exception("Something went wrong");
            }
        }

        public async Task<CourseModel> GetCourseAsync(int courseNo)
        {

            var response = await _http.GetAsync($"{_baseUrl}/find/{courseNo}");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<CourseModel>(data, _options);
                return result;
            }
            else
            {
                throw new Exception("Something went wrong again");
            }
        }

        public async Task<CourseModel> GetCourseByIdAsync(int id)
        {

            var response = await _http.GetAsync($"{_baseUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<CourseModel>(data, _options);
                return result;
            }
            else
            {
                throw new Exception("Something went wrong!");
            }

        }

        public async Task<bool> UpdateCourse(int id, UpdateCourseViewModel model)
        {
            try
            {
                var url = $"{_baseUrl}/{id}";
                var data = JsonSerializer.Serialize(model);
                var response = await _http.PutAsync(url, new StringContent(data, Encoding.Default, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var error = response.Content.ReadAsStringAsync().Result;
                    throw new Exception(error);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}