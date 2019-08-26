using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhatToDoAPI.Models
{
    public class WeatherCondition
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EvaluationType { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public DateTime? ConditionDateTime { get; set; }
        public string TimeFrame { get; set; }
        public string CurrentStatus { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? LocationId { get; set; }
        public int? TimeGroupId { get; set; }

        //[Key]
        //private readonly int id;
        //private readonly string name;
        //private readonly string description;
        //private readonly string evaluationType;
        //private readonly decimal? latitude;
        //private readonly decimal? longitude;
        //private readonly string state;
        //private readonly string location;
        //private readonly DateTime? conditionDateTime;
        //private readonly string timeFrame;
        //private readonly string currentStatus;
        //private readonly DateTime? lastUpdate;
        //private readonly int? locationId;
        //private readonly int? timeGroupId;

        //public int Id
        //{
        //    get
        //    {
        //        return id;
        //    }
        //}

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //}

        //public string Description
        //{
        //    get
        //    {
        //        return description;
        //    }
        //}

        //public string EvaluationType
        //{
        //    get
        //    {
        //        return evaluationType;
        //    }
        //}

        //public decimal? Latitude
        //{
        //    get
        //    {
        //        return latitude;
        //    }
        //}

        //public decimal? Longitude
        //{
        //    get
        //    {
        //        return longitude;
        //    }
        //}

        //public string State
        //{
        //    get
        //    {
        //        return state;
        //    }
        //}

        //public string Location
        //{
        //    get
        //    {
        //        return state;
        //    }
        //}

        //public DateTime? ConditionDateTime
        //{
        //    get
        //    {
        //        return conditionDateTime;
        //    }
        //}

        //public string TimeFrame
        //{
        //    get
        //    {
        //        return timeFrame;
        //    }
        //}

        //public string CurrentStatus
        //{
        //    get
        //    {
        //        return currentStatus;
        //    }
        //}

        //public DateTime? LastUpdate
        //{
        //    get
        //    {
        //        return lastUpdate;
        //    }
        //}

        //public int? LocationId
        //{
        //    get
        //    {
        //        return locationId;
        //    }
        //}

        //public int? TimeGroupId
        //{
        //    get
        //    {
        //        return timeGroupId;
        //    }
        //}

    }


    //public class Dates
    //{
    //    private int month;

    //    public int Month
    //    {
    //        get
    //        {
    //            return month;
    //        }

    //        set
    //        {
    //            month = value;
    //        }
    //    }


    //}

    
}
