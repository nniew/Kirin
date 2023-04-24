using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter number of items in bag: ");
        int numberOfItems = Convert.ToInt32(Console.ReadLine());
        
        string[] itemNames = new string[numberOfItems];
        string[] itemTypes = new string[numberOfItems];

        // รับค่ารายละเอียดของไอเทมที่ใส่ลงในกระเป๋า
        for (int i = 0; i < numberOfItems; i++) {
            Console.WriteLine($"Enter details for item {i + 1}:");

            Console.Write("Item name: ");
            string itemName = Console.ReadLine();

            // ตรวจสอบว่าชื่อไอเทมนี้มีอยู่แล้วหรือไม่
            if (Array.IndexOf(itemNames, itemName) >= 0) {
                Console.WriteLine("Item name already exists!");
                i--;
                continue;
            }

            Console.Write("Item type: ");
            string itemType = Console.ReadLine();

            itemNames[i] = itemName;
            itemTypes[i] = itemType;
        }

        // หากผู้ใช้กรอก "ShowAll" ให้แสดงรายการทั้งหมด
        // หากผู้ใช้กรอกประเภทของไอเทม ให้แสดงรายการที่ตรงกับประเภทนั้น
        while (true) {
            Console.Write("Enter search mode ('ShowAll' or item type): ");
            string searchMode = Console.ReadLine();

            if (searchMode.Equals("ShowAll")) {
                for (int i = 0; i < numberOfItems; i++) {
                    Console.WriteLine($"{itemNames[i]} ({itemTypes[i]})");
                }
            }
            else if (Array.IndexOf(itemTypes, searchMode) >= 0) {
                for (int i = 0; i < numberOfItems; i++) {
                    if (itemTypes[i].Equals(searchMode)) {
                        Console.WriteLine($"{itemNames[i]}");
                    }
                }
            }
            else {
                Console.WriteLine("End");
                break;
            }
        }
    }
}