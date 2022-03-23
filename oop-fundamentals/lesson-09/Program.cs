namespace lesson_09

{
    class Program
    {
        static void SentEmail(string to, string subject, string body)
        {
            System.Console.WriteLine($"Sending email to {to} with subject {subject} and body {body}");
        }
        static void Main(string[] args)
        {
            SentEmail(body: "Hello", subject: "Hi", to: "mmagnani@gmail.com");
            SentEmail(to: "maria@hotmai.com", subject: "Hi", body: "Hello");
            SentEmail(subject: "Hi", to: "paulo@ig.com.br", body: "Hello");
        }
    }
}