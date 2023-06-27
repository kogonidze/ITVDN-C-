using DocumentWorkerApp.Models;

Console.WriteLine("Для регистрации данного продукта введите лицензионный ключ");
var key = Console.ReadLine();

DocumentWorker worker;

switch (key)
{
    case "PRO":
        worker = new ProDocumentWorker();
        break;

    case "EXPERT":
        worker = new ExpertDocumentWorker();
        break;

    default:
        worker = new DocumentWorker();
        break;
}

worker.OpenDocument();
worker.EditDocument();
worker.SaveDocument();

Console.ReadKey();