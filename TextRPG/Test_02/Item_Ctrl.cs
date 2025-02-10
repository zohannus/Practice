using System;
using System.Data.Common;


struct Item
{
    public int id;
    public string name;
    public int price;
    public float damage;
    public float amr;
}

class ItemList
{
    public Item[] itemList = new Item[6];
    public ItemList()
    {
        itemList[0].id = 0;
        itemList[0].price = 10;
        itemList[0].name = "멋진 칼";
        itemList[0].damage = 10;
        itemList[0].amr = 0;

        itemList[1].id = 1;
        itemList[1].price = 100;
        itemList[1].name = "짱쎈 검";
        itemList[1].damage = 10;
        itemList[1].amr = 0;

        itemList[2].id = 2;
        itemList[2].price = 1000;
        itemList[2].name = "슈퍼 활";
        itemList[2].damage = 10;
        itemList[1].amr = 0;

        itemList[3].id = 3;
        itemList[3].price = 10000;
        itemList[3].name = "단단 방패";
        itemList[2].damage = 0;
        itemList[3].amr = 5;

        itemList[4].id = 4;
        itemList[4].price = 100000;
        itemList[4].name = "합금 갑옷";
        itemList[2].damage = 0;
        itemList[4].amr = 10;

        itemList[5].id = 5;
        itemList[5].price = 100000;
        itemList[5].name = "대단한 반지";
        itemList[5].damage = 2;
        itemList[5].amr = 2;
    }

}

class BagCtrl
{
    ItemList list = new ItemList();
    public int count = 0;
    public int number = 0;
    public Item[] bag = new Item[10];
    public bool ShopCan = true;

    public void Bag()
    {
        Console.Clear();

        if (count == 0)
        {
            Console.WriteLine("가방이 비어있습니다.");
            return;
        }
        Console.WriteLine("장비 이름 / 판매 가격");
        for (int i = 0; i < count; i++)
        {
           Console.WriteLine($"{i+1} {bag[i].name}, {bag[i].price}");
        }
    }
}

