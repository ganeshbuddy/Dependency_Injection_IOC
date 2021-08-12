using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class PlayerGenerator : IPlayerGenerator
    {
        private readonly string[] _maleNames = { "GANESHRAJ", "JACK", "JAMES" };
        private readonly string[] _femaleNames = { "SHERLIN", "DORA", "SOPHIA"};

        public Player CreateNewPlayer()
        {
            string playerName;
            var random = new Random();

            var playerNameIndex = random.Next(3);
            var playerGenderIndex = random.Next(2);
            var playerHairColorIndex = random.Next(7);
            var playerAge = random.Next(18, 100);
            var strength = random.Next(8, 18);

            if (playerGenderIndex == 0)
                playerName = _maleNames[playerNameIndex];
            else
                playerName = _femaleNames[playerNameIndex];

            return new Player
            {
                Name = playerName,
                Gender = (Gender)playerGenderIndex,
                HairColor = (HairColor)playerHairColorIndex,
                Age = playerAge,
                Strength = strength,
                Race = "Human"
            };
        }
    }
}