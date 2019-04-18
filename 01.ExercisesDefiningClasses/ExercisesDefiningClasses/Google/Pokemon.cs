using System;
using System.Collections.Generic;
using System.Text;

public class Pokemon
{
    private string pokemonName;
    private string pokemonType;

    public string PokemonName
    {
        get { return this.pokemonName; }
        set { this.pokemonName = value; }
    }

    public string PokemonType
    {
        get { return this.pokemonType; }
        set { this.pokemonType = value; }
    }

    public Pokemon(string pokemonName, string pokemonType)
    {
        this.pokemonName = pokemonName;
        this.pokemonType = pokemonType;
    }

    public override string ToString()
    {
        return $"{this.pokemonName} {this.pokemonType}";
    }
}
