﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GlobalTickets.Web.Extensions
{
    public static class EnumerableOfGuid
    {
        public static string ToQueryString(this IEnumerable<Guid> guids)
        {
            return "?" + string.Join("&", guids.Select(g => $"eventIds={g}"));
        }
    }
}
