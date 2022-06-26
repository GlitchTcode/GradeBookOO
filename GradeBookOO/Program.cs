namespace GradeBookOO
{
    internal class Program
    {
        static public void Main(string[] args)
        {   
           
            int averageGrade = 0;
            int ticker = 0;
            char selection;
            int studentcount = 3;
            var test = new List<ClassRoom>()
            {
                new ClassRoom("Botany"),
                new ClassRoom("German"),
                new ClassRoom("Computer Science"),
                new ClassRoom("Batology")
            };

            var test1 = new List<Student>(){
                new Student(1, "Bob" /*, "Assingment1", 89*/),
                new Student(2, "Mars"/*, "Assignment1", 55*/)
                    };

            test1[0].grades.Add("Assignment1", 55);
            test1[1].grades.Add("Assignment1", 85);
            test1[0].grades.Add("Assignment2", 99);
            test1[1].grades.Add("Assignment2", 87);

            MainMenu();
            void MainMenu()
            {
            BREAK1:
                
                Console.Clear();
                Console.WriteLine("\nWelcome to the Classroom Organizer 2002: You might have class but the kids sure don't!\n\n\n\n");
                Console.WriteLine("1. Show Classrooms");
                Console.WriteLine("2. Add Classroom");
                Console.WriteLine("3. Remove Classroom");
                Console.WriteLine("4. Classroom Details");
                Console.WriteLine("5. Exit the program");
                Console.Write("Please enter a selection:");
                //Here to catch format exception when someone just hits enter or types a non-number character in 
                try
                {
                    selection = char.Parse(Console.ReadLine().Trim(' '));
                }
                catch (FormatException)
                {
                    goto BREAK1;
                }
                if (selection > '5' || selection < '1')
                {
                    Console.WriteLine("That is not a valid selection, please choose a valid option. Press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    goto BREAK1;
                }
                switch (selection)
                {
                    case '1':
                        Console.WriteLine("\nThese are the classroom that are currently stored:\n\n\n\n");
                        foreach (ClassRoom room in test)
                        {
                            room.ShowClass();
                        }
                        Console.WriteLine("\n\nPlease press enter to return to main menu.");
                        Console.ReadLine();

                        goto BREAK1;
                    case '2':
                    BREAK2:
                        Console.Clear();
                        string newClass;
                        Console.WriteLine("\nWelcome to the More School Classroom Adding Tool: Never too old school for new school!");
                        Console.WriteLine("\nThese are the classroom that are currently stored:\n\n\n\n");
                        foreach (ClassRoom room in test)
                        {
                            room.ShowClass();
                        }
                        Console.WriteLine("\n\n\nSelect an option:");
                        Console.WriteLine("1. Add a classroom");
                        Console.WriteLine("2. Return to main menu");
                        Console.Write("Please enter a selection: ");
                        try
                        {
                            selection = char.Parse(Console.ReadLine().Trim(' '));
                        }
                        catch (FormatException)
                        {
                            goto BREAK2;
                        }
                        if (selection > '2' || selection < '1')
                        {
                            Console.WriteLine("That is not a valid selection, please choose a valid option. Press enter to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            goto BREAK2;
                        }
                        switch (selection)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("\n\nThis will add a classroom to the system.");
                                Console.Write("\n\nPlease enter the name of the classroom: ");
                                newClass = Console.ReadLine();
                                test.Add(new ClassRoom(newClass));
                                //Array.Resize(ref test, test.Length + 1);
                                //test[test.Length - 1] = new ClassRoom(newClass);
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n" + newClass + " added! Press enter to continue!");
                                Console.ReadLine();
                                goto BREAK2;

                            case '2':
                                Console.Clear();
                                Console.Write("\n\n\n\n\n\n\nReturning to main menu");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                goto BREAK1;
                        }

                        break;
                    case '3':
                    BREAK3:
                        Console.Clear();

                        Console.WriteLine("\nWelcome to the Brain Wipe Class Removing Tool: Like the Summer Slide in digital form!");
                        Console.WriteLine("\nThese are the classroom that are currently stored:\n\n\n\n");
                        foreach (ClassRoom room in test)
                        {
                            room.ShowClass();
                        }
                        Console.WriteLine("\n\n\nSelect an option:");
                        Console.WriteLine("1. Remove a classroom");
                        Console.WriteLine("2. Return to main menu");
                        Console.Write("Please enter a selection: ");
                        try
                        {
                            selection = char.Parse(Console.ReadLine().Trim(' '));
                        }
                        catch (FormatException)
                        {
                            goto BREAK3;
                        }
                        if (selection > '2' || selection < '1')
                        {
                            Console.WriteLine("That is not a valid selection, please choose a valid option. Press enter to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            goto BREAK3;
                        }
                        switch (selection)
                        {
                            case '1':
                                string remClass;
                                Console.WriteLine("\n\nThis will remove a classroom from the system.");
                                Console.Write("\n\nPlease enter the name of the classroom: ");
                                remClass = Console.ReadLine();
                                for (int i = 0; i <= test.Count - 1; i++)
                                {
                                    if (test[i].name.Equals(remClass))
                                    {
                                        test.RemoveAt(i);
                                    }
                                }
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n" + remClass + " removed! Press enter to continue!");
                                Console.ReadLine();
                                goto BREAK3;

                            case '2':
                                Console.Clear();
                                Console.Write("\n\n\n\n\n\n\nReturning to main menu");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                goto BREAK1;
                        }
                        break;
                    case '4':
                    BREAK4:
                        Console.Clear();
                        Console.WriteLine("\nWelcome to Classroom Details: Keep track of the deets!\n\n\n\n");
                        Console.WriteLine("1. Show Students");
                        Console.WriteLine("2. Add Student");
                        Console.WriteLine("3. Remove Student");
                        Console.WriteLine("4. Compare Students");
                        Console.WriteLine("5. Average");
                        Console.WriteLine("6. Best Student");
                        Console.WriteLine("7. Worst Student");
                        Console.WriteLine("8. Student Details");
                        Console.WriteLine("9. Exit to main menu");
                        Console.Write("Please enter a selection:");

                        //Here to catch format exception when someone just hits enter or types a non-number character in 
                        try
                        {
                            selection = char.Parse(Console.ReadLine().Trim(' '));
                        }
                        catch (FormatException)
                        {
                            goto BREAK4;
                        }
                        if (selection > '9' || selection < '1')
                        {
                            Console.WriteLine("That is not a valid selection, please choose a valid option. Press enter to continue.");
                            Console.ReadLine();
                            Console.Clear();
                            goto BREAK4;
                        }
                        switch (selection)
                        {
                            case '1':
                                Console.WriteLine("\n\nThese are the currently enrolled students:");
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {
                                    Console.WriteLine("Student ID: " + test1[i].id + " Name: " + test1[i].name);
                                }
                                Console.WriteLine("\n\nPlease press enter to return to the previous menu.");
                                Console.ReadLine();
                                goto BREAK4;

                            case '2':
                                Console.Clear();
                                Console.WriteLine("\n\nThis is the Add Student utility.");
                                Console.WriteLine("\n\nThese are the currently enrolled students:");
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {
                                    Console.WriteLine("Student ID: " + test1[i].id + " Name: " + test1[i].name);
                                }
                                Console.Write("\n\n\n\nPlease enter the name of the student you would like to add:");
                                string newStudent = Console.ReadLine();
                                test1.Add(new Student(studentcount, newStudent));
                                studentcount++;
                                Console.WriteLine("Added " + newStudent + " to students registry!");
                                Console.WriteLine("Press enter to return to previous menu");
                                Console.ReadLine();
                                goto BREAK4;

                            case '3':
                                Console.Clear();
                                Console.WriteLine("\n\nThis is the Remove Student utility.");
                                Console.WriteLine("\n\nThese are the currently enrolled students:");
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {
                                    Console.WriteLine("Student ID: " + test1[i].id + " Name: " + test1[i].name);
                                }
                                Console.Write("\n\nPlease enter the name of the student you would like removed: ");
                                string remStudent = Console.ReadLine();
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {
                                    if (test1[i].name.Equals(remStudent))
                                    {
                                        test.RemoveAt(i);
                                        studentcount--;
                                    }
                                }
                                Console.WriteLine(remStudent + " has been removed! Shhhhhhhhhh ;-)");
                                Console.WriteLine("Press enter to return to previous menu");
                                Console.ReadLine();
                                goto BREAK4;
                            case '4':
                                Console.Clear();
                                Console.WriteLine("Welcome to the Comparatron 3000: If they aren't competing then you arent eating!");
                                Console.WriteLine("\n\nThese are the currently registered students");
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {
                                    Console.WriteLine("Student ID: " + test1[i].id + "| Name: " + test1[i].name + "| # of assignments graded: " + test1[i].grades.Count);
                                    
                                }
                                Console.Write("\n\nPlease enter the name of the first student to compare: ");
                                string comp1 = Console.ReadLine();
                                Console.Write("\n\nPlease enter the name of the second student to compare: ");
                                string comp2 = Console.ReadLine();
                                
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {
                                    if (test1[i].name.Equals(comp1))
                                    {   
                                        Student temp1;
                                        Student temp2;
                                        temp1 = test1[i];
                                        for (int j = 0; j <= test1.Count - 1; j++)
                                        {
                                            if (test1[j].name.Equals(comp2))
                                            {
                                                temp2 = test1[j];
                                                Console.WriteLine("The student with the best grade is " + temp1.CompareAverage(temp2));
                                                Console.WriteLine("Press enter to return to previous menu");
                                                Console.ReadLine();
                                                goto BREAK4;

                                            } 
                                        }
                                    }
                                }
                                
                                Console.WriteLine("One of those students is not in the registry. Please try again.");
                                Console.WriteLine("Press enter to return to previous menu");
                                Console.ReadLine();
                                goto BREAK4;

                            case '5':
                                
                                foreach(Student student in test1)
                                {
                                    averageGrade = averageGrade + student.ShowAverage();
                                    ticker += student.grades.Count();
                                }
                                Console.WriteLine("The average grade for all students is: " + (averageGrade / ticker));
                                Console.WriteLine("Press enter to return to previous menu");
                                Console.ReadLine();
                                goto BREAK4;

                            case '6':
                                Student highest = test1[0];
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {
                                    
                                    if (test1[i].ShowAverage() > highest.ShowAverage())
                                    {
                                        highest = test1[i];
                                    }
                                }
                                Console.WriteLine("The student with the highest average in the class is: ");
                                Console.WriteLine("Student ID: " + highest.id + "        Name: " + highest.name + "       Average Grade: " + highest.ShowAverage());

                                Console.WriteLine("Press enter to return to previous menu");
                                Console.ReadLine();
                                goto BREAK4;

                            case '7':
                                Student lowest = test1[0];
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {

                                    if (test1[i].ShowAverage() < lowest.ShowAverage())
                                    {
                                        lowest = test1[i];
                                    }
                                }
                                Console.WriteLine("The student with the lowest average in the class is: ");
                                Console.WriteLine("Student ID: " + lowest.id + "        Name: " + lowest.name + "        Average Grade: " + lowest.ShowAverage());

                                Console.WriteLine("Press enter to return to previous menu");
                                Console.ReadLine();
                                goto BREAK4;

                            case '8':
                                BREAK6:
                                Console.Clear();
                                Console.WriteLine("\n\nThis is the Eye Spy Student Details utility: I spy with my little eye...");
                                Console.WriteLine("\n\nThese are the currently enrolled students:");
                                for (int i = 0; i <= test1.Count - 1; i++)
                                {
                                    Console.WriteLine("Student ID: " + test1[i].id + " Name: " + test1[i].name);
                                }
                                Console.Write("\n\nPlease enter the name of the student you would like show and edit details: ");
                                string stuDetes = Console.ReadLine();
                                var chosenOne = new Student();
                                for (int i = 0; i <= test1.Count -1; i++)
                                {
                                    if (test1[i].name.Equals(stuDetes))
                                    {
                                        chosenOne = test1[i];      
                                    } 
                                }
                                BREAK7:
                                Console.Clear();
                                Console.WriteLine("You have selected:\n\n ");
                                chosenOne.ShowInfo();
                                Console.WriteLine("\n\nThese are your options to edit the student's details: ");
                                Console.WriteLine("1. Show Summary");
                                Console.WriteLine("2. Assign");
                                Console.WriteLine("3. Unassign");
                                Console.WriteLine("4. Show Assignments");
                                Console.WriteLine("5. Grade Assingment");
                                Console.WriteLine("6. Best Grade");
                                Console.WriteLine("7. Worst Grade");
                                Console.WriteLine("8. Exit");
                                Console.Write("Please enter a selection: ");
                                //Here to catch format exception when someone just hits enter or types a non-number character in 
                                try
                                {
                                    selection = char.Parse(Console.ReadLine().Trim(' '));
                                }
                                catch (FormatException)
                                {
                                    goto BREAK7;
                                }
                                if (selection > '8' || selection < '1')
                                {
                                    Console.WriteLine("That is not a valid selection, please choose a valid option. Press enter to continue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto BREAK7;
                                }
                                switch (selection)
                                {
                                    case '1':
                                        Console.WriteLine("Student Summary: ");
                                        chosenOne.ShowInfo();
                                        Console.WriteLine("Press enter to return to previous menu");
                                        Console.ReadLine();
                                        goto BREAK7;

                                    case '2':
                                        Console.WriteLine("\n\nAssingment Assigner Mk19: Assign the assignment!\n\n\n\n");
                                        chosenOne.ShowInfo();
                                        Console.Write("\n\nPlease enter the name of the assignment: ");
                                        chosenOne.grades.Add(Console.ReadLine(), 0);
                                        Console.WriteLine("Assignment added!");
                                        Console.WriteLine("Press enter to return to previous menu");
                                        Console.ReadLine();
                                        goto BREAK7;
                                    case '3':
                                        chosenOne.ShowInfo();
                                        Console.Write("Please choose the assignment you would like to remove: ");
                                        string keyRemove = Console.ReadLine();
                                        chosenOne.grades.Remove(keyRemove);
                                        Console.WriteLine("\n\n" + keyRemove + " removed!");
                                        Console.WriteLine("Press enter to return to previous menu");
                                        Console.ReadLine();
                                        goto BREAK7;

                                    case '4':
                                        Console.WriteLine("\n\nThese are the current assignments for " + chosenOne.name + ":\n\n");
                                        foreach (var item in chosenOne.grades)
                                        {
                                            Console.WriteLine(item.Key + ": " + item.Value);
                                        }
                                        Console.WriteLine("Press enter to return to previous menu");
                                        Console.ReadLine();
                                        goto BREAK7;

                                    case '5':
                                        Console.WriteLine("\n\nThese are the current assignments for " + chosenOne.name + ":\n\n");
                                        foreach (var item in chosenOne.grades)
                                        {
                                            Console.WriteLine(item.Key + ": " + item.Value);

                                        }
                                        Console.Write("Please choose the assignment you would like to grade: ");
                                        string assignGrade = Console.ReadLine();
                                        Console.Write("Please type in the new grade for the assignment: ");
                                        int newGrade =int.Parse(Console.ReadLine());

                                        foreach (var kvp in chosenOne.grades)
                                        {
                                            if (kvp.Key == assignGrade)
                                            {
                                                chosenOne.grades[assignGrade] = newGrade;
                                            }
                                        }
                                        Console.WriteLine("\n\n" + assignGrade + " changed!");
                                        Console.WriteLine("Press enter to return to previous menu");
                                        Console.ReadLine();
                                        goto BREAK7;

                                    case '6':
                                        Console.Clear();
                                        chosenOne.HighestGrade();
                                        Console.WriteLine("Press enter to return to previous menu");
                                        Console.ReadLine();
                                        goto BREAK7;

                                    case '7':
                                        Console.Clear();
                                        chosenOne.LowestGrade();
                                        Console.WriteLine("Press enter to return to previous menu");
                                        Console.ReadLine();
                                        goto BREAK7;

                                    case '8':
                                        Console.Clear();
                                        Console.Write("\n\n\n\n\n\n\nReturning to previous menu");
                                        Thread.Sleep(250);
                                        Console.Write(".");
                                        Thread.Sleep(250);
                                        Console.Write(".");
                                        Thread.Sleep(250);
                                        Console.Write(".");
                                        Thread.Sleep(250);
                                        Console.Write(".");
                                        Thread.Sleep(250);
                                        Console.Write(".");
                                        goto BREAK4;
                                }

                                goto BREAK6;

                            case '9':
                                Console.Clear();
                                Console.Write("\n\n\n\n\n\n\nReturning to main menu");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                Thread.Sleep(250);
                                Console.Write(".");
                                goto BREAK1;
                        }
                        break;
                    case '5':
                        string exit = @"

                                 ___ __  _ _  ___  _  _ _  ___         
                                | __>\ \/ | ||_ _|| || \ |/  _>        
                                | _>  \ \ | | | | | ||   || <_/\       
                                |___>_/\_\|_| |_| |_||_\_|`____/       
                                       
                                 ___   ___  ___  ___  ___  _ _  ___  _ 
                                /  _> | . || . || . \| . >| | || __>| |
                                | <_/\| | || | || | || . \\   /| _> |_/
                                `____/`___'`___'|___/|___/ |_| |___><_>
                                       

";
                        Console.Clear();
                        Console.WriteLine(exit);
                        Console.ReadLine();
                        break;

                }


            }
        }
    }
}