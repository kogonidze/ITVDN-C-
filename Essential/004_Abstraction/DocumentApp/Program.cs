using DocumentApp.Document;
using DocumentApp.Parts;

var title = new Title();
title.Content = "Контракт";

var body = new Body();
body.Content = "Тело контракта...";

var footer = new Footer();
footer.Content = "Директор: Иванов И.И.";

var document = new Document(title, body, footer);
document.Show();

Console.ReadKey();