using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProject
{
    class Pokemon
    {
        int number, hp, atk, def, spatk, spdef, spd, catchRate, level;
        string name;

        PokemonType type, type2;

        public int Attack(Pokemon defPokemon)
        {
            return 1;
        }

        public void UpdateStats()
        {

        }

        public Pokemon()
        {

        }

        public Pokemon(string[] dataRow)
        {
            number = Int32.Parse(dataRow[0]);
            name = dataRow[1];
            hp = Int32.Parse(dataRow[2]);
            atk = Int32.Parse(dataRow[3]);
            def = Int32.Parse(dataRow[4]);
            spatk = Int32.Parse(dataRow[5]);
            spdef = Int32.Parse(dataRow[6]);
            spd = Int32.Parse(dataRow[7]);
            if(dataRow[7] != null)
            {

            }

        }
    }

    enum PokemonType
    {
        Normal,
        Fire,
        Water,
        Electric,
        Grass,
        Ice,
        Fight,
        Poison,
        Ground,
        Flying,
        Psychic,
        Bug,
        Rock,
        Ghost,
        Dragon,
        Dark,
        Steel,
        Fairy
    }
}
