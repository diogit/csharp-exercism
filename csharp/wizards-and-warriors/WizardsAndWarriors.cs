using System;

abstract class Character
{
    protected string characterType;
    protected bool vulnerable;
    protected Character(string characterType)
    {
        this.characterType = characterType;
        this.vulnerable = false;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return this.vulnerable;
    }

    public override string ToString()
    {
        return $"Character is a {this.characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
        this.vulnerable = true;
    }

    public override int DamagePoints(Character target)
    {
        return this.vulnerable ? 3 : 12;
    }

    public void PrepareSpell()
    {
        this.vulnerable = false;
    }
}
