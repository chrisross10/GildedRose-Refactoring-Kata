namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void UpdateItem()
    {
        var isAgedBrie = Name == "Aged Brie";
        var isBackstagePasses = Name == "Backstage passes to a TAFKAL80ETC concert";
        var isNotSulfuras = Name != "Sulfuras, Hand of Ragnaros";

        if (isAgedBrie)
        {
            UpdateQuality();

            SellIn -= 1;

            if (SellIn < 0)
            {
                UpdateQuality();
            }
        }
        else
        {
            if (isBackstagePasses)
            {
                if (Quality < 50)
                {
                    Quality += 1;

                    if (SellIn < 11)
                    {
                        UpdateQuality();
                    }

                    if (SellIn < 6)
                    {
                        UpdateQuality();
                    }
                }

                SellIn -= 1;

                if (SellIn < 0)
                {
                    Quality -= Quality;
                }
            }
            else
            {
                if (isNotSulfuras)
                {
                    if (Quality > 0)
                    {
                        Quality -= 1;
                    }

                    SellIn -= 1;

                    if (SellIn < 0)
                    {
                        if (Quality > 0)
                        {
                            Quality -= 1;
                        }
                    }
                }
            }
        }
    }

    private void UpdateQuality()
    {
        if (Quality < 50)
        {
            Quality += 1;
        }
    }
}