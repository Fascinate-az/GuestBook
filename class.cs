using System.Globalization;

namespace ConsoleApp2;

public static class Messaggi
{
    public static void Benvenuto()
    {
        Console.WriteLine("Benvenuti e grazie per partecipare all'evento");
    }

    public static void AskName()
    {
        Console.WriteLine("Potrei avere il cognome della famiglia per registrarvi all'evento?");
    }

    public static void ChiederePartecipanti(string cognome)
    {
        Console.WriteLine($"grazie famiglia {cognome},quanti partecipanti siete?");
    }
    
    public static void ConfermaNumeroPartecipanti(int nr)
    {
        Console.WriteLine($"Bene siete in {nr},mi ora per registrarvi mi serve il  nome dei partecipanti?");
    }

    public static void PartecipanteAggiunto()
    {
        Console.WriteLine("partecipante aggiunto con successo");
    }

    public static void ConfermaTuttiPartecipantiInseriti(int nr,string cognome)
    {
        Console.WriteLine($"Perfetto tutti i {nr} partecipanti della famiglia {cognome} sono stati aggiunti con successo all'evento");
    }

    public static void ErroreInputNonValido()
    {
        Console.WriteLine("Errore,Inserire un valore numerico");
    }

    public static void ListaPartecipantiFamiglia()
    {
        Console.WriteLine("Registrazione avvenuta con successo, questa è la lista dei partecipanti della vostra famiglia:");
    }

    public static void NumeroMinimoDiPartecipanti(int numeroPartecipantiMinimo)
    {
        Console.WriteLine($"Errore, il numero dei partecipanti deve essere minimo {numeroPartecipantiMinimo}");
    }

    public static void Grazie()
    {
        Console.WriteLine("grazie per aver usato la nostra app di registrane");
    }

    public static void RegistrazioneSuccesso()
    {
        Console.WriteLine("registrazione effettuata con successo");
    }

    public static void NessunPartecipanteInCoda()
    {
        Console.WriteLine("Nessun partecipante in coda");
    }

    public static void NumeroTotaleFamiglieEPartecipanti(int numeroFamigliePartecipanti,int numeroPartecipanti)
    {
        Console.WriteLine($"il numero delle famiglie partecipanti è di {numeroFamigliePartecipanti} per un totale di {numeroPartecipanti} Partecipanti,di seguito i nomi:");
    }
    
}

public static class RegistrareCognomeFamiglia
{
    public static string RegistrareCognome()
    {
        string cognome = Console.ReadLine();
        
        return cognome;
    } 
}

public static class NumeroPartecipanti
{
    public static int nrPartecipanti()
    {
        bool loop = true;
        bool isValid = int.TryParse(Console.ReadLine(), out int number);
        int numeroMinimo = GuestBook.NumeroMinimoPartecipanti();

        while(loop)
        {
            if (!isValid)
            {
                Messaggi.ErroreInputNonValido();
                isValid = int.TryParse(Console.ReadLine(), out number);  
            }
            else if (number < 1)
            {
                Messaggi.NumeroMinimoDiPartecipanti(numeroMinimo);
                isValid = int.TryParse(Console.ReadLine(), out number);  
            }

            else
            {
                Messaggi.ConfermaNumeroPartecipanti(number);
                loop = false;
            }
            
                
            
        }
        
       
        
        return number;
    } 
}

public static class NomePartecipanti
{
    public static List<string> ListaNomiPartecipanti(int numeroPartecipanti)
    {
        int counter = 0;
        string nome;
        List<string>Partecipanti = new List<string>();

        while (counter < numeroPartecipanti)
        {
            nome = Console.ReadLine();
            Messaggi.PartecipanteAggiunto();
            Partecipanti.Add(nome);
            counter++;
        }
        
        return Partecipanti;
    }
}

public static class PrintLista
{
    public static void StampaLista(List<string> listaFamiglia,string cognome)
    {
        Messaggi.ListaPartecipantiFamiglia();

        foreach (string item in listaFamiglia)
        {
            Console.WriteLine($"{item} {cognome}");
        }
    }

    public static void StampaListaFinale(List<string> listaFamigliaFinale)
    {
        foreach (string item in listaFamigliaFinale)
        {
            Console.WriteLine(item);
        }
    }
    
}

public static class MergeList
{

    public static void IntoToFinalList(List<string> listaFamiglia,List<string>listaFinale,string cognome)
    {
        foreach (string item in listaFamiglia)
        {
            
            listaFinale.Add($"{item} {cognome}");
        }
        
        listaFinale.Sort();
    }
}


