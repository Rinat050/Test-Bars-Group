using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Entity>()
            {   new Entity { Id = 1, ParentId = 0, Name = "Root entity"},
                new Entity { Id = 2, ParentId = 1, Name = "Child of 1 entity"},
                new Entity { Id = 3, ParentId = 1, Name = "Child of 1 entity"},
                new Entity { Id = 4, ParentId = 2, Name = "Child of 2 entity"},
                new Entity { Id = 5, ParentId = 4, Name = "Child of 4 entity"}
            };

            var dict = Group(list);

        }
        public static Dictionary<int, List<Entity>> Group(List<Entity> list)
        {
            var dictionary = new Dictionary<int, List<Entity>>();

            foreach (Entity entity in list)
            {
                int parentId = entity.ParentId;

                if (!dictionary.ContainsKey(parentId))
                {
                    dictionary.Add(parentId, new List<Entity>());
                }

                dictionary[parentId].Add(entity);
            }

            return dictionary;
        }
    }
}