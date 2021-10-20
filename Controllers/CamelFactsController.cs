using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CamelYaml.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CamelFactsController : ControllerBase
    {
        private static readonly string[] Facts = new[]
        {
            "Camels’ humps are not used to store water. Even though they come from hot climates, their humps store fat and also help the rest of their bodies to stay cooler. When needed, the fat will be converted to food or water.",
            "The word ‘camel’ comes from an Arabic word, when it’s literally translated, it means beauty. Don’t ever try and say that camels are ugly!",
            "They need to stay hydrated in the desert, so it’s no surprise that camels can drink as much as 40 gallons of water at once. Considering it’s not being stored in their humps, that’s pretty amazing.",
            "During the Second World War, German tank drivers would drive their vehicles over camel droppings, thinking it would bring them good luck.",
            "Arabian camels are the ones which only have one hump (Asian camels have two). In Arabian culture, they are so iconic that there are more than 160 words which mean ‘camel’.",
            "Some traveling circuses still have camels as a part of the show, although campaigners have been fighting for years to stop this. They rarely perform, but are used for people to look at or take photographs with.",
            "Camels are very social, even though they might seem extremely laid-back and slow. In the wild, they travel with around 30 others when looking for food.",
            "Clara C released a song called ‘The Camel Song’. The song mentions ‘a desert full of camels’, but the main theme is love and not camels!",
            "Camels will not damage their mouths if they eat thorny twigs and other items which might cause injury to other animals.",
            "There are more than 14 million camels in the world – most of them live in the Middle East, Asia and Australia.",
            "In Turkey, a camel wrestling event takes place every January. Camel wrestling dates back to the ancient world, so even though animal rights groups aren’t very happy with the sport, there are no signs of it stopping in the near future.",
            "Ever wondered why a camel’s mouth seems to be split into two? This helps them to graze and eat their food more effectively.",
            "The majority of mammals, including humans, only need to lose 15% of water before becoming dehydrated. However, camels are able to lose up to 25%, which means they can go much longer without water.",
            "In Middle Eastern countries, many people eat camel and consider it a delicacy. The hump is apparently the best part, and younger camels are tastier than the older animals.",
            "A camel’s nostrils are amazing. They retain water vapor which can be returned to the body when necessary, but they can also be closed if there is too much sand or wind blowing.",
            "David Baldacci created a group of characters known as The Camel Club. They featured in five novels, which are about the government and the secret service.",
            "Camels don’t just spit for fun. If they feel threatened, they will use it as a defense mechanism. Be nice to camels and they’ll be nice to you!",
            "They may not seem like fighters, but camels have been used during wars in the past. Ancient Greeks, Romans and Persians used to ride them, but they were used in the 20th Century too.",
            "The grandfather of the prophet Mohammad almost sacrificed one of his sons to an Arabic god named Hubal. However, the god accepted 100 camels as an alternative sacrifice.",
            "In 1855, the US Congress allowed the War Department to purchase camels using a $30,000 budget. They were used for several years, until the soldiers became tired of their bad tempers and smell.",
            "Wild Bactrians are the only type of camels which have never been tamed or domesticated. They live in the wastelands of Eastern Asia and are incredibly tough creatures. However, they are less than a thousand of them left on the earth.",
            "The world’s largest meal included a roasted camel. It was served at an Arabic wedding feast.",
            "If you visit Abu Dhabi, you’ll be able to pick up a camel milkshake – made with real camel milk. The milk has loads more Vitamin C and iron than cows’ milk, and is very good for you. It is used in Kazakhstan to help treat illnesses, such as tuberculosis. The only reason it hasn’t made its way to the Western world is because the governments won’t pay for testing processes.",
            "The Camel Mobile Library provides people in Kenya with literature. Camels are used to take books to areas which would not otherwise have access to a library.",
            "Llamas look a lot like camels, and can cause confusion if you don’t know the difference. The main difference is that camels will always have at least one hump, whereas llamas have no hump. Camels are also much larger.",
            "A camel might appear to have thick fur, but its coat reflects the sun. This makes it ideal in the hot desert, and the camels don’t get too hot.",
            "The Al-Dhafra Camel Festival takes place every year in the UAE. One of the most popular events is the beauty contest, which sees thousands of camels compete for the title.",
            "Camels aren’t as slow as they look – they can run up to speeds of 40mph. However, they cannot maintain this for very long, but can comfortably move at up to 25mph.",
            "The legend of the Red Ghost tells the story of a terrifying red camel wandering an Arizona desert and causing all kinds of atrocities, including killing people and trampling over tents.",
            "The only time you will see a camel without a hump is when it is first born. Once the baby camel is old enough to eat solids, the hump (or humps) will start growing."
        };

        private readonly ILogger<CamelFactsController> _logger;

        public CamelFactsController(ILogger<CamelFactsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var rnd = new Random();
            return Facts[rnd.Next(0, 29)];
        }
    }
}
