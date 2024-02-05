Database db = Database.GetInstance();

db.Query("SELECT * FROM tabla");

var subject = new Subject();

var observerOne = new ConcreteObserverOne();
var observerTwo = new ConcreteObserverTwo();

subject.Attach(observerOne);
subject.Attach(observerTwo);

subject.SomeBusinessLogic();

subject.Detach(observerOne);

subject.SomeBusinessLogic();

