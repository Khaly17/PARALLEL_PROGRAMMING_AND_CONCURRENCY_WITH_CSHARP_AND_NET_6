    Contact contact1 = new Contact();
    Contact contact2 = new Contact();
    Contact contact3 = new Contact();

    contact1.PhoneNumber = "221778890922";
    contact2.PhoneNumber = "221768890926";
    contact3.PhoneNumber = "221708890920";

    List<Contact> contactList = new List<Contact>();
    contactList.Add(contact1);
    contactList.Add(contact2);
    contactList.Add(contact3);

    ContactListManager contactListManager = new ContactListManager(contactList);

    contactListManager.AddContact(contact1);

    foreach (var contact in contactList)
    {
        Console.WriteLine(contact.PhoneNumber);
    }
    
    Console.WriteLine(contactListManager.GetContactByPhoneNumber(contact1.PhoneNumber));