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
        public Random rnd = new Random();



        List<string> reasons = new List<string> { "High Blood Pressure", "Lactose Intolerance", "Pregnancy","Warfarin"};
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
        public SuggestionItem GetByType(string type)
        {
            var payload = (type == "breakfast") ? GetFullBreakfast() :
                (type == "supper") ? GetFullSupper() : (type == "dinner") ? GetFullDinner() : (type == "snacks") ? GetFullSnacks():
                (type == "not-allowed") ? GetBannedList() : GetBannedList();
            return payload;
        }
        public List<SuggestionItem> GetMealPlan(string budget ="low")
        {
            List<SuggestionItem> meals = new List<SuggestionItem>();

            meals.Add(GetBreatkfast(budget, "isdead"));
            meals.Add(GetSupper("high", "isdead"));
            meals.Add(GetDinner("high", "isdead"));
            meals.Add(GetBannedList());
            return meals;
        }
        public string GetReason()
        {
           
            
            int index =  rnd.Next(reasons.Count);

            return reasons[index];
        }

        public SuggestionItem GetBannedList()
        {
            SuggestionItem item = new SuggestionItem();
            List<Food> banned = new List<Food>();
            item.Title ="Banned";


            banned.Add(new Food()
            {
                FoodName = "Pasta",
                Explanation = GetReason()
            });
            banned.Add(new Food()
            {
                FoodName = "White Bread",
                Explanation = GetReason()
            });
            banned.Add(new Food()
            {
                FoodName = "French Fries",
                Explanation = GetReason()
            });
            banned.Add(new Food()
            {
                FoodName = "Candy",
                Explanation = GetReason()
            }); banned.Add(new Food()
            {
                FoodName = "Ice Cream",
                Explanation = GetReason()
            }); banned.Add(new Food()
            {
                FoodName = "Chips",
                Explanation = GetReason()
            });

            item.Foods = banned;
            return item;
        }

        public SuggestionItem GetBreatkfast(string budget, string affliction)
        {
            SuggestionItem item = new SuggestionItem();
            item.Title = "Breakfast";
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

            List<Food> highBudget = new List<Food>();


            highBudget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "Vanilla",
                Explanation = GetReason()
            });

            highBudget.Add(new Food()
            {
                FoodName = "DENSUKE WATERMELON",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "SAFFRON",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = GetReason()
            });

            if (budget == "low")
            {
                item.Foods= lowBudget;
            }
            
            else
            {
                item.Foods = highBudget;
            }
            Random r = new Random();
            item.Foods = item.Foods.OrderBy(x => r.Next()).Take(3).ToList();
            return item;
        }

        public SuggestionItem GetFullBreakfast()
        {
            SuggestionItem item = new SuggestionItem();
            item.Title = "Breakfast";
            List<Food> lowBudget = new List<Food>();

            lowBudget.Add(new Food()
            {
                FoodName = "Oats",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "AB - Milk",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Skyr.is",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Eggs",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Sesame Seeds",
                Explanation = GetReason()
            });


            lowBudget.Add(new Food()
            {
                FoodName = "Strawberries",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Apples",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Crispbread",
                Explanation = GetReason()
            });

            lowBudget.Add(new Food()
            {
                FoodName = "Tuna",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Cod",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Milk",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Cheese",
                Explanation = GetReason()
            });
            item.Foods = lowBudget;

            return item;

        }
        public SuggestionItem GetFullSupper()
        {
            SuggestionItem item = new SuggestionItem();
            item.Title = "Supper";
            List<Food> lowBudget = new List<Food>();

            lowBudget.Add(new Food()
            {
                FoodName = "Eggs",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Chicken",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Cod",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Tuna",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Apples",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Oranges",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Mushrooms",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Ab-milk",
                Explanation = GetReason()
            });

            lowBudget.Add(new Food()
            {
                FoodName = "Brown Pasta",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Cheese",
                Explanation = GetReason()
            });
            item.Foods = lowBudget;

            return item;
        }
        public SuggestionItem GetFullDinner()
        {
            SuggestionItem item = new SuggestionItem();
            item.Title = "Dinner";
            List<Food> lowBudget = new List<Food>();

            lowBudget.Add(new Food()
            {
                FoodName = "Chicken",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Beef",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Sweet Potato",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Mushroom",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Onion",
                Explanation = GetReason()
            });
           

            lowBudget.Add(new Food()
            {
                FoodName = "Cod",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Tuna",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Salad",
                Explanation = GetReason()
            });

            lowBudget.Add(new Food()
            {
                FoodName = "Whole wheat pasta",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Brown Rice",
                Explanation = GetReason()
            });
            item.Foods = lowBudget;

            return item;

        }
        public SuggestionItem GetFullSnacks()
        {
            SuggestionItem item = new SuggestionItem();
            item.Title = "Snacks";
            List<Food> lowBudget = new List<Food>();

            lowBudget.Add(new Food()
            {
                FoodName = "Apples",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Oranges",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Pears",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Salad",
                Explanation = GetReason()
            });
            lowBudget.Add(new Food()
            {
                FoodName = "Carrots",
                Explanation = GetReason()
            });

            item.Foods = lowBudget;

            return item;

        }


        public SuggestionItem GetSupper(string budget, string affliction)
        {
            SuggestionItem item = new SuggestionItem();
            item.Title = "Supper";
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


            List<Food> highBudget = new List<Food>();


            highBudget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "Vanilla",
                Explanation = GetReason()
            });

            highBudget.Add(new Food()
            {
                FoodName = "DENSUKE WATERMELON",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "SAFFRON",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = GetReason()
            });


            if (budget == "low")
            {
                item.Foods = lowBudget;
            }

            else
            {
                item.Foods = highBudget;
            }
            Random r = new Random();
            item.Foods = item.Foods.OrderBy(x =>r.Next()).Take(3).ToList();
            return item;
        }
        public SuggestionItem GetDinner(string budget, string affliction)
        {
            SuggestionItem item = new SuggestionItem();
            item.Title = "Dinner";
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
            List<Food> highBudget = new List<Food>();

            highBudget.Add(new Food()
            {
                FoodName = "Kavíar",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "White Truffles",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "Oyster",
                Explanation = GetReason()
            });

            highBudget.Add(new Food()
            {
                FoodName = "Mozzarella sticks",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "Tuna Casserol",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "MATCHA GREEN TEA",
                Explanation = GetReason()
            });
            highBudget.Add(new Food()
            {
                FoodName = "MOOSE MILK CHEESE",
                Explanation = GetReason()
            });

            if (budget == "low")
            {
                item.Foods = lowBudget;
            }

            else
            {
                item.Foods = highBudget;
            }
            Random r = new Random();
            item.Foods = item.Foods.OrderBy(x => r.Next()).Take(3).ToList();
            return item;
        }
    }

}