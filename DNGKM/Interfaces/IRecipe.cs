namespace DNGlobalKitchenManual
{
    interface IRecipe
    {
        string Name { get; }


        // name, description/summary?, required equipment, 
        // ingredients list (array, dictionary, you decide what you like), 
        // approx time to make, Notes

        Dictionary<Vegetable, int> Vegetables { get; }

    }
}