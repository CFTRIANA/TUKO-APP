using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Descripción breve de Email
/// </summary>
public class Email
{
    private SmtpClient cliente;
    private MailMessage email;
    private string Host = "smtp.gmail.com";
    private int Port = 587;
    private string User = "owlblack10@gmail.com";
    private string Password = "epbmvlidbkezsjlf";//Contraseña de Aplicación
    private bool EnabledSSL = true;
    public Email()
    {
        cliente = new SmtpClient()
        {
            Host = Host,
            Port = Port,
            EnableSsl = EnabledSSL,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = true,
            Credentials = new NetworkCredential(User, Password)
        };
    }
    public void EnviarCorreo(string destinatario, string asunto, string mensaje, bool esHtml = false)
    {
        email = new MailMessage(User, destinatario, asunto, mensaje);
        email.IsBodyHtml = esHtml;
        cliente.Send(email);
    }
}