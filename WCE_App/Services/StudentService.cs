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
    public class StudentService : IStudentService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl;
        private readonly JsonSerializerOptions _options;

        public StudentService(IConfiguration config, HttpClient http)
        {
            _http = http;
           _baseUrl = config.GetSection("api:baseUrl").Value + config.GetSection("api:studentBaseUrl").Value;
           _options = new JsonSerializerOptions{
               PropertyNameCaseInsensitive = true
           };
        }

        public async Task<bool> AddStudent(StudentModel model)
        {
            try
            {
                var url = _baseUrl;
                var data = JsonSerializer.Serialize(model);

                var response = await _http.PostAsync(url, new StringContent(data, Encoding.Default, "application/json"));

                if(response.IsSuccessStatusCode){
                    return true;
                }
                else{
                    var error = response.Content.ReadAsStringAsync().Result;
                    throw new Exception(error);
                }
            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message);
            }
        }

        public Task<bool> DeleteStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<StudentModel>> GetStudentAsync()
        {
            var response = await _http.GetAsync($"{_baseUrl}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<List<StudentModel>>(data, _options);

                return result;
            }
            else
            {
                throw new Exception("Something went wrong");
            }
        }

        public async Task<StudentModel> GetStudentAsync(int id)
        {
            var response = await _http.GetAsync($"{_baseUrl}/{id}");

            if(response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<StudentModel>(data, _options);
                return result;
            }
            else{
                throw new Exception("Error!");
            }
        }

        public async Task<bool> UpdateStudent(int id, UpdateStudentViewModel model)
        {
            try
            {
                var url = $"{_baseUrl}/{id}";
                var data = JsonSerializer.Serialize(model);
                var response = await _http.PutAsync(url, new StringContent(data, Encoding.Default, "application/json"));

                if(response.IsSuccessStatusCode)
                {
                    return true;
                }
                else{
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