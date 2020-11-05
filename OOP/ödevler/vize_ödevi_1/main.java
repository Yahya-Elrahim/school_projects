
package javaHomework;


public class Main {

 
    public static void main(String[] args) {
        // MyUtils class'ında metotla static olarak tanımlandığından
        // nesne oluşturmaya gerek kalmadan sınıf üzerinden çağirabliliriz.
        float trianglePerimeter = MyUtils.trianglePerimeter(3, 3, 3);
        System.out.print("The perimeter of the triangle is: " + trianglePerimeter + "\n");
        
        float triangleArea = MyUtils.triangleArea(3, 3, 3);
        System.out.print("The area of the triangle is: " + triangleArea + "\n");
        
         float polygonPerimeter = MyUtils.polygonPerimeter(5, 10, 4, 8);
        System.out.print("The perimeter of the plygon is: " + polygonPerimeter + "\n");
        
         float polygonArea = MyUtils.polygonArea(10, 6);
        System.out.print("The area of the plygon is: " + polygonArea + "\n");
        
        
        
        
        // -100 ile 100 arasında tutan dizi
        int [] array = new int[201];
        int temp = -100; 
        for(int i = 0; i < array.length; i++)
        {
            array[i] = temp;
            temp ++;
        }
        
        double [] results = MyUtils.functionsResult(array);
        
        for(int i = 0; i < results.length; i++)
        {
            System.out.print(results[i] + "\n");
            
        }
        
        
        
    }
      
    
}
