namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {            
            HashTable hashTable = new HashTable(3);
            
            hashTable.setValue("전재웅", "잘거임");
            hashTable.setValue("온잇", "낙성대역에 있습니다.");
            hashTable.setValue("간짬뽕", "맛있음");
            
            string result1 = hashTable.getValue("온잇");
            string result2 = hashTable.getValue("간짬뽕");
            string result3 = hashTable.getValue("전재웅");
            string result4 = hashTable.getValue("지코");

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}