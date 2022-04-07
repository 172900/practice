public class HashTable
{
    private int size { get; set; }
    private LinkedList<Node>[] linkedList { get; set;}
    public HashTable(int size)
    {
        this.linkedList = new LinkedList<Node>[size];
        this.size = size;
    }

    public void setValue(string key, string value) {
        int hash = getHashCode(key);
        int index = getIndex(hash);

        if (this.linkedList[index] == null) {
            this.linkedList[index] = new LinkedList<Node>();
            this.linkedList[index].AddLast(new Node(key, value));
        } else {
            this.linkedList[index].AddLast(new Node(key, value));
        }
    }

    public string getValue(string key) {
        int hash = getHashCode(key);
        int index = getIndex(hash);
         if (this.linkedList[index] == null) {
             return "값없음";
         } else {
             return searchKey(this.linkedList[index], key);
         }
    }

    public string searchKey(LinkedList<Node> list, string key) {
        foreach (Node item in list) {
            if (item.key.Equals(key)) {
                return item.value;
            }
        }
        return "값 없음";
    }

    private int getHashCode(string key) {
        int result = 0;
        foreach(char character in key) {
            result += character;
        }
        return result;
    }

     private int getIndex(int hashCode) {
        int index = hashCode % linkedList.Length;
        return index;
    }
}