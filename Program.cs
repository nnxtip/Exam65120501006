class Program {
    static void Main(string[] args) {
        int dayofweek = 0;
        int timeofday = 0;
        int breakfastset = 5;
        int weekendset = 2;
        int coffee = 3;

        while (true){
            Console.Write("Order Day of Week 1-7! : ");
            dayofweek = int.Parse(Console.ReadLine());
            Console.Write("Order Time Of Day 8-18! : ");
            timeofday = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose Your Meal!");
            Console.Write("Breakfast Set ,Weekend Set ,Coffee , End : ");
            string GrabOrder = Console.ReadLine();
            if (GrabOrder == "End"){
                break;                
            }
            switch (GrabOrder){
                case "Breakfast Set":
                if (timeofday > 11){
                    Console.WriteLine("Sorry your order is not available!");
                    break;
                }
                if (breakfastset == 0){
                    Console.WriteLine("Sorry your order is out of stock!");
                    break;
                }
                breakfastset--;
                Console.WriteLine("Order Successful!: Breakfast Set!");
                break;
                case "Weekend Set":
                if (dayofweek <= 5){
                    Console.WriteLine("Sorry your order is not available!");
                    break;
                }
                if (weekendset == 0){
                    Console.WriteLine("Sorry your order is out of stock!");
                    break;
                }
                weekendset--;
                Console.WriteLine("Order Successful!: Weekend Set!");
                break;
                case "Coffee":
                if (coffee == 0){
                    Console.WriteLine("Sorry your order is out of stock!");
                    break;
                }
                coffee--;
                Console.WriteLine("Order Successful!: Coffee!");
                break;
                
                default:
                Console.WriteLine("Please enter a valid menu! TT");
                break;
            }
        }
    }
}