using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> Characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            Characters.Add(newCharacter);
            return Characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return Characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            var character = Characters.FirstOrDefault(c => c.Id == id);
            if(character is not null)
                return character;

            throw new Exception("Character not found");
        }
    }
}