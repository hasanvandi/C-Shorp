

namespace Doors;

    public abstract class Door : IDoor
    {
        public void Close()
        {
            Console.WriteLine("close the door");
        }

        public void Open()
        {
            Console.WriteLine("open the door");
        }

        public void Lock()
        {
            Console.WriteLine("Door Locked");
        }
    }

