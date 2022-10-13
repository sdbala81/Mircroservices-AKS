﻿using System;

namespace GlobalTickets.Gateway.WebBff.Url
{
    public class EventCatalogOperations
    {
        public static string GetEventsPerCategory(Guid categoryId) => $"/api/events?categoryid={categoryId}";
        public static string GetEventById(Guid id) => $"/api/events/{id}";
        public static string GetAllcategories() => "/api/categories";
        public static string GetAllEvents() => "/api/events";
    }
}