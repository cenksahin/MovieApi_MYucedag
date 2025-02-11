namespace MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
    public class GetCategoryByIdResult
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}