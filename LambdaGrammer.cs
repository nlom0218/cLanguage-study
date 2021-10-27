using System;
using System.Collections.Generic;

namespace HelloWord
{
  enum ItemType
  {
    Weapon,
    Armor,
    Amulet,
    Ring
  }
  enum Rarity
  {
    Normal,
    Uncommon,
    Rare
  }
  class Item
  {
    public ItemType ItemType;
    public Rarity Rarity;
  }
  class LambdaGrammer
  {
    static List<Item> _items = new List<Item>();
    static Item FindItem(Func<Item, bool> selector)
    {
      foreach (Item item in _items)
      {
        if (selector(item))
          return item;
      }
      return null;
    }

    public void Lambda()
    {
      // Lambda : 일회용 함수를 만드는데 사용하는 문법이다.

      _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
      _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
      _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

      Item item = FindItem(delegate (Item item)
      // Anonymous Function : 무명 함수 / 익명 함수
      {
        return item.ItemType == ItemType.Weapon;
      });

      // delegate를 직업 선언하지 않아도, 아미 만들어진 애들이 존재한다.
      // -> 반환 타입이 있을 경우 Func
      // -> 반환 타입이 없으면 Action
      Func<Item, bool> selector = (Item item) => { return item.Rarity == Rarity.Rare; };
      Item item2 = FindItem((Item item) => { return item.Rarity == Rarity.Rare; });
    }
  }
}