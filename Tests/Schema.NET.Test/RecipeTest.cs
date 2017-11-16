namespace Schema.NET.Test
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Xunit;

    // https://developers.google.com/search/docs/guides/mark-up-listings
    public class RecipeTest
    {
        private readonly Recipe recipe = new Recipe()
        {
            Name = "Grandma's Holiday Apple Pie",
            Image = new Uri("https://example.com/image.jpg"),
            Author = new Person()
            {
                Name = "Carol Smith"
            },
            DatePublished = new DateTimeOffset(2009, 11, 5, 0, 0, 0, TimeSpan.Zero),
            Description = "This is my grandmother's apple pie recipe. I like to add a dash of nutmeg.",
            AggregateRating = new AggregateRating()
            {
                RatingValue = 4D,
                ReviewCount = 35
            },
            PrepTime = new TimeSpan(0, 30, 0),
            CookTime = new TimeSpan(1, 0, 0),
            TotalTime = new TimeSpan(1, 30, 0),
            RecipeYield = "1 9 inch pie (8 servings)",
            Nutrition = new NutritionInformation()
            {
                ServingSize = "1 medium slice",
                Calories = "250 cal",
                FatContent = "12 g"
            },
            RecipeIngredient = new List<string>()
            {
                "Thinly-sliced apples:6 cups",
                "White sugar:3/4 cup"
            },
            RecipeInstructions = "1. Cut and peel apples..."
        };

        private readonly string json =
            "{" +
            "\"@context\":\"http://schema.org\"," +
            "\"@type\":\"Recipe\"," +
            "\"name\":\"Grandma's Holiday Apple Pie\"," +
            "\"description\":\"This is my grandmother's apple pie recipe. I like to add a dash of nutmeg.\"," +
            "\"image\":\"https://example.com/image.jpg\"," +
            "\"aggregateRating\":{" +
                "\"@type\":\"AggregateRating\"," +
                "\"ratingValue\":4.0," +
                "\"reviewCount\":35" +
            "}," +
            "\"author\":{" +
                "\"@type\":\"Person\"," +
                "\"name\":\"Carol Smith\"" +
            "}," +
            "\"datePublished\":\"2009-11-05T00:00:00+00:00\"," +
            "\"prepTime\":\"PT30M\"," +
            "\"totalTime\":\"PT1H30M\"," +
            "\"cookTime\":\"PT1H\"," +
            "\"nutrition\":{" +
                "\"@type\":\"NutritionInformation\"," +
                "\"calories\":\"250 cal\"," +
                "\"fatContent\":\"12 g\"," +
                "\"servingSize\":\"1 medium slice\"" +
            "}," +
            "\"recipeIngredient\":[" +
                "\"Thinly-sliced apples:6 cups\"," +
                "\"White sugar:3/4 cup\"" +
            "]," +
            "\"recipeInstructions\":\"1. Cut and peel apples...\"," +
            "\"recipeYield\":\"1 9 inch pie (8 servings)\"" +
            "}";

        [Fact]
        public void ToString_CarouselGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            Assert.Equal(this.json, this.recipe.ToString());
        }

        [Fact]
        public void Deserializing_RecipeJsonLd_ReturnsRecipe()
        {
            Assert.Equal(this.recipe.ToString(), JsonConvert.DeserializeObject<Recipe>(this.json).ToString());
        }
    }
}
