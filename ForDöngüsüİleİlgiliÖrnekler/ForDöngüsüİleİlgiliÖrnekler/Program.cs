//  FOR

/*

// 1) 1'den 10'a kadar olan sayıları ekrana yazdıran program:
 
int i;

for (i= 1; i <= 10; i++)

{

    Console.WriteLine(i);

}

*/

/*

// 2)  20'den küçük pozitif tek sayıları ekrana yazdıran program:

int i;

for (i = 19; i >= 1; i-=2)

{

    Console.WriteLine(i);

}

*/

/*

// 3) 10'dan geriye doğru 1'e kadar olan sayıları ekrana yazdıran program:

int i;

for (i = 10; i >= 1; i--)

{

    Console.WriteLine(i);

}

*/

/*

// 4) i klavyeden girilen pozitif bir sayı 1'den i'ye kadar olan sayıları yazan program:

int i, j;

Console.Write("i sayısını giriniz: ");

i= Convert.ToInt32(Console.ReadLine());

for (j = 1; j <=i; j++)

{

    Console.WriteLine(j);

}

*/

/*

// 5) Klavyeden a ve b giriliyor a , b'den küçük a'dan b'ye kadar olan sayıları ekrana yazan program:

int a, b;

Console.Write("A sayısını giriniz: ");

a=Convert.ToInt32(Console.ReadLine());

Console.Write("B sayısını giriniz: ");

b=Convert.ToInt32(Console.ReadLine());

for (a = a; a <= b; a++)

{

    Console.WriteLine(a);

}

*/


/*

// 6) Klavyeden a ve b giriliyor a>b a=b a<b olabilir.Her durumda a'dan b'ye kadar olan sayıları yazan program:

int a, b, c ;

Console.Write("A sayısını giriniz: ");

a = Convert.ToInt32(Console.ReadLine());

Console.Write("B sayısını giriniz: ");

b = Convert.ToInt32(Console.ReadLine());

if (a < b)

{

    for (c = a; c <= b; c += 1)

    {

        Console.WriteLine(c);

    }

}

else

{

    for(c=a;c >= b; c -= 1)

    {

        Console.WriteLine(c);

    }

}

*/

/*

// 7) i kalvyeden girilen pozitif bir sayıdır i çift ise 0'dan i'ye kadar olan çift sayılar , i tek ise 1'den i'ye kadar olan sayıları bulan program:

int i,j;

Console.Write("i sayısını giriniz: ");

i = Convert.ToInt32(Console.ReadLine());


if (i % 2 == 0)

{

    for (j = 0; j <= i; j+=2)

    {

        Console.WriteLine(j);

    }

}

else

{

    for(j = 1; j <= i; j +=2)

    {

        Console.WriteLine(j);

    }

}

 

*/

// 8) // Klavyeden a ve b giriliyor a<b a ile b arasındaki 5'in katlarını ekrana yazdıran program:

/*

int a, b,i;

Console.Write("a sayısını giriniz: ");

a=Convert.ToInt32(Console.ReadLine());


Console.Write("b sayısını giriniz: ");

b=Convert.ToInt32(Console.ReadLine());

if (a < b)

{

    Console.WriteLine("a ile b arasindaki 5'in katları:");

    for (i = a; i <= b; i++)

    {

        if (i % 5 == 0)

        {

            Console.WriteLine(i);

        }

    }

}

 

*/

/*


// 9) 1 ile 100 arasındaki 3,4,5'in katlarını ekrana yazdıran program:


int i;

for (i = 1; i <= 100; i++)

{

    if(i % 3 == 0)

    {

        Console.WriteLine(i);

    }

    if(i % 4 == 0) {

        Console.WriteLine(i);

    }

    if(i % 5 == 0) {

        Console.WriteLine(i);

    }

  
}

*/

/*

// 10) 9. sorunun sayılarının tekrarsız hali 

int i;

for (i = 1; i <= 100; i++)

{

    if (i % 3 == 0)

    {

        Console.WriteLine(i);


    }

   else  if (i % 4 == 0)

    {

        Console.WriteLine(i);

    }

    else if (i % 5 == 0)

    {

        Console.WriteLine(i);

    }

}

*/



/*


// 11) n klavyeden girilen pozitif bir sayı 1'den i'ye kadar olan sayıların toplamını bulan program:

int n, toplam, i;


Console.Write("Lütfen bir sayı girin: ");

n = Convert.ToInt32(Console.ReadLine());


toplam = 0;

for ( i = 1; i <= n; i++)

{

    toplam =toplam+ i;

}

Console.WriteLine("1'den " + n + "'e kadar olan sayıların toplamı: " + toplam);

*/


/*

// 12) Klavyeden girilen 5 sayının toplamını yazan program:

int i, j, toplam;

toplam = 0;

for (i = 1; i <= 5; i++)

{

    Console.Write("Sayı giriniz: ");

    j=Convert.ToInt32(Console.ReadLine());

    toplam = toplam + i;

}

Console.Write(toplam);

*/
