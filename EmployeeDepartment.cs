internal class Department
{
    private string name;
    private Employee manager;

    public Department(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Employee Manager
    {
        get { return manager; }
        set { manager = value; }
    }
}

internal class Employee
{
    private string name;
    private Department department;

    public Employee(string name, Department department)
    {
        this.name = name;
        this.department = department;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Department Department
    {
        get { return department; }
        set { department = value; }
    }

    public override string ToString()
    {
        if (this.department.Manager == this)
        {
            return this.name + " начальник отдела " + this.department.Name;
        }
        else
        {
            string managerName;
            if (this.department.Manager != null)
            {
                managerName = this.department.Manager.Name;
            }
            else
            {
                managerName = "не назначен";
            }

            return this.name + " работает в отделе " + this.department.Name + ", начальник которого " + managerName;
        }
    }
}