﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AlApar.Repositories.Status;

namespace AlApar.Classes.Job
{
    public class Form
    {
        [JsonProperty("type")]
        public int? TypeId { get; set; }

        [JsonProperty("category")]
        public int? CategoryId { get; set; }

        [JsonProperty("educationLevel")]
        public int? EducationId { get; set; }

        [JsonProperty("practiceDuration")]
        public int? PracticeId { get; set; }

        [JsonProperty("city")]
        public int? CityId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("minWage")]
        public int? MinWage { get; set; }

        [JsonProperty("maxWage")]
        public int? MaxWage { get; set; }

        [JsonProperty("minAge")]
        public int? MinAge { get; set; }

        [JsonProperty("maxAge")]
        public int? MaxAge { get; set; }

        [JsonProperty("aboutReq")]
        public string AboutReq { get; set; }

        [JsonProperty("aboutJob")]
        public string AboutJob { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("employeeName")]
        public string EmployeeName { get; set; }

        [JsonProperty("employeeSurname")]
        public string EmployeeSurname { get; set; }


        [JsonProperty("gender")]
        public bool? EmployeeIsGirl { get; set; }

        [JsonProperty("employeeEducation")]
        public string EmployeeAboutEducation { get; set; }

        [JsonProperty("employeePractice")]
        public string EmployeeAboutPractic { get; set; }

        [JsonProperty("employeeSkills")]
        public string EmployeeSkills { get; set; }

        [JsonProperty("employeeAboutExtra")]
        public string EmployeeAboutExtra { get; set; }


        [JsonProperty("isWp")]
        public bool? IsWp { get; set; }

        [JsonProperty("phone1")]
        public string PhoneNumber1 { get; set; }

        [JsonProperty("phone2")]
        public string PhoneNumber2 { get; set; }

        [JsonProperty("phone3")]
        public string PhoneNumber3 { get; set; }

        [JsonProperty("phone4")]
        public string PhoneNumber4 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        //Filter

        [JsonProperty("sharedDate")]
        public int? SharedDate { get; set; }

        [JsonProperty("minAgeFilter")]
        [FilterCheck(TypeEnum.Min, "MinAge")]
        public int? MinAgeFilter { get; set; }

        [JsonProperty("maxAgeFilter")]
        [FilterCheck(TypeEnum.Max, "MaxAge")]
        public int? MaxAgeFilter { get; set; }

        [JsonProperty("minWageFilter")]
        [FilterCheck(TypeEnum.Min, "MinWage")]
        public int? MinWageFilter { get; set; }

        [JsonProperty("maxWageFilter")]
        [FilterCheck(TypeEnum.Max, "MaxWage")]
        public int? MaxWageFilter { get; set; }
    }
}
