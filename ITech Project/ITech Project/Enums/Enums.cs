namespace ITech_Project.Enums
{
    public enum Color: byte
    {
       Red = 1 ,
       Black = 2,
       Blue = 4,
       Gray = 8
    }
    public enum Payment : byte
    {
        Visa = 1 ,
        Paypal = 2 ,
        Fawry = 3 ,
        Aman = 4 ,
        CashOnDeliverd = 5 ,
    }
    public enum Category : byte
    {
        Laptop = 1 ,
        Phone = 2 ,
    }
    public enum ModelLabtop : byte
    {
        Hp = 1 ,
        Dell = 2 ,
        Toshiba = 3 ,
        Lenovo = 4 ,
        Mac = 5 ,
        Acer = 6 ,
        Samsung = 7 ,
        MSI = 8 ,
        Asus = 9 ,
        MicrosoftSurface = 10 ,
    }
    public enum ModelMobile : byte
    {
        Huawei = 1 ,
        Samsung = 2 ,
        IPhone = 3 ,
        Oppo = 4 ,
        Realme = 5 ,
        xiaomi = 6 ,
        Redmi = 7 ,
        Nokia = 8 ,
    }
    public enum Shipper : byte
    {
        Alborak = 1 ,
        Altayar = 2 ,
        Aramix = 3 ,
        Mashawier = 4 ,
        Engiziny = 5 ,
        ExpressCairo = 6 ,
    }
}
