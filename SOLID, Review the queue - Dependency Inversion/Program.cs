using SOLID__Review_the_queue___Dependency_Inversion;

var arrayStorageInteger = new ArrayStorage<int>(10);

arrayStorageInteger.Queue(1);
arrayStorageInteger.Queue(2);
arrayStorageInteger.Queue(3);

arrayStorageInteger.Dequeue();
arrayStorageInteger.Peek();

//-------------------------------------------

var arrayStorageString = new ArrayStorage<string>(10);

arrayStorageString.Queue("Marco");
arrayStorageString.Queue("Luca");
arrayStorageString.Queue("Mario");

arrayStorageString.Dequeue();
arrayStorageString.Peek();
