﻿namespace GlobalEvents.Application.Features.Events.Queries.GetEventDetails
{
    public class EventDetailModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryModel Category { get; set; } = default!;
    }
}
