using System;

namespace SushiStore.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int CultureId { get; set; }
        public Culture Culture { get; set; }
    }
}
