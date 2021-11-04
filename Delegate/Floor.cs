using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Floor
    {
        public List<Item> onFloor = new List<Item>();
        public void SaveDropItems(Item item)
        {
            onFloor.Add(item);
        }
        public Item GiveFirstItems()
        {
            if (onFloor.Count != 0)
            {
                for (int i = 0; i < onFloor.Count; i++)
                {
                    Item item = onFloor[i];
                    onFloor.Remove(onFloor[i]);
                    return item;
                }
            }
            return default;
        }
    }
}
