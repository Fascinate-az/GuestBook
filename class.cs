namespace ConsoleApp2;

public class GuestBook
{
    public static void Run()
    {
        int numeroPartecipantiInCoda = PartecipantiInCoda();
        int FamigliePartecipanti = 0;
        int TotalePartecipanti = 0;
        var listaTotalePartecipanti = ListaTotalePartecipanti();

        if (numeroPartecipantiInCoda > 0)
        {
            while (numeroPartecipantiInCoda > 0)
            {
                Messaggi.Benvenuto();
                Messaggi.AskName();
                string cognomeFamiglia = RegistrareCognomeFamiglia.RegistrareCognome();
                Messaggi.ChiederePartecipanti(cognomeFamiglia);
                int numeroPartecipanti = NumeroPartecipanti.nrPartecipanti();
                var listaNomi = NomePartecipanti.ListaNomiPartecipanti(numeroPartecipanti);
                Messaggi.ConfermaTuttiPartecipantiInseriti(numeroPartecipanti, cognomeFamiglia);
                PrintLista.StampaLista(listaNomi,cognomeFamiglia);
                MergeList.IntoToFinalList(listaNomi,listaTotalePartecipanti,cognomeFamiglia);
                
            
                numeroPartecipantiInCoda--;
                FamigliePartecipanti++;
                TotalePartecipanti += numeroPartecipanti;
            }
        }

        else
        {
            Messaggi.NessunPartecipanteInCoda();
        }

        if (FamigliePartecipanti > 0)
        {
            Messaggi.NumeroTotaleFamiglieEPartecipanti(FamigliePartecipanti,TotalePartecipanti);
            PrintLista.StampaListaFinale(listaTotalePartecipanti);
        }        
    }
    
    public static int NumeroMinimoPartecipanti()
    {
        int numeroMinimoPartecipanti = 1;
        return numeroMinimoPartecipanti;
    }

    public static int PartecipantiInCoda()
    {
        int numeroPartecipantiInCoda = 3;
        return numeroPartecipantiInCoda;
    }

    public static List<string> ListaTotalePartecipanti()
    {
        List<string> listaTotalePartecipanti = new List<string>();
        
        return listaTotalePartecipanti;
    }
    
    
}
