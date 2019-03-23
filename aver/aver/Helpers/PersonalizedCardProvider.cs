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

        


        List<string> reasons = new List<string> { "High Blood Pressure", "Lactose Intolerant", "Pregnancy","Varfarin"};
        public SuggestionViewModel GetPlan(string ssn)
        {
            //List<string> ids = helper.GetDiagnosisIds(ssn);
            SuggestionViewModel model = new SuggestionViewModel();


            /* High Blood Pressure
             * Lactose Intolerant
             * Pregnancy
             * 
             */

            return model;

        }

        public List<SuggestionItem> GetMealPlan(string budget ="low")
        {
            List<SuggestionItem> meals = new List<SuggestionItem>();

            meals.Add(GetBreatkfast(budget, "isdead"));
            meals.Add(GetSupper(budget, "isdead"));
            meals.Add(GetDinner(budget, "isdead"));

            return meals;
        }
        public string GetReason()
        {
           
            Random rnd = new Random();
            int index =  rnd.Next(reasons.Count());

            return reasons[index];
        }
        public SuggestionItem GetBreatkfast(string budget, string affliction)
        {
            SuggestionItem item = new SuggestionItem();

            List<Food> lowBudget = new List<Food>();

            lowBudget.Add(new Food()
            {
                FoodName = "Epli",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Banani",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Hafragrautur",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Bacon",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Bagel",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Bialy",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Baked Beans",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Ham",
                Explanation = GetReason()
            });

            List<Food> highBUdget = new List<Food>();


            highBUdget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "Vanilla",
                Explanation = GetReason()
            });

            highBUdget.Add(new Food()
            {
                FoodName = "DENSUKE WATERMELON",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "SAFFRON",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = GetReason()
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
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Hlölla bátur",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Núðlur",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Hamborgari",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Buffalo",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Chilli Dog",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Jelly-O",
                Explanation = GetReason()
            });


            List<Food> highBUdget = new List<Food>();


            highBUdget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "Vanilla",
                Explanation = GetReason()
            });

            highBUdget.Add(new Food()
            {
                FoodName = "DENSUKE WATERMELON",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "SAFFRON",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = GetReason()
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
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Lasagna",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Núðlur",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Pasta",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Lobster Rolls",
                Explanation = GetReason()
            });
            List<Food> highBUdget = new List<Food>();

            highBUdget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "Oyster",
                Explanation = GetReason()
            });

            highBUdget.Add(new Food()
            {
                FoodName = "Mozzarella sticks",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "Tuna Casserol",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = GetReason()
            });
            highBUdget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = GetReason()
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