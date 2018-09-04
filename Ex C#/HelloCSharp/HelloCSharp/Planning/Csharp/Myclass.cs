using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning.Csharp
{
    class Myclass
    {
      static void Main(string[]args)
        {
            Console.WriteLine("Hello from MyClass");
            Console.ReadLine();
        }
    }
    class VaribleExample
    {
        static void Main(string[] args)
        {
            //Khai báo hằng số kiểu int
            const int MaxScore = 100;
            // Khai báo 1 biến kiểu int
            int score = 0;
            // Gán giá trị mới cho biến
            score = 90;
            // Khai báo một chuỗi
            string studentName = "Nguyen Văn A";
            // in giá trị ra khỏi màn hình
            Console.WriteLine("Hi{0}", studentName);
            Console.WriteLine("Score:{0}/{1}", score, MaxScore);
            // chờ người dùng  nhập vào gì đó và nhấn enter trước khi kêt thúc chương trình
            Console.ReadLine();
        }
    }
    //cú pháp?
    //condition: điều kiện để kiểm tra
    class IfElseExample
    {
        static void Main(string[] args)
        {
            ham();
            Console.WriteLine("Ban muon nhap lai?");
            string nhap = Console.ReadLine();
            if (nhap=="N")
            {
                Environment.Exit(0);
            }
            else if(nhap=="Y")
            {
                ham();

            }
        }
        static void ham()
        {
             // Khai báo tuổi kiểu int
            int age;
            Console.WriteLine("Please enter your age: \n");
            // Khai báo biến để lưu trữ đoạn text người dùng nhập từ bàn phím
            string inputStr = Console.ReadLine();

            //int32 là 1 lớp nằm trong namspace system
            // sử dụng phương thức tĩnh parse của int32 để chuyển 1 chuỗi thành 1 số và gán biển vào age
            age = Int32.Parse(inputStr);
            Console.WriteLine("Your age:{0}", age);

            //Kiểm tra nếu tuổi nhỏ hơn 60
            if (age < 60)
            {
                Console.WriteLine("You are pretty young");
            }

            //tuổi lớn hơn 60 và nhỏ hơn 100
            else if (age > 60 && age <= 100)
            {
                Console.WriteLine("You are old");
            }
            else
            {
                Console.WriteLine("you are very old");
            }
            Console.ReadLine();
        }
    }
    class BreakExample
    {
        static void Main(string[] args)
        {
            //đề nghị người dùng chọn 1 lựa chọn
            Console.WriteLine("Please select one option");
            Console.WriteLine("1-Select play game ");
            Console.WriteLine("2-Select Working ");
            Console.WriteLine("3-Select Go to play ");
            
            //Khai báo biến a
            int a;

            //Chuỗi người dùng nhập từ bàn phím
            string inputStr = Console.ReadLine();

            //Chuỗi thành số
            a = Int32.Parse(inputStr);

            //Kiểm tra giá trị biến
            switch(a)
            {
                case 1:
                    Console.WriteLine("you choose to play game ");
                    break;

                case 2:
                    Console.WriteLine("you choose working");
                    break;

                case 3:
                    Console.WriteLine("you choose to go to play");
                    break;
                default:
                    Console.WriteLine("Nothing to do ...");
                    break;
            }
            Console.ReadLine();
        }
    }
    class BreakExample2
    {
        static void Main(string[] args)
        {
            //Khai báo biến và gán trị cho biến
            Console.OutputEncoding = ASCIIEncoding.UTF8;
            Console.WriteLine("Nhập giá trị của a");
            int a;
            string inputa = Console.ReadLine();
            a = Int32.Parse(inputa);
            Console.WriteLine("a ={0}", a);
            
            //Kiểm tra giá trị biến
            switch(a)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Case 2,3,4,5");
                    break;
                default:
                    Console.WriteLine("Nothing to do");
                    break;
                 
            }
            Console.ReadLine();
        }
    }
    class ForLoopExample
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding = ASCIIEncoding.UTF8;
            Console.WriteLine("Loop Example");
            // Tạo biến, gán giá trị cho biến
            // Điều kiện kiểm tra cho biến, nếu đúng thì cho chạy 
            // Mỗi bước lặp tăng lên 3 giá trị
            for (int a = 2; a < 30; a = a + 3)
            {
                Console.WriteLine();
                Console.WriteLine("Giá trị của a ={0}", a);
            }
            Console.ReadLine();
        }
    }
    class 
        WhileLoopExample
    {
        static void Main(string[]args)
        {
            Console.OutputEncoding = ASCIIEncoding.UTF8;
            Console.WriteLine("While Loop Example");
            //Tạo biến, gán giá trị cho biến
            Console.WriteLine("Nhập giá trị của a");
            int a;
            string inputa = Console.ReadLine();
            a = Int32.Parse(inputa);

            //Điều kiện cho biến
            while(a<10)
            {
                a = a + 2;
                Console.WriteLine("Giá trị của biến là {0}", a);
               
            }
            Console.ReadLine();
        }
    }

    class DoWhileLoopExample
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = ASCIIEncoding.UTF8;
            Console.WriteLine("Do-While-Loop-Example");
            //Tạo gán giá trị cho biến
            Console.WriteLine("Nhập giá trị cho biến!!!");
            int a;
            string inputa = Console.ReadLine();
            a = Int32.Parse(inputa);

            //Thực hiện kiểm tra điều kiện sau mỗi bước lặp, đúng thì thực thi tiếp
            do
            {
                Console.WriteLine("Giá trị của biến là {0}", a);
                a = a + 1;
            }
            while (a < 10);
            Console.ReadLine();
        }
    }
    class LoopBreakExample
    {
        static void Main (string[]args)
        {
            Console.OutputEncoding = ASCIIEncoding.UTF8;
            Console.WriteLine("Break Example");
            //Tạo  biến, gán giá trị
            Console.WriteLine("Nhập giá trị biến");
            int a;
            string inputa = Console.ReadLine();
            a = Int32.Parse(inputa);

            while (a<10)
            {
                Console.WriteLine("---------");
                Console.WriteLine("Giá trị biến là {0}", a);

                // Kiểm tra nếu a=5 thì thoát khỏi vòng lặp
                if(a==5)
                {
                    break;
                }
                a++;
                Console.WriteLine("a after ++ = {0}", a);
            }
            Console.ReadLine();
        }
    }

    class ArrayExample
    {
        static void Main(string[]args)
        {
            //Khai báo mảng, chỉ định giá trị cho mảng
            int[] number = { 1, 5, 9, 11, 13, 17, 19, 23 };

            //Length - property của mảng, trả về phần tử của mảng
            Console.OutputEncoding = ASCIIEncoding.UTF8;
            Console.WriteLine("Element count of array year = {0}", number.Length);

            //Sử dụng vòng lặp in ra phần tử của bảng
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("Giá trị tại {0}={1}", i, number[i]);
            }
            Console.ReadLine();

            //Khai báo 1 loạt mảng 
            //float[] mang = new float[5];
            //mang[0] = 1;
            //mang[1] = 2;
            //mang[2] = 5;
            //mang[3] = 6;
            //mang[4] = 7;
            
            //Console.ReadLine();
        }
    }
    //Mảng 2 chiều
    class Array2Example
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                    {1,2,3,4,5 },
                    {2,4,6,8,9 },
                    {1,3,5,7,9 },
                };

            //Sử dụng vòng lặp for để in ra phần tử
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.WriteLine("Giá trị phần tử là {0},{1}={2}", row, col, a[row, col]);

                }
                Console.WriteLine("-----------------");
            }
            //Khai báo mảng 2 chiều 3 dòng 5 cột
            //các phần tử chưa đc gán giá trị
            int[,] b = new int[3, 5];
            Console.ReadLine();
        }
    }
   class Person
    {
        //Trường lưu trữ tên người
        public string Name;

        //Cấu tử có name giống tên lớp
        public Person(string PersonName)
        {
            //Gán giá trị cho trường Name
            this.Name = PersonName;
        }
            //Trả về kiểu String
            public string getName()
        {
            return this.Name;
        }
    }
}
