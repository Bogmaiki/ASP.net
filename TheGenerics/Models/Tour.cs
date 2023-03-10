public class Tour
{
      public int ID { get; set; }
      public   string  Date {get;set;}
      public   string  City {get;set;}
      public   string  Arena {get;set;}

      public Tour(int ID, string Date, string City , string Arena){
            this.Date= Date;
            this.City= City;
            this.Arena= Arena;
            this.ID = ID;
      } 
}


static  class TourDB
{
    static private Tour [] allTours= new Tour[8];

    static TourDB(){

       allTours[0]=  new Tour(1,"JAN 1", "LAS VEGAS, NV", "T-MOBILE ARENA");
       allTours[1]= new Tour(2,"JUL 16", "DETROIT, MI", "DTE ENERGY MUSIC THEATRE");
        allTours[2]= new Tour(3,"JUL 18", "TORONTO, ON", "BUDWEISER STAGE");
        allTours[3]= new Tour(4,"JUL 22", "BRISTOW, VA", "JIGGY LUBE LIVE");
        allTours[4]= new Tour(5,"JUL 29", "PHOENIX, AZ", "AK-CHIN PAVILION");
        allTours[5]= new Tour(6,"AUG 2", "LAS VEGAS, NV", "T-MOBILE ARENA");
        allTours[6] = new Tour(7,"AUG 7", "CONCORD, CA", "CONCORD PAVILION");
        allTours[7] = new Tour(8,"AUG 28", "LAS VEGAS, NV", "T-MOBILE ARENA");
    }

    public static Tour[] GetAllTours() {
        return allTours;
    }

}