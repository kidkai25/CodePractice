function SayHello(firstName: string, lastName: string) :string
{
    var message: string = "Hello World";
    message += firstName + " " + lastName;
    //alert(message);
    return message;
}

alert(SayHello("Shad", "Kidwai"));