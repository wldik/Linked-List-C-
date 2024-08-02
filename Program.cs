LinkedList list = new LinkedList();

list.addElement(10);
list.addElement(20);
list.addElement(30);

Console.WriteLine("List:");
list.printList();

list.removeNumberOfElem(2);

Console.WriteLine("List after removing elements:");
list.printList();
