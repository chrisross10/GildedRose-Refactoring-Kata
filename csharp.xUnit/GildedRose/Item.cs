namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void UpdateItem()
    {
        var isAgedBrie = Name == "Aged Brie";
        
        if (isAgedBrie || Name == "Backstage passes to a TAFKAL80ETC concert")
        {
            if (Quality < 50)
            {
                Quality += 1;

                if (Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (SellIn < 11)
                    {
                        if (Quality < 50)
                        {
                            Quality += 1;
                        }
                    }

                    if (SellIn < 6)
                    {
                        if (Quality < 50)
                        {
                            Quality += 1;
                        }
                    }
                }
            }
        }
        else
        {
            if (Quality > 0)
            {
                if (Name != "Sulfuras, Hand of Ragnaros")
                {
                    Quality -= 1;
                }
            }
        }

        if (Name != "Sulfuras, Hand of Ragnaros")
        {
            SellIn -= 1;
        }

        if (SellIn < 0)
        {
            if (isAgedBrie)
            {
                if (Quality < 50)
                {
                    Quality += 1;
                }
            }
            else
            {
                if (Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Quality > 0)
                    {
                        if (Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Quality -= 1;
                        }
                    }
                }
                else
                {
                    Quality -= Quality;
                }
            }
        }
    }
}