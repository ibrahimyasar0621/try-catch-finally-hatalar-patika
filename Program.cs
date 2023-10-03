namespace hata_yonetimi;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());      // konsoldan girdiği değeri integer a kest ediyoruz..
            Console.WriteLine("Girmiş olduğunuz sayı; " + sayi); // burada hata alıyoruz çünkü konsoldan girilen sayı  olursa olsun integer32 ye kest ediyor. try bloğuna alma sebebimizde bu aslında. integere çevrilemeyen bir değer gelirsse hata alma ihtimaimiz olması.

        }
        catch(Exception ex)
        {
            Console.WriteLine("hata ;" + ex.Message.ToString()); //hata alınca ne yapmasını istiyorsan CATHT bloğuna yazıyorsun hata mesajım(Message) tostring e kest edip bana hatayı ekrana yazdırır.
  
        }
        // finally
        // {
            Console.WriteLine("İşlem tamamlandı.");   //kod hata alsın almasın koşullardan bağımsız ne yapmasını istiyorsan FINALLY  bloğuna yaz. kod hata alsın almasın  ben ekrana işlem tamamlandı mesajı yazdırmak istedik. Zorunlu değil kapatabilirsin.
            //Bir sayı giriniz
            //3 
            //Girmiş olduğunuz sayı; 3 
            //İşlem tamamlandı

            //Bir sayı giriniz
            //ibrahim (string bir ifade girdim int32 çevrilmez bir ifade bakalım hata alınca neolacak)
            //hata ; The input string 'ibrahim' was not in a correct formaz
            //İşlem tamamlandı
        // }
        try
            {
                int a = int.Parse(null);  // mesela integer'ı null ı integer'a çevirmek istedim

            }
            catch (ArgumentNullException ex)   // burada fırlatacağı exception(çalışma durumunda çıkacak hata demek) nullexception boş değer hattası.
            {   
                Console.WriteLine("Boş değer girdiniz");   
                Console.WriteLine(ex); 
                // çıktı
                // Boş değer girdiniz
                // System.ArgumentNullException: Value cannot be null.      
            }




            try
            {
                int a = int.Parse("test");  // bu sefer string bir ifade verdik integer a pars edilemeyen dönüşmeyen bir ifade.
                
            }
            catch (FormatException ex)     // burada fırlatacağı exception(çalışma durumunda çıkacak hata demek) formatexception uygun olmayan format hattası. 
            {   
                Console.WriteLine("veri tipi uygun değil");   
                Console.WriteLine(ex);
                // çıktı
                // veri tipi uygun değil 
                // System.FormatException: The input string 'test' was not in a correct format.       
            }


            try
            {
                int a = int.Parse("-200000000000");  // bu sefer string bir ifade verdik integer sınırları içerisinde değil çok büyük yada çok küçük bir değer girdik
                
            }
            catch (OverflowException ex)     // burada fırlatacağı exception(çalışma durumunda çıkacak hata demek) owerflowexception desteklenen aralıkta olmayan değer  
            {   
                Console.WriteLine("çok küçük yada çok büyük deer girdiniz");   
                Console.WriteLine(ex);
                // çıktı
                // çok küçük yada çok büyük deer girdiniz
                // System.OverflowException: Value was either too  large or too small for an Int32.       
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı");
            }
        
    }
}
