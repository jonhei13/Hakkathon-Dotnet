using aver.core.Models;
using aver.Models;
using aver.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aver.Helpers
{
    public class PersonalizedCardProvider
    {
        public BusinessHelper helper = new BusinessHelper();
        public SuggestionViewModel GetPlan(string ssn)
        {
            List<string> ids = helper.GetDiagnosisIds(ssn);
            SuggestionViewModel model = new SuggestionViewModel();



            return model;

        }

        public List<SuggestionItem> GetMealPlan(string budget)
        {
            List<SuggestionItem> meals = new List<SuggestionItem>();

            meals.Add(GetBreatkfast(budget, "isdead"));
            
            return meals;
        }

        public SuggestionItem GetBreatkfast(string budget, string affliction)
        {
            SuggestionItem item = new SuggestionItem();

            List<Food> lowBudget = new List<Food>();

            lowBudget.Add(new Food()
            {
                FoodName = "Epli",
                Explanation = "Holl"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "banani",
                Explanation = "Holl"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "hafragrautur",
                Explanation = "egg"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "bacon",
                Explanation = "Holl"
            });

            List<Food> highBUdget = new List<Food>();


            highBUdget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "Vanilla",
                Explanation = "Holl"
            });

            highBUdget.Add(new Food()
            {
                FoodName = "DENSUKE WATERMELON",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "SAFFRON",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = "Holl"
            });

            if (budget == "low")
            {
                item.Foods.AddRange(lowBudget.Take(3).ToList());
            }
            
            else
            {
                item.Foods.AddRange(highBUdget.Take(3).ToList());
            }

            return item;
        }


        public SuggestionItem GetSupper(string budget, string affliction)
        {
            SuggestionItem item = new SuggestionItem();

            List<Food> lowBudget = new List<Food>();

            lowBudget.Add(new Food()
            {
                FoodName = "Samloka",
                Explanation = "Holl"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Hlölla bátur",
                Explanation = "Holl"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Núðlur",
                Explanation = "egg"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Hamborgari",
                Explanation = "Holl"
            });

            List<Food> highBUdget = new List<Food>();


            highBUdget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "Vanilla",
                Explanation = "Holl"
            });

            highBUdget.Add(new Food()
            {
                FoodName = "DENSUKE WATERMELON",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "SAFFRON",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = "Holl"
            });

            if (budget == "low")
            {
                item.Foods.AddRange(lowBudget.Take(3).ToList());
            }

            else
            {
                item.Foods.AddRange(highBUdget.Take(3).ToList());
            }

            return item;
        }
        public SuggestionItem GetDinner(string budget, string affliction)
        {
            SuggestionItem item = new SuggestionItem();

            List<Food> lowBudget = new List<Food>();

            lowBudget.Add(new Food()
            {
                FoodName = "Kjúklingur",
                Explanation = "Holl"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Lasagna",
                Explanation = "Holl"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Núðlur",
                Explanation = "egg"
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Pasta",
                Explanation = "Holl"
            });

            List<Food> highBUdget = new List<Food>();


            highBUdget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "Vanilla",
                Explanation = "Holl"
            });

            highBUdget.Add(new Food()
            {
                FoodName = "DENSUKE WATERMELON",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "SAFFRON",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = "Holl"
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = "Holl"
            });

            if (budget == "low")
            {
                item.Foods.AddRange(lowBudget.Take(3).ToList());
            }

            else
            {
                item.Foods.AddRange(highBUdget.Take(3).ToList());
            }

            return item;
        }
    }

}