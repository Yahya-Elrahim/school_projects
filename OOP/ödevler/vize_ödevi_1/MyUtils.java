/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaHomework;

public class MyUtils {
    
    
    // Üçgen çevresi hesplayan metot.
    public static float trianglePerimeter(float a, float b, float c)
    {
        return a + b + c;
    }
    
    // Üçgen alanı hesplayan metot.
    // Kenar uzunlukları bilinen bir üçgenin alanını hesaplama.
    public static float triangleArea(float a, float b, float c)
    {
        // Heron's formülü kullanarak üçgenin alanı hesaplayacağız.
        
        float s = (a + b + c) / 2;
        float temp = s*(s - b)*(s - b)*(s - c);
        return (float) Math.sqrt(temp); 
    }
   
    /** Çokgen çevresi hesaplayan overloading metotlar.
     * 
     * Çokgen çevresi hesaplamak için parametre olarak alınan değerlerin
     * sayısı belli olmadğından dolayı method overloading yönyemi kullandım.
     * Bu soruda 6 parametreli method overloading yazdım.
     */
    
    public static float polygonPerimeter(float a, float b, float c, float d)
    {
        return a + b + c + d;
    }
    public static float polygonPerimeter(float a, float b, float c, float d, float e)
    {
        return a + b + c + d + e;
    }
    public static float polygonPerimeter(float a, float b, float c, float d, float e, float f)
    {
        return a + b + c + d + f;
    }
     public static float polygonPerimeter(float a, float b, float c, float d, float e, float f, float g)
    {
        return a + b + c + d + f + g;
    }
     /**
      * Bu metodu sadece düzgün bir Çokgenin alanı hesaplamak için yazıldı.
      * Verilen soruda çok parametreli çokgenin alanı hesaplayan bir metot istendi.
      * ama burada çokgenın düzgün olduğundan iki parametreli tanımalaması yaterli olur.
      * @param sideLength
      * @param sideNumber
      * @return area
      * Eğer düzgün değilse farklı metot yazılaması gerekmektedir.
      */
    public static float polygonArea(float sideLength, int sideNumber)
    {
       float temp = sideNumber * (sideLength*sideLength);
       float area = temp / (4 * (float)Math.tan(Math.PI / sideNumber));
       
       return area;
    }
   
    /**
     * 1.fonksiyonun sonuc hesaplayan metot.
     * 𝑓(𝑥)=3𝑥2−2𝑒𝑥+√𝑥
     * @param x
     * @return 3 * x*x - 2 * Math.exp(x) + Math.sqrt(x);
     */
    private static double getFirstFunctionResult(double x)
    {
        return 3 * x*x - 2 * Math.exp(x) + Math.sqrt(x);
    }
    
    /**
     * 2.fonksiyonun sonuc hesaplayan metot.
     * 𝑓(𝑥)=1 / 1+𝑒^x
     * @param x
     * @return 1 / (1 + Math.exp(x));
     */
    private static double getSecondFunctionResult(double x)
    {
        return 1 / (1 + Math.exp(x));
    }
     
    /**
     * -100 ile 100 arasındaki tamsayıları dizi şeklinde giriş olarak
     * alıp fonkisyonlara göderip, sonucu bir dizide saklayıp döndüren bir metot.
     * @param array
     * @return array
     */
    public static double [] functionsResult(int [] array)
    {
        // result dizisi; fonkisyon sonçları saklamak için.
        // [i].index 1.fonkisyon, [i].index 2.fonksiyon sonucu şekilinde
        double [] result = new double[array.length*2];
        int index = 0;
        for(int i = 0; i < array.length; i ++)
        {
            result[index] = getFirstFunctionResult(i);
            index += 2;
        }
        
        index = 1;
         for(int i = 1; i < array.length; i ++)
        {
            result[index] = getSecondFunctionResult(i);
            index += 2;
        }
        return result;
    }
    
    
}
