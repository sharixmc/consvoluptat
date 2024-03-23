using (XmlWriter writer = XmlWriter.Create("employees.xml"))
{
    writer.WriteStartDocument();
    writer.WriteStartElement("Employees");

    // Example of writing an employee element
    writer.WriteStartElement("Employee");
    writer.WriteElementString("ID", "1");
    writer.WriteElementString("FirstName", "John");
    writer.WriteElementString("LastName", "Doe");
    writer.WriteEndElement();

    // Continue adding other employees

    writer.WriteEndElement();
    writer.WriteEndDocument();
}
